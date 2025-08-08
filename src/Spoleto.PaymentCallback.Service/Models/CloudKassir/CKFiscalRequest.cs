using System;
using Spoleto.PaymentCallback.CloudKassir.Models;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Spoleto.PaymentCallback.Service.Models.Base;

namespace Spoleto.PaymentCallback.Service.Models.CloudKassir
{

    public class CKFiscalRequest : BaseFiscalRequest
    {
        public ReceiptNotification ReceiptNotification { get; set; }

        public override int GetFiscalDocumentNumber() =>
            int.TryParse(ReceiptNotification?.FiscalNumber, out var tmp) ? tmp:0;
    }
}