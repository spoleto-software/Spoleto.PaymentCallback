using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Spoleto.PaymentCallback.CloudKassir.Models
{
    /// <summary>
    /// Запрос массовой проверки кодов маркировки
    /// </summary>
    public class ValidateMarkCodesRequest
    {
        /// <summary>
        /// ИНН организации или ИП - пользователя кассы
        /// </summary>
        [JsonPropertyName("Inn")]
        public string Inn { get; set; }

        /// <summary>
        /// Коды маркировки
        /// </summary>
        [JsonPropertyName("MarkCodes")]
        public List<string> MarkCodes { get; set; }
    }
}
