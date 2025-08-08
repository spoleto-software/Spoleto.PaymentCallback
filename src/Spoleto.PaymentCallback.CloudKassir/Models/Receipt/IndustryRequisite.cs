using System;
using System.Text.Json.Serialization;

namespace Spoleto.PaymentCallback.CloudKassir.Models
{
    /// <summary>
    /// Отраслевой реквизит
    /// </summary>
    public class IndustryRequisite
    {
        /// <summary>
        /// Идентификатор ФОИВ, тег ОФД 1262
        /// </summary>
        [JsonPropertyName("Code")]
        public string Code { get; set; }

        /// <summary>
        /// Дата документа основания, тег ОФД 1263
        /// </summary>
        [JsonPropertyName("DocumentDate")]
        public DateTime DocumentDate { get; set; }

        /// <summary>
        /// Номер документа основания, тег ОФД 1264
        /// </summary>
        [JsonPropertyName("DocumentNumber")]
        public string DocumentNumber { get; set; }

        /// <summary>
        /// Значение отраслевого реквизита, тег ОФД 1265
        /// </summary>
        [JsonPropertyName("RequisiteValue")]
        public string RequisiteValue { get; set; }
    }
}
