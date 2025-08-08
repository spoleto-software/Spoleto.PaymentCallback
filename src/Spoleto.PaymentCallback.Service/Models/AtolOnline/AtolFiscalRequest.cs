using System;
using Spoleto.PaymentCallback.AtolOnline.Models;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Spoleto.PaymentCallback.Service.Models.Base;

namespace Spoleto.PaymentCallback.Service.Models.AtolOnline
{
    public class AtolFiscalRequest : BaseFiscalRequest
    {
        public ReportModel OriginalReportModel { get; set; }

        public override int GetFiscalDocumentNumber() =>
            OriginalReportModel?.Payload?.FiscalDocumentNumber ?? 0;

    }
}
