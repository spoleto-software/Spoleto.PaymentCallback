using System;
using System.Text.Json.Serialization;

namespace Spoleto.PaymentCallback.CloudKassir.Models
{
    /// <summary>
    /// Основание для коррекции
    /// </summary>
    public class CauseCorrection
    {
        /// <summary>
        /// Дата документа основания для коррекции
        /// </summary>
        [JsonPropertyName("CorrectionDate")]
        public string CorrectionDate { get; set; }

        /// <summary>
        /// Номер документа основания для коррекции
        /// </summary>
        [JsonPropertyName("CorrectionNumber")]
        public string CorrectionNumber { get; set; }
    }
}
