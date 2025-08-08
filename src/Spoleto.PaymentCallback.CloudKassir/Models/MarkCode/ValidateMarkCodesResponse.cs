using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Spoleto.PaymentCallback.CloudKassir.Models
{
    /// <summary>
    /// Ответ массовой проверки кодов маркировки
    /// </summary>
    public class ValidateMarkCodesResponse : BaseResponse
    {
        /// <summary>
        /// Массив результатов проверки
        /// </summary>
        [JsonPropertyName("Results")]
        public List<MarkCodeValidationResult> Results { get; set; }
    }
}
