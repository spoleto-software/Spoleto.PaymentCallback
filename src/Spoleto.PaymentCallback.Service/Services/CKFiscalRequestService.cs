using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using Spoleto.PaymentCallback.Service.Models;
using Spoleto.PaymentCallback.Service.Models.AtolOnline;
using Spoleto.PaymentCallback.Service.Models.CloudKassir;

namespace Spoleto.PaymentCallback.Service.Services
{
    public class CKFiscalRequestService : BaseFiscalRequestService<CKFiscalRequest>
    {
        public CKFiscalRequestService(
            IOptions<CKServiceDatabaseSettings> settings,
            ILogger<CKFiscalRequestService> logger = null)
            : base(settings.Value, settings.Value.FiscalRequestsCollectionName, logger)
        {
        }

    }
}
