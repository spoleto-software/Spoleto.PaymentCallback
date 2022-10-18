using System.Net;
using Microsoft.AspNetCore.Mvc;
using Spoleto.PaymentCallback.AtolOnline.Models;
using Spoleto.PaymentCallback.Service.Models.AtolOnline;
using Spoleto.PaymentCallback.Service.Services;

namespace Spoleto.PaymentCallback.Service.Controllers
{
    /// <summary>
    /// Callback for AtolOnline notifications.
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class AtolServiceController : ControllerBase
    {
        private readonly ILogger<AtolServiceController> _logger;
        private readonly AtolOnlineFiscalRequestService _fiscalRequestService;

        public AtolServiceController(ILogger<AtolServiceController> logger, AtolOnlineFiscalRequestService fiscalRequestService)
        {
            _logger = logger;
        }

        [HttpPost]
        [Consumes(DefaultSettings.ContentType)]
        public async Task<FiscalRequest> CreateFiscalRequest(ReportModel reportModel)
        {
            _logger.LogInformation($"CreateFiscalRequest, external_id = <{reportModel.ExternalId}>.");
            var fiscalRequest = new FiscalRequest
            {
                SaleSlipId = Guid.Parse(reportModel.ExternalId),
                Uuid = reportModel.Uuid,
                Timestamp = DateTime.UtcNow,
                OriginalReportModel = reportModel
            };

            await _fiscalRequestService.CreateAsync(fiscalRequest);

            return fiscalRequest;
        }

        [HttpGet("{uuid:length(36)}")]
        [Produces(DefaultSettings.ContentType)]
        public async Task<ActionResult<ReportModel>> GetFiscalRequest(string uuid)
        {
            var obj = await _fiscalRequestService.GetAsync(uuid);
            if (obj == null)
            {
                return StatusCode((int)HttpStatusCode.NotFound, $"The fiscal request with the uuid = <{uuid}> not found.");
            }

            return obj.OriginalReportModel;
        }

        [HttpGet("BySaleSlipId/{saleSlipId:guid}")]
        [Produces(DefaultSettings.ContentType)]
        public async Task<ActionResult<ReportModel>> GetFiscalRequestBySaleSlipId(Guid saleSlipId)
        {
            var obj = await _fiscalRequestService.GetAsyncBySaleSlipId(saleSlipId);
            if (obj == null)
            {
                return StatusCode((int)HttpStatusCode.NotFound, $"The fiscal request with the sale slip Id = <{saleSlipId}> not found.");
            }

            return obj.OriginalReportModel;
        }

        [HttpGet("ByFiscalCheckNumber/{number:int}")]
        [Produces(DefaultSettings.ContentType)]
        public async Task<ActionResult<ReportModel>> GetFiscalRequestByFiscalCheckNumber(int number)
        {
            var obj = await _fiscalRequestService.GetAsyncByFiscalCheckNumber(number);
            if (obj == null)
            {
                return StatusCode((int)HttpStatusCode.NotFound, $"The fiscal request with the fiscal check number = <{number}> not found.");
            }

            return obj.OriginalReportModel;
        }
    }
}
