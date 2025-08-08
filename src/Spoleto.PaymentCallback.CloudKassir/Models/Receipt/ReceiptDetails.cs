using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Spoleto.PaymentCallback.CloudKassir.Models
{
    /// <summary>
    /// Детализация чека
    /// </summary>
    public class ReceiptDetails
    {

        /// <summary>
        /// Дополнительные данные чека
        /// </summary>
        [JsonPropertyName("AdditionalData")]
        public AdditionalReceiptData AdditionalData { get; set; }

        /// <summary>
        /// Суммы платежа
        /// </summary>
        [JsonPropertyName("Amounts")]
        public Amounts Amounts { get; set; }
        /// <summary>
        /// Email покупателя
        /// </summary>
        [JsonPropertyName("Email")]
        public string Email { get; set; }

        /// <summary>
        /// БСО
        /// </summary>
        [JsonPropertyName("IsBso")]
        public bool IsBso { get; set; }

        /// <summary>
        /// Товарные позиции
        /// </summary>
        [JsonPropertyName("Items")]
        public List<ReceiptItem> Items { get; set; }

        /// <summary>
        /// Телефон покупателя
        /// </summary>
        [JsonPropertyName("Phone")]
        public string Phone { get; set; }

        /// <summary>
        /// Система налогообложения
        /// </summary>
        [JsonPropertyName("TaxationSystem")]
        public int TaxationSystem { get; set; }
    }
}
