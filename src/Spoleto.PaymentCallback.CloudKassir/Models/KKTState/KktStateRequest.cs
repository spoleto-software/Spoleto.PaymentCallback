using System;
using System.Text.Json.Serialization;

namespace Spoleto.PaymentCallback.CloudKassir.Models
{
    /// <summary>
    /// Запрос изменения состояния кассы
    /// </summary>
    public class KktStateRequest
    {
        /// <summary>
        /// ИНН организации или ИП - пользователя кассы
        /// </summary>
        [JsonPropertyName("Inn")]
        public string Inn { get; set; }

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

        /// <summary>
        /// Флаг помещения кассы на техобслуживание
        /// </summary>
        [JsonPropertyName("OnMaintenance")]
        public bool OnMaintenance { get; set; }
    }
}
