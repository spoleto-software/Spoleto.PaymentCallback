using System;
using Spoleto.PaymentCallback.AtolOnline.Models;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Spoleto.PaymentCallback.Service.Models.AtolOnline
{
    public class FiscalRequest
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string Uuid { get; set; }

        public Guid SaleSlipId { get; set; }

        public DateTime Timestamp { get; set; }

        public ReportModel OriginalReportModel { get; set; }
    }
}
