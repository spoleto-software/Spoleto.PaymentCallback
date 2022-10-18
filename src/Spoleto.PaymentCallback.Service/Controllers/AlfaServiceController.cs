using System.Net;
using Spoleto.MQ.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Spoleto.PaymentCallback.AlfaBank;
using Spoleto.PaymentCallback.Service.Helpers;
using Spoleto.PaymentCallback.Service.Models.Alfa;
using Spoleto.PaymentCallback.Service.Services;

namespace Spoleto.PaymentCallback.Service.Controllers
{
    /// <summary>
    /// Callback for Alfa-Bank notifications (Fast payments).
    /// </summary>
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class AlfaServiceController : ControllerBase
    {
        private readonly ILogger<AlfaServiceController> _logger;
        private readonly AlfaBankQRCodeReportService _QRCodeReportService;
        private readonly ISender _sender;

        public AlfaServiceController(ILogger<AlfaServiceController> logger, AlfaBankQRCodeReportService QRCodeReportService, ISender sender)
        {
            _logger = logger;
            _QRCodeReportService = QRCodeReportService;
            _sender = sender;
        }

        [AllowAnonymous]
        [HttpGet]
        public ActionResult Index()
        {
            return Ok("Ok!");
        }

        [AllowAnonymous]
        [HttpPost]
        [Consumes(DefaultSettings.ContentType)]
        public async Task<QRCodeReport> CreateQRCodeReport(QRCodeReport report)
        {
            _logger.LogInformation($"{nameof(CreateQRCodeReport)}, QrcId = <{report.QrcId}>.");

            var json = JsonHelper.ToJson(report);
            _logger.LogInformation(json);

            var uniqueMessage = new AlfaBankQRCodeReport
            {
                QrcId = report.QrcId,
                Amount = report.Amount,
                Status = report.Status,
                Timestamp = report.Timestamp,
                TrxId = report.TrxId,
                Kzo = report.Kzo,
                ParamsId = report.ParamsId,
                PayerId = report.PayerId
            };

            await _sender.SendAsync(uniqueMessage);

            var reportModel = new QRCodeReportModel
            {
                QrcId = report.QrcId,
                Amount = report.Amount,
                Status = report.Status,
                Timestamp = report.Timestamp,
                TrxId = report.TrxId,
                OriginalReportModel = report
            };

            await _QRCodeReportService.CreateAsync(reportModel);

            return report;
        }

        [HttpGet("{trxId}")]
        [Produces(DefaultSettings.ContentType)]
        public async Task<ActionResult<QRCodeReport>> GetFiscalRequest(string trxId)
        {
            var obj = await _QRCodeReportService.GetAsync(trxId);
            if (obj == null)
            {
                return StatusCode((int)HttpStatusCode.NotFound, $"The QRCode report with the trxId = <{trxId}> is not found.");
            }

            return obj.OriginalReportModel;
        }

        [HttpGet("ByQrcId/{qrcId}")]
        [Produces(DefaultSettings.ContentType)]
        public async Task<ActionResult<IEnumerable<QRCodeReport>>> GetFiscalRequests(string qrcId)
        {
            var objList = await _QRCodeReportService.GetAsyncByQrcId(qrcId);
            if (objList == null)
            {
                return StatusCode((int)HttpStatusCode.NotFound, $"The QRCode reports with the qrcId = <{qrcId}> is not found.");
            }

            var result = objList.Select(x => x.OriginalReportModel);

            return Ok(result);
        }

        /// <summary>
        /// Вернуть последние 100 записей.
        /// </summary>
        /// <returns>Последние 100 записей.</returns>
        [HttpGet("GetAll")]
        [Produces(DefaultSettings.ContentType)]
        public async Task<ActionResult<IEnumerable<QRCodeReport>>> GetAll()
        {
            var objList = await _QRCodeReportService.GetAsync(f => true, 100);
            if (objList == null)
            {
                return StatusCode((int)HttpStatusCode.NotFound, $"The QRCode reports are not found.");
            }

            var result = objList.Select(x => x.OriginalReportModel);

            return Ok(result);
        }
    }
}