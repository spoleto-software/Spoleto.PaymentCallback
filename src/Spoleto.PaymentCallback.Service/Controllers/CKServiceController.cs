using System.Net;
using System.Text;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Spoleto.MQ.Interfaces;
using Spoleto.PaymentCallback.AtolOnline.Models;
using Spoleto.PaymentCallback.CloudKassir.Models;
using Spoleto.PaymentCallback.Service.Helpers;
using Spoleto.PaymentCallback.Service.Models.CloudKassir;
using Spoleto.PaymentCallback.Service.Services;

namespace Spoleto.PaymentCallback.Service.Controllers
{
    /// <summary>
    /// Callback for CloudKassir notifications.
    /// </summary>
    [Route("[controller]")]
    public class CKServiceController : BaseFiscalCallbackController<CKFiscalRequest, ReceiptNotification>
    {
        private readonly ISender _sender;
        private readonly CKSettings _settings;

        public CKServiceController(
            ILogger<CKServiceController> logger,
            CKFiscalRequestService fiscalRequestService,
            ISender sender,
            IOptions<CKSettings> apiSettings)
            : base(logger, fiscalRequestService)
        {
            _sender = sender;
            _settings = apiSettings.Value;
        }

        [AllowAnonymous]
        [HttpPost]
        [Consumes("application/x-www-form-urlencoded")]
        public async Task<IActionResult> CreateFiscalRequest([FromForm] ReceiptNotification reportModel)
        {
            _logger.LogInformation("CloudKassir callback received");
            return await ProcessFiscalRequest(reportModel);
        }
        protected override async Task<CKFiscalRequest> CreateFiscalRequestFromModel(ReceiptNotification reportModel)
        {
            return new CKFiscalRequest
            {
                SaleSlipId = Guid.TryParse(reportModel.InvoiceId, out var tmp) ? tmp : null,
                Uuid = reportModel.Id,
                Timestamp = DateTime.UtcNow,
                ReceiptNotification = reportModel
            };
        }

        protected override ReceiptNotification ExtractReportModelFromRequest(CKFiscalRequest request)
        {
            return request.ReceiptNotification;
        }

        protected override async Task<bool> ValidateRequestAsync(ReceiptNotification reportModel)
        {
            if (!_settings.EnableHmacValidation)
            {
                _logger.LogWarning("HMAC validation is disabled for debugging purposes");
                return true;
            }

            var isValid = await HMACHelper.VerifyRequestHmacAsync(Request, _settings.ApiSecret);
            if (!isValid)
            {
                _logger.LogWarning("HMAC validation failed for: {Id}", reportModel.Id);
            }

            return isValid;
        }

        protected override async Task PostProcessRequestAsync(CKFiscalRequest request)
        {
            if (!_settings.EnableMessageQueue)
            {
                _logger.LogDebug("Message queue is disabled, skipping fiscal report sending");
                return;
            }

            var fiscalReport = new CKFiscalReport
            {
                Id = request.ReceiptNotification.Id,
                DocumentNumber = request.ReceiptNotification.DocumentNumber,
                SessionNumber = request.ReceiptNotification.SessionNumber,
                Number = request.ReceiptNotification.Number,
                FiscalSign = request.ReceiptNotification.FiscalSign,
                DeviceNumber = request.ReceiptNotification.DeviceNumber,
                RegNumber = request.ReceiptNotification.RegNumber,
                FiscalNumber = request.ReceiptNotification.FiscalNumber,
                Inn = request.ReceiptNotification.Inn,
                Type = request.ReceiptNotification.Type,
                Ofd = request.ReceiptNotification.Ofd,
                Url = request.ReceiptNotification.Url,
                QrCodeUrl = request.ReceiptNotification.QrCodeUrl,
                TransactionId = request.ReceiptNotification.TransactionId,
                Amount = request.ReceiptNotification.Amount,
                DateTime = request.ReceiptNotification.DateTime,
                InvoiceId = request.ReceiptNotification.InvoiceId,
                AccountId = request.ReceiptNotification.AccountId,
                Receipt = request.ReceiptNotification.Receipt,
                CalculationPlace = request.ReceiptNotification.CalculationPlace,
                CashierName = request.ReceiptNotification.CashierName,
                SettlePlace = request.ReceiptNotification.SettlePlace,
                Timestamp = DateTime.UtcNow
            };

            try
            {
                await _sender.SendAsync(fiscalReport);
                _logger.LogInformation("Fiscal report sent to message queue for Id: {Id}", request.ReceiptNotification.Id);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to send fiscal report to message queue for Id: {Id}", request.ReceiptNotification.Id);
            }

        }

        protected override string GetExternalId(ReceiptNotification reportModel)
        {
            return reportModel.InvoiceId;
        }
        protected override string GetId(ReceiptNotification reportModel)
        {
            return reportModel.Id;
        }
    }
}
