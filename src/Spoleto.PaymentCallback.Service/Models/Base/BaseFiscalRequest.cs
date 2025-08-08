using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Spoleto.PaymentCallback.Service.Models.Base
{
    public abstract class BaseFiscalRequest
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string Uuid { get; set; }
        public Guid? SaleSlipId { get; set; }
        public DateTime Timestamp { get; set; }

        public abstract int GetFiscalDocumentNumber();

    }
}
