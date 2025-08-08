using System;
using System.Text.Json.Serialization;

namespace Spoleto.PaymentCallback.CloudKassir.Models
{
    /// <summary>
    /// Запрос получения данных кассы
    /// </summary>
    public class KktStateGetRequest
    {
        /// <summary>
        /// Заводской номер кассы
        /// </summary>
        [JsonPropertyName("DeviceNumber")]
        public string DeviceNumber { get; set; }

        /// <summary>
        /// Номер фискального накопителя
        /// </summary>
        [JsonPropertyName("FiscalNumber")]
        public string FiscalNumber { get; set; }
    }
}
