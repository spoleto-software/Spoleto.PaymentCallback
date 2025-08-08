using System;
using System.Text.Json.Serialization;

namespace Spoleto.PaymentCallback.CloudKassir.Models
{
    /// <summary>
    /// Запрос статуса чека
    /// </summary>
    public class ReceiptStatusRequest
    {
        /// <summary>
        /// Идентификатор чека
        /// </summary>
        [JsonPropertyName("Id")]
        public string Id { get; set; }
    }
}
