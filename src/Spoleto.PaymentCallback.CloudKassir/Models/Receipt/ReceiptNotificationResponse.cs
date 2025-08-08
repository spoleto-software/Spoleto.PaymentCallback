using System;
using System.Text.Json.Serialization;

namespace Spoleto.PaymentCallback.CloudKassir.Models
{
    /// <summary>
    /// Ответ на уведомление о чеке
    /// </summary>
    public class ReceiptNotificationResponse
    {
        /// <summary>
        /// Код результата (0 - чек зарегистрирован)
        /// </summary>
        [JsonPropertyName("code")]
        public int Code { get; set; }
    }

}
