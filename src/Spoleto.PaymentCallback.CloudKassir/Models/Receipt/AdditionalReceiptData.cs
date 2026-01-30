using System;
using System.Text.Json.Serialization;

namespace Spoleto.PaymentCallback.CloudKassir.Models
{
    /// <summary>
    /// Дополнительные данные чека
    /// </summary>
    public class AdditionalReceiptData
    {

        /// <summary>
        /// Идентификатор пользователя
        /// </summary>
        [JsonPropertyName("AccountId")]
        public string AccountId { get; set; }

        /// <summary>
        /// Сумма
        /// </summary>
        [JsonPropertyName("Amount")]
        public decimal Amount { get; set; }

        /// <summary>
        /// Место осуществления расчетов
        /// </summary>
        [JsonPropertyName("CalculationPlace")]
        public string CalculationPlace { get; set; }

        /// <summary>
        /// Имя кассира
        /// </summary>
        [JsonPropertyName("CashierName")]
        public string CashierName { get; set; }

        /// <summary>
        /// Дата/время чека в виде строки
        /// </summary>
        [JsonPropertyName("DateTime")]
        public string DateTime { get; set; }

        /// <summary>
        /// Заводской номер кассы
        /// </summary>
        [JsonPropertyName("DeviceNumber")]
        public string DeviceNumber { get; set; }

        /// <summary>
        /// Номер документа
        /// </summary>
        [JsonPropertyName("DocumentNumber")]
        public string DocumentNumber { get; set; }

        /// <summary>
        /// Номер фискального накопителя
        /// </summary>
        [JsonPropertyName("FiscalNumber")]
        public string FiscalNumber { get; set; }

        /// <summary>
        /// Фискальный признак
        /// </summary>
        [JsonPropertyName("FiscalSign")]
        public string FiscalSign { get; set; }
        /// <summary>
        /// Идентификатор чека
        /// </summary>
        [JsonPropertyName("Id")]
        public string Id { get; set; }

        /// <summary>
        /// Номер заказа
        /// </summary>
        [JsonPropertyName("InvoiceId")]
        public string InvoiceId { get; set; }

        /// <summary>
        /// ОФД
        /// </summary>
        [JsonPropertyName("Ofd")]
        public string Ofd { get; set; }

        /// <summary>
        /// URL чека в ОФД
        /// </summary>
        [JsonPropertyName("OfdReceiptUrl")]
        public string OfdReceiptUrl { get; set; }

        /// <summary>
        /// ИНН организации
        /// </summary>
        [JsonPropertyName("OrganizationInn")]
        public string OrganizationInn { get; set; }

        /// <summary>
        /// URL QR-кода
        /// </summary>
        [JsonPropertyName("QrCodeUrl")]
        public string QrCodeUrl { get; set; }

        /// <summary>
        /// Регистрационный номер кассы
        /// </summary>
        [JsonPropertyName("RegNumber")]
        public string RegNumber { get; set; }

        /// <summary>
        /// Email отправителя
        /// </summary>
        [JsonPropertyName("SenderEmail")]
        public string SenderEmail { get; set; }

        /// <summary>
        /// Номер чека в смене
        /// </summary>
        [JsonPropertyName("SessionCheckNumber")]
        public string SessionCheckNumber { get; set; }

        /// <summary>
        /// Номер смены
        /// </summary>
        [JsonPropertyName("SessionNumber")]
        public string SessionNumber { get; set; }

        /// <summary>
        /// Место нахождения кассы
        /// </summary>
        [JsonPropertyName("SettlePlace")]
        public string SettlePlace { get; set; }

        /// <summary>
        /// Идентификатор транзакции
        /// </summary>
        [JsonPropertyName("TransactionId")]
        public long? TransactionId { get; set; }

        /// <summary>
        /// Тип чека
        /// </summary>
        [JsonPropertyName("Type")]
        public string Type { get; set; }
    }
}
