using System;
using System.Text.Json.Serialization;

namespace Spoleto.PaymentCallback.CloudKassir.Models
{
    /// <summary>
    /// Дробное количество маркированного товара
    /// </summary>
    public class MarkPartQuantity
    {

        /// <summary>
        /// Знаменатель, тег ОФД 1294
        /// </summary>
        [JsonPropertyName("Denominator")]
        public int Denominator { get; set; }
        /// <summary>
        /// Числитель, тег ОФД 1293
        /// </summary>
        [JsonPropertyName("Numerator")]
        public int Numerator { get; set; }
    }
}
