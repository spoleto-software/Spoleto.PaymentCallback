using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Spoleto.PaymentCallback.CloudKassir.Models
{
    /// <summary>
    /// Детализация чека коррекции
    /// </summary>
    public class CorrectionReceiptDetails
    {

        /// <summary>
        /// Сумма
        /// </summary>
        [JsonPropertyName("Amount")]
        public decimal Amount { get; set; }

        /// <summary>
        /// Суммы
        /// </summary>
        [JsonPropertyName("Amounts")]
        public AmountsDetail Amounts { get; set; }

        /// <summary>
        /// Имя кассира
        /// </summary>
        [JsonPropertyName("CashierName")]
        public string CashierName { get; set; }

        /// <summary>
        /// Дата коррекции
        /// </summary>
        [JsonPropertyName("CorrectionDate")]
        public DateTime CorrectionDate { get; set; }

        /// <summary>
        /// Номер коррекции
        /// </summary>
        [JsonPropertyName("CorrectionNumber")]
        public string CorrectionNumber { get; set; }

        /// <summary>
        /// Признак расчета коррекции
        /// </summary>
        [JsonPropertyName("CorrectionReceiptType")]
        public int CorrectionReceiptType { get; set; }

        /// <summary>
        /// Тип коррекции
        /// </summary>
        [JsonPropertyName("CorrectionType")]
        public int CorrectionType { get; set; }

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
        /// Код ошибки
        /// </summary>
        [JsonPropertyName("ErrorCode")]
        public int? ErrorCode { get; set; }

        /// <summary>
        /// Сообщение об ошибке
        /// </summary>
        [JsonPropertyName("ErrorMessage")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Номер ФН
        /// </summary>
        [JsonPropertyName("FiscalNumber")]
        public string FiscalNumber { get; set; }

        /// <summary>
        /// Фискальный признак
        /// </summary>
        [JsonPropertyName("FiscalSign")]
        public string FiscalSign { get; set; }

        /// <summary>
        /// Идентификатор
        /// </summary>
        [JsonPropertyName("Id")]
        public string Id { get; set; }

        /// <summary>
        /// Позиции
        /// </summary>
        [JsonPropertyName("Items")]
        public List<ReceiptItem> Items { get; set; }

        /// <summary>
        /// ИНН ОФД
        /// </summary>
        [JsonPropertyName("OfdInn")]
        public string OfdInn { get; set; }

        /// <summary>
        /// Наименование ОФД
        /// </summary>
        [JsonPropertyName("OfdName")]
        public string OfdName { get; set; }

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
        /// Адрес платежа
        /// </summary>
        [JsonPropertyName("PaymentAddress")]
        public string PaymentAddress { get; set; }

        /// <summary>
        /// Место платежа
        /// </summary>
        [JsonPropertyName("PaymentPlace")]
        public string PaymentPlace { get; set; }

        /// <summary>
        /// Регистрационный номер
        /// </summary>
        [JsonPropertyName("RegNumber")]
        public string RegNumber { get; set; }

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
        /// Статус
        /// </summary>
        [JsonPropertyName("Status")]
        public string Status { get; set; }

        /// <summary>
        /// Система налогообложения
        /// </summary>
        [JsonPropertyName("TaxationSystem")]
        public int TaxationSystem { get; set; }

        /// <summary>
        /// Ставка НДС
        /// </summary>
        [JsonPropertyName("VatRate")]
        public int VatRate { get; set; }
    }
}
