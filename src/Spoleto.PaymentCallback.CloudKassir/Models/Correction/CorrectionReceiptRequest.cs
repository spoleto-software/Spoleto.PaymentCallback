using System;
using System.Text.Json.Serialization;

namespace Spoleto.PaymentCallback.CloudKassir.Models
{
    /// <summary>
    /// Запрос на формирование чека коррекции
    /// </summary>
    public class CorrectionReceiptRequest
    {
        /// <summary>
        /// Состав чека коррекции
        /// </summary>
        [JsonPropertyName("CorrectionReceiptData")]
        public CorrectionReceiptData CorrectionReceiptData { get; set; }
    }
}
