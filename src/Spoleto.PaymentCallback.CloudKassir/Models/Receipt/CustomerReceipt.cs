using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Spoleto.PaymentCallback.CloudKassir.Models
{
    /// <summary>
    /// Состав чека
    /// </summary>
    public class CustomerReceipt
    {

        /// <summary>
        /// Дополнительная информация общая для чека
        /// </summary>
        [JsonPropertyName("AdditionalReceiptInfos")]
        public List<string> AdditionalReceiptInfos { get; set; }

        /// <summary>
        /// Дополнительный реквизит чека (тег 1192)
        /// </summary>
        [JsonPropertyName("AdditionalReceiptRequisite")]
        public string AdditionalReceiptRequisite { get; set; }

        /// <summary>
        /// Признак агента
        /// </summary>
        [JsonPropertyName("AgentSign")]
        public int? AgentSign { get; set; }

        /// <summary>
        /// Общая сумма платежа или возврата
        /// </summary>
        [JsonPropertyName("Amounts")]
        public Amounts Amounts { get; set; }

        /// <summary>
        /// Место осуществления расчёта
        /// </summary>
        [JsonPropertyName("CalculationPlace")]
        public string CalculationPlace { get; set; }

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
        /// Дата рождения покупателя (клиента), тег ОФД 1243
        /// </summary>
        [JsonPropertyName("CustomerBirthday")]
        public string CustomerBirthday { get; set; }

        /// <summary>
        /// Данные документа, удостоверяющего личность, тег ОФД 1246
        /// </summary>
        [JsonPropertyName("CustomerDoc")]
        public string CustomerDoc { get; set; }

        /// <summary>
        /// Код вида документа, удостоверяющего личность, тег ОФД 1245
        /// </summary>
        [JsonPropertyName("CustomerDocType")]
        public string CustomerDocType { get; set; }

        /// <summary>
        /// Покупатель, наименование организации или ФИО
        /// </summary>
        [JsonPropertyName("CustomerInfo")]
        public string CustomerInfo { get; set; }

        /// <summary>
        /// ИНН покупателя
        /// </summary>
        [JsonPropertyName("CustomerInn")]
        public string CustomerInn { get; set; }

        /// <summary>
        /// Адрес покупателя (клиента), тег ОФД 1254
        /// </summary>
        [JsonPropertyName("CustomerPlace")]
        public string CustomerPlace { get; set; }

        /// <summary>
        /// Гражданство, тег ОФД 1244
        /// </summary>
        [JsonPropertyName("CustomerStateCode")]
        public string CustomerStateCode { get; set; }

        /// <summary>
        /// E-mail покупателя для отправки чека
        /// </summary>
        [JsonPropertyName("Email")]
        public string Email { get; set; }

        /// <summary>
        /// Отраслевой реквизит чека, тег ОФД 1261
        /// </summary>
        [JsonPropertyName("IndustryRequisiteCollection")]
        public List<IndustryRequisite> IndustryRequisiteCollection { get; set; }

        /// <summary>
        /// true, если чек является бланком строгой отчётности
        /// </summary>
        [JsonPropertyName("IsBso")]
        public bool? IsBso { get; set; }
        /// <summary>
        /// Содержимое позиций чека
        /// </summary>
        [JsonPropertyName("Items")]
        public List<ReceiptItem> Items { get; set; }

        /// <summary>
        /// Операционный реквизит чека, тег ОФД 1270
        /// </summary>
        [JsonPropertyName("OperationReceiptRequisite")]
        public OperationReceiptRequisite OperationReceiptRequisite { get; set; }

        /// <summary>
        /// Телефон покупателя для отправки ссылки на чек
        /// </summary>
        [JsonPropertyName("Phone")]
        public string Phone { get; set; }

        /// <summary>
        /// Система налогообложения
        /// </summary>
        [JsonPropertyName("TaxationSystem")]
        public int? TaxationSystem { get; set; }

        /// <summary>
        /// Дополнительный реквизит пользователя, тег ОФД 1084
        /// </summary>
        [JsonPropertyName("UserRequisiteData")]
        public UserRequisiteData UserRequisiteData { get; set; }
    }
}
