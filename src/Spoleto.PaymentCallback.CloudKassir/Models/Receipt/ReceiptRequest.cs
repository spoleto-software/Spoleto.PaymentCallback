using System;
using System.Text.Json.Serialization;

namespace Spoleto.PaymentCallback.CloudKassir.Models
{
    /// <summary>
    /// Запрос на формирование кассового чека
    /// </summary>
    public class ReceiptRequest
    {
        /// <summary>
        /// ИНН вашей организации или ИП, на который зарегистрирована касса
        /// </summary>
        [JsonPropertyName("Inn")]
        public string Inn { get; set; }

        /// <summary>
        /// Признак расчета
        /// </summary>
        [JsonPropertyName("Type")]
        public string Type { get; set; }

        /// <summary>
        /// Состав чека
        /// </summary>
        [JsonPropertyName("CustomerReceipt")]
        public CustomerReceipt CustomerReceipt { get; set; }

        /// <summary>
        /// Номер заказа в вашей системе
        /// </summary>
        [JsonPropertyName("InvoiceId")]
        public string InvoiceId { get; set; }

        /// <summary>
        /// Идентификатор пользователя в вашей системе
        /// </summary>
        [JsonPropertyName("AccountId")]
        public string AccountId { get; set; }
    }
}
