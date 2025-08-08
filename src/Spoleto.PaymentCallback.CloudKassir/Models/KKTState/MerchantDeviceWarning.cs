using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Spoleto.PaymentCallback.CloudKassir.Models
{
    /// <summary>
    /// Предупреждения по кассам мерчанта
    /// </summary>
    public class MerchantDeviceWarning
    {
        /// <summary>
        /// Номер ККТ
        /// </summary>
        [JsonPropertyName("DeviceNumber")]
        public string DeviceNumber { get; set; }

        /// <summary>
        /// Массив предупреждений
        /// </summary>
        [JsonPropertyName("Warnings")]
        public List<WarningInfo> Warnings { get; set; }
    }
}
