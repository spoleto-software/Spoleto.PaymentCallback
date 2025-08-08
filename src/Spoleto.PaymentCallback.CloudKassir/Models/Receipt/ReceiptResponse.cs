using System;
using System.Text.Json.Serialization;

namespace Spoleto.PaymentCallback.CloudKassir.Models
{
    /// <summary>
    /// Ответ на запрос формирования чека
    /// </summary>
    public class ReceiptResponse
    {

        /// <summary>
        /// Код ошибки
        /// </summary>
        [JsonPropertyName("ErrorCode")]
        public int ErrorCode { get; set; }
        /// <summary>
        /// Уникальный идентификатор чека
        /// </summary>
        [JsonPropertyName("Id")]
        public string Id { get; set; }

        /// <summary>
        /// URL для просмотра чека
        /// </summary>
        [JsonPropertyName("ReceiptLocalUrl")]
        public string ReceiptLocalUrl { get; set; }
    }
}
