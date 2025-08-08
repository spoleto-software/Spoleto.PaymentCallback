using System;
using System.Text.Json.Serialization;

namespace Spoleto.PaymentCallback.CloudKassir.Models
{
    /// <summary>
    /// Ответ проверки кода маркировки
    /// </summary>
    public class ValidateMarkCodeResponse : BaseResponse
    {

        /// <summary>
        /// Отраслевой реквизит предмета расчета
        /// </summary>
        [JsonPropertyName("IndustryRequisite")]
        public IndustryRequisite IndustryRequisite { get; set; }
        /// <summary>
        /// Флаг валидности КМ
        /// </summary>
        [JsonPropertyName("IsValid")]
        public bool IsValid { get; set; }
    }
}
