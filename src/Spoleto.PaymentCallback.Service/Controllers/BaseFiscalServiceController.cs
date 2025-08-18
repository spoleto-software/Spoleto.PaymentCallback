using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Spoleto.PaymentCallback.Service.Models.Base;
using Spoleto.PaymentCallback.Service.Services;
using System.Text.Json;

namespace Spoleto.PaymentCallback.Service.Controllers
{
    /// <summary>
    /// Base abstract controller for fiscal callback
    /// </summary>
    /// <typeparam name="TRequest"></typeparam>
    /// <typeparam name="TReportModel"></typeparam>
    [Authorize]
    [ApiController]
    public abstract class BaseFiscalCallbackController<TRequest, TReportModel> : ControllerBase
        where TRequest : BaseFiscalRequest
    {
        protected readonly ILogger<BaseFiscalCallbackController<TRequest, TReportModel>> _logger;
        protected readonly BaseFiscalRequestService<TRequest> _fiscalRequestService;

        protected BaseFiscalCallbackController(
            ILogger<BaseFiscalCallbackController<TRequest, TReportModel>> logger,
            BaseFiscalRequestService<TRequest> fiscalRequestService)
        {
            _logger = logger;
            _fiscalRequestService = fiscalRequestService;
        }

        [AllowAnonymous]
        [HttpGet]
        public virtual ActionResult Index() => Ok("Ok!");

        protected abstract Task<TRequest> CreateFiscalRequestFromModel(TReportModel reportModel);
        protected abstract TReportModel ExtractReportModelFromRequest(TRequest request);
        protected abstract Task<bool> ValidateRequestAsync(TReportModel reportModel);
        protected abstract Task PostProcessRequestAsync(TRequest request);
        protected abstract string GetExternalId(TReportModel reportModel);
        protected abstract string GetId(TReportModel reportModel);
        protected async Task<IActionResult> ProcessFiscalRequest(TReportModel reportModel)
        {
            try
            {
                var externalId = GetExternalId(reportModel);
                var id = GetId(reportModel);
                _logger.LogInformation("ProcessFiscalRequest, id = {Id}, external_id = <{ExternalId}>", id, externalId);

                if (!await ValidateRequestAsync(reportModel))
                {
                    _logger.LogWarning("Request validation failed for id = {Id}, external_id = <{ExternalId}>", id, externalId);
                    return BadRequest();
                }

                var fiscalRequest = await CreateFiscalRequestFromModel(reportModel);
                await _fiscalRequestService.CreateAsync(fiscalRequest);
                await PostProcessRequestAsync(fiscalRequest);

                return Ok(new { code = 0 });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error processing fiscal request");
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpGet("{uuid}")]
        [Produces(DefaultSettings.ContentType)]
        public async Task<ActionResult<TReportModel>> GetFiscalRequest(string uuid)
        {
            try
            {
                var request = await _fiscalRequestService.GetAsync(uuid);
                if (request == null)
                {
                    return NotFound($"The fiscal request with the uuid = <{uuid}> not found.");
                }

                return Ok(ExtractReportModelFromRequest(request));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error getting fiscal request by uuid: {Uuid}", uuid);
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpGet("BySaleSlipId/{saleSlipId:guid}")]
        [Produces(DefaultSettings.ContentType)]
        public async Task<ActionResult<TReportModel>> GetFiscalRequestBySaleSlipId(Guid saleSlipId)
        {
            try
            {
                var request = await _fiscalRequestService.GetAsyncBySaleSlipId(saleSlipId);
                if (request == null)
                {
                    return NotFound($"The fiscal request with the sale slip Id = <{saleSlipId}> not found.");
                }

                return Ok(ExtractReportModelFromRequest(request));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error getting fiscal request by sale slip id: {SaleSlipId}", saleSlipId);
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpGet("ByFiscalCheckNumber/{number:int}")]
        [Produces(DefaultSettings.ContentType)]
        public async Task<ActionResult<TReportModel>> GetFiscalRequestByFiscalCheckNumber(int number)
        {
            try
            {
                var request = await _fiscalRequestService.GetAsyncByFiscalCheckNumber(number);
                if (request == null)
                {
                    return NotFound($"The fiscal request with the fiscal check number = <{number}> not found.");
                }

                return Ok(ExtractReportModelFromRequest(request));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error getting fiscal request by fiscal check number: {Number}", number);
                return StatusCode(500, "Internal server error");
            }
        }

        [AllowAnonymous]
        [HttpPost("analyze-json")]
        public async Task<IActionResult> AnalyzeJson()
        {
            try
            {
                // Читаем сырое тело запроса
                Request.EnableBuffering();
                Request.Body.Position = 0;

                using var reader = new StreamReader(Request.Body, leaveOpen: true);
                var rawBody = await reader.ReadToEndAsync();

                Request.Body.Position = 0;

                _logger.LogInformation("=== JSON ANALYSIS START ===");
                _logger.LogInformation("Content-Type: {ContentType}", Request.ContentType);
                _logger.LogInformation("Content-Length: {ContentLength}", Request.ContentLength);
                _logger.LogInformation("Raw Body: {RawBody}", rawBody);



                _logger.LogInformation("=== JSON ANALYSIS END ===");

                return Ok(new { code = 0 });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error analyzing JSON");
                return StatusCode(500, new { error = ex.Message, stackTrace = ex.StackTrace });
            }
        }

    }
}
