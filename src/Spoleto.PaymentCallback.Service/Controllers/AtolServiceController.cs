using System.Net;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Spoleto.PaymentCallback.AtolOnline.Models;
using Spoleto.PaymentCallback.Service.Models.AtolOnline;
using Spoleto.PaymentCallback.Service.Services;

namespace Spoleto.PaymentCallback.Service.Controllers
{
    /// <summary>
    /// Callback for AtolOnline notifications.
    /// </summary>
    [Route("[controller]")]
    public class AtolServiceController : BaseFiscalCallbackController<AtolFiscalRequest, ReportModel>
    {
        public AtolServiceController(
            ILogger<AtolServiceController> logger,
            AtolOnlineFiscalRequestService fiscalRequestService)
            : base(logger, fiscalRequestService)
        {
        }

        [AllowAnonymous]
        [HttpPost]
        [Consumes(DefaultSettings.ContentType)]
        public async Task<IActionResult> CreateFiscalRequest([FromBody] ReportModel reportModel)
        {
            _logger.LogInformation("AtolOnline callback received");

            return await ProcessFiscalRequest(reportModel);
        }

        protected override async Task<AtolFiscalRequest> CreateFiscalRequestFromModel(ReportModel reportModel)
        {
            if (!Guid.TryParse(reportModel.ExternalId, out var saleSlipId))
            {
                throw new ArgumentException($"Invalid ExternalId format: {reportModel.ExternalId}");
            }

            return new AtolFiscalRequest
            {
                SaleSlipId = saleSlipId,
                Uuid = reportModel.Uuid,
                Timestamp = DateTime.UtcNow,
                OriginalReportModel = reportModel
            };
        }

        protected override ReportModel ExtractReportModelFromRequest(AtolFiscalRequest request)
        {
            return request.OriginalReportModel;
        }

        protected override async Task<bool> ValidateRequestAsync(ReportModel reportModel)
        {
            return await Task.FromResult(true);
        }

        protected override async Task PostProcessRequestAsync(AtolFiscalRequest request)
        {
            await Task.CompletedTask;
        }

        protected override string GetExternalId(ReportModel reportModel)
        {
            return reportModel.ExternalId;
        }

        protected override string GetId(ReportModel reportModel)
        {
            return reportModel.Uuid;
        }
    }
}
