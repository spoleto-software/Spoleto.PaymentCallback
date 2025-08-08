using System;
using System.Text.Json.Serialization;

namespace Spoleto.PaymentCallback.CloudKassir.Models
{
    /// <summary>
    /// Результат проверки кода маркировки
    /// </summary>
    public class MarkCodeValidationResult
    {

        /// <summary>
        /// Отраслевой реквизит
        /// </summary>
        [JsonPropertyName("IndustryRequisite")]
        public IndustryRequisite IndustryRequisite { get; set; }

        /// <summary>
        /// Флаг валидности КМ
        /// </summary>
        [JsonPropertyName("IsValid")]
        public bool IsValid { get; set; }
        /// <summary>
        /// Код маркировки
        /// </summary>
        [JsonPropertyName("MarkCode")]
        public string MarkCode { get; set; }

        /// <summary>
        /// Сообщение об ошибке
        /// </summary>
        [JsonPropertyName("Message")]
        public string Message { get; set; }
    }
}
