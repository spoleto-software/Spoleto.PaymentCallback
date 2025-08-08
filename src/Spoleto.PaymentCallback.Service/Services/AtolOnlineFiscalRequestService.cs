using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Spoleto.PaymentCallback.Service.Models.AtolOnline;
using MongoDB.Driver;
using Spoleto.PaymentCallback.Service.Models;
using Microsoft.Extensions.Options;

namespace Spoleto.PaymentCallback.Service.Services
{
    public class AtolOnlineFiscalRequestService : BaseFiscalRequestService<AtolFiscalRequest>
    {
        public AtolOnlineFiscalRequestService(
            IOptions<AtolOnlineServiceDatabaseSettings> settings,
            ILogger<AtolOnlineFiscalRequestService> logger = null)
            : base(settings.Value, settings.Value.FiscalRequestsCollectionName, logger)
        {
        }

    }
}
