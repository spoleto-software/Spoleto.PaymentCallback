using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Spoleto.PaymentCallback.CloudKassir.Models
{
    /// <summary>
    /// Данные чека коррекции
    /// </summary>
    public class CorrectionReceiptData
    {

        /// <summary>
        /// Дополнительный реквизит чека
        /// </summary>
        [JsonPropertyName("AdditionalReceiptRequisite")]
        public string AdditionalReceiptRequisite { get; set; }

        /// <summary>
        /// Общая сумма платежа или возврата
        /// </summary>
        [JsonPropertyName("Amounts")]
        public Amounts Amounts { get; set; }

        /// <summary>
        /// ИНН кассира
        /// </summary>
        [JsonPropertyName("CashierInn")]
        public string CashierInn { get; set; }

        /// <summary>
        /// Имя кассира
        /// </summary>
        [JsonPropertyName("CashierName")]
        public string CashierName { get; set; }

        /// <summary>
        /// Основание для коррекции
        /// </summary>
        [JsonPropertyName("CauseCorrection")]
        public CauseCorrection CauseCorrection { get; set; }

        /// <summary>
        /// Признак расчета коррекции
        /// </summary>
        [JsonPropertyName("CorrectionReceiptType")]
        public int CorrectionReceiptType { get; set; }

        /// <summary>
        /// Тип коррекции
        /// </summary>
        [JsonPropertyName("CorrectionType")]
        public int? CorrectionType { get; set; }

        /// <summary>
        /// Дата рождения покупателя
        /// </summary>
        [JsonPropertyName("CustomerBirthday")]
        public string CustomerBirthday { get; set; }

        /// <summary>
        /// Email или телефон покупателя
        /// </summary>
        [JsonPropertyName("CustomerContactAddress")]
        public string CustomerContactAddress { get; set; }

        /// <summary>
        /// Данные документа
        /// </summary>
        [JsonPropertyName("CustomerDoc")]
        public string CustomerDoc { get; set; }

        /// <summary>
        /// Код вида документа
        /// </summary>
        [JsonPropertyName("CustomerDocType")]
        public string CustomerDocType { get; set; }

        /// <summary>
        /// Покупатель
        /// </summary>
        [JsonPropertyName("CustomerInfo")]
        public string CustomerInfo { get; set; }

        /// <summary>
        /// ИНН покупателя
        /// </summary>
        [JsonPropertyName("CustomerInn")]
        public string CustomerInn { get; set; }

        /// <summary>
        /// Адрес покупателя
        /// </summary>
        [JsonPropertyName("CustomerPlace")]
        public string CustomerPlace { get; set; }

        /// <summary>
        /// Гражданство
        /// </summary>
        [JsonPropertyName("CustomerStateCode")]
        public string CustomerStateCode { get; set; }

        /// <summary>
        /// Отраслевой реквизит чека
        /// </summary>
        [JsonPropertyName("IndustryRequisites")]
        public List<IndustryRequisite> IndustryRequisites { get; set; }

        /// <summary>
        /// БСО
        /// </summary>
        [JsonPropertyName("IsBso")]
        public bool? IsBso { get; set; }

        /// <summary>
        /// Содержимое позиций чека
        /// </summary>
        [JsonPropertyName("Items")]
        public List<ReceiptItem> Items { get; set; }

        /// <summary>
        /// Операционный реквизит чека
        /// </summary>
        [JsonPropertyName("OperationReceiptRequisite")]
        public OperationReceiptRequisite OperationReceiptRequisite { get; set; }
        /// <summary>
        /// ИНН организации
        /// </summary>
        [JsonPropertyName("OrganizationInn")]
        public string OrganizationInn { get; set; }

        /// <summary>
        /// Адрес использования ККТ
        /// </summary>
        [JsonPropertyName("PaymentAddress")]
        public string PaymentAddress { get; set; }

        /// <summary>
        /// Место использования ККТ (сайт)
        /// </summary>
        [JsonPropertyName("PaymentPlace")]
        public string PaymentPlace { get; set; }

        /// <summary>
        /// Система налогообложения
        /// </summary>
        [JsonPropertyName("TaxationSystem")]
        public string TaxationSystem { get; set; }

        /// <summary>
        /// Дополнительный реквизит пользователя
        /// </summary>
        [JsonPropertyName("UserRequisiteData")]
        public UserRequisiteData UserRequisiteData { get; set; }

        /// <summary>
        /// Ставка НДС
        /// </summary>
        [JsonPropertyName("VatRate")]
        public int? VatRate { get; set; }
    }
}
