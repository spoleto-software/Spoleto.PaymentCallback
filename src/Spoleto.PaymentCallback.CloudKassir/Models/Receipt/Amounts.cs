using System;
using System.Text.Json.Serialization;

namespace Spoleto.PaymentCallback.CloudKassir.Models
{
    /// <summary>
    /// Общая сумма платежа или возврата
    /// </summary>
    public class Amounts
    {

        /// <summary>
        /// Сумма предоплаты
        /// </summary>
        [JsonPropertyName("AdvancePayment")]
        public decimal? AdvancePayment { get; set; }

        /// <summary>
        /// Сумма оплаты наличными
        /// </summary>
        [JsonPropertyName("Cash")]
        public decimal? Cash { get; set; }

        /// <summary>
        /// Сумма постоплатой
        /// </summary>
        [JsonPropertyName("Credit")]
        public decimal? Credit { get; set; }
        /// <summary>
        /// Сумма оплаты электронными деньгами
        /// </summary>
        [JsonPropertyName("Electronic")]
        public decimal? Electronic { get; set; }

        /// <summary>
        /// Сумма встречным предоставлением
        /// </summary>
        [JsonPropertyName("Provision")]
        public decimal? Provision { get; set; }
    }
}
