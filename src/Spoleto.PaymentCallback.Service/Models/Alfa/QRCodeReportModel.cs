using System.Text.Json.Serialization;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Spoleto.PaymentCallback.AlfaBank;

namespace Spoleto.PaymentCallback.Service.Models.Alfa
{
    /// <summary>
    /// Уведомлением от НСПК по адресу из параметра “notificationUrl”.
    /// </summary>
    /// <remarks>
    /// Модель, используемая для хранения в БД и отправке по RabbitMQ.
    /// </remarks>
    public class QRCodeReportModel
    {
        /// <summary>
        /// Id для MongoDB
        /// </summary>
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        /// <summary>
        /// Идентификатор QR-кода.
        /// </summary>
        [JsonPropertyName("qrcId")]
        //[Required]
        public string QrcId { get; set; }

        /// <summary>
        /// Номер транзакции СБП.
        /// </summary>
        [JsonPropertyName("trxId")]
        public string TrxId { get; set; }

        /// <summary>
        /// Статус оплаты QR-кода в НСПК.
        /// </summary>
        /// <remarks>
        /// Успешно оплаченным считается только QR-код, для которого получен «status» =  «ACWP» и «trxId».<br/>
        /// «status» = «NTST», «RCVD» или «ACTC» - означает необходимость повтора запроса до получения одного из финальных статусов «ACWP» или «RJCT».<br/>
        /// Получение «status» = «RJCT» означает отказ в оплате данного QR-кода
        /// </remarks>
        [JsonPropertyName("status")]
        //[Required]
        public QRCodeStatus Status { get; set; }

        /// <summary>
        /// Сумма операции СБП.
        /// </summary>
        [JsonPropertyName("amount")]
        public decimal? Amount { get; set; }

        /// <summary>
        /// Дата и время выполнения Операции СБП.
        /// </summary>
        [JsonPropertyName("timestamp")]
        public DateTime? Timestamp { get; set; }

        public QRCodeReport OriginalReportModel { get; set; }
    }
}
