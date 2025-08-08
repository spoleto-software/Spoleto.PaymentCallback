using System;
using System.Text.Json.Serialization;

namespace Spoleto.PaymentCallback.CloudKassir.Models
{
    /// <summary>
    /// Детализация сумм
    /// </summary>
    public class AmountsDetail : Amounts
    {
        /// <summary>
        /// Общая сумма
        /// </summary>
        [JsonPropertyName("Sum")]
        public decimal Sum { get; set; }
    }
}
