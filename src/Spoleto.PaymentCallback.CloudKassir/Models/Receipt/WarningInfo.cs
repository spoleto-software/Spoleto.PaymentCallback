using System;
using System.Text.Json.Serialization;

namespace Spoleto.PaymentCallback.CloudKassir.Models
{
    /// <summary>
    /// Информация о предупреждении
    /// </summary>
    public class WarningInfo
    {
        /// <summary>
        /// Код предупреждения
        /// </summary>
        [JsonPropertyName("Code")]
        public int Code { get; set; }

        /// <summary>
        /// Описание предупреждения
        /// </summary>
        [JsonPropertyName("Description")]
        public string Description { get; set; }

        /// <summary>
        /// Инструкция для решения проблемы
        /// </summary>
        [JsonPropertyName("ResolveAction")]
        public string ResolveAction { get; set; }
    }
}
