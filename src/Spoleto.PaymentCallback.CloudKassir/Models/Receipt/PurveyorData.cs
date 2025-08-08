using System;
using System.Text.Json.Serialization;

namespace Spoleto.PaymentCallback.CloudKassir.Models
{
    /// <summary>
    /// Данные поставщика платежного агента, Тег ОФД 1224
    /// </summary>
    public class PurveyorData
    {

        /// <summary>
        /// ИНН поставщика, тег ОФД 1226
        /// </summary>
        [JsonPropertyName("Inn")]
        public string Inn { get; set; }
        /// <summary>
        /// Наименование поставщика, тег ОФД 1225
        /// </summary>
        [JsonPropertyName("Name")]
        public string Name { get; set; }

        /// <summary>
        /// Телефон поставщика, тег ОФД 1171
        /// </summary>
        [JsonPropertyName("Phone")]
        public string Phone { get; set; }
    }
}
