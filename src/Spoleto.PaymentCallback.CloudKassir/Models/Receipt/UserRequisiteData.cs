using System;
using System.Text.Json.Serialization;

namespace Spoleto.PaymentCallback.CloudKassir.Models
{
    /// <summary>
    /// Дополнительный реквизит пользователя
    /// </summary>
    public class UserRequisiteData
    {
        /// <summary>
        /// Наименование дополнительного реквизита пользователя, тег ОФД 1085
        /// </summary>
        [JsonPropertyName("RequisiteKey")]
        public string RequisiteKey { get; set; }

        /// <summary>
        /// Значение дополнительного реквизита пользователя, тег ОФД 1086
        /// </summary>
        [JsonPropertyName("RequisiteValue")]
        public string RequisiteValue { get; set; }
    }
}
