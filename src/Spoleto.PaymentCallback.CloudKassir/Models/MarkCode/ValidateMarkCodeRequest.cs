using System;
using System.Text.Json.Serialization;

namespace Spoleto.PaymentCallback.CloudKassir.Models
{
    /// <summary>
    /// Запрос проверки кода маркировки
    /// </summary>
    public class ValidateMarkCodeRequest
    {
        /// <summary>
        /// ИНН организации или ИП - пользователя кассы
        /// </summary>
        [JsonPropertyName("Inn")]
        public string Inn { get; set; }

        /// <summary>
        /// Код маркировки
        /// </summary>
        [JsonPropertyName("MarkCode")]
        public string MarkCode { get; set; }
    }
}
