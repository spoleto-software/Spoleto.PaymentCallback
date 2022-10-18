using System.Text.Json.Serialization;

namespace Spoleto.PaymentCallback.AtolOnline.Models
{
    public class PayloadModel
    {
        /// <summary>
        /// Номер чека в смене.
        /// </summary>
        [JsonPropertyName("fiscal_receipt_number")]
        public int FiscalReceiptNumber { get; set; }

        /// <summary>
        /// Номер смены.
        /// </summary>
        [JsonPropertyName("shift_number")]
        public int ShiftNumber { get; set; }

        /// <summary>
        /// Дата и время документа из ФН.
        /// </summary>
        [JsonPropertyName("receipt_datetime")]
        public string ReceiptDatetime { get; set; }

        /// <summary>
        /// Итоговая сумма документа в рублях с заданным в CMS округлением:
        /// - целая часть не более 8 знаков;
        /// - дробная часть не более 2 знаков.
        /// </summary>
        /// <remarks>
        /// Сумма расчета, указанного в чеке.
        /// При регистрации в ККТ происходит расчёт фактической суммы: суммирование значений sum позиций.
        /// </remarks>
        [JsonPropertyName("total")]
        public decimal Total { get; set; }

        /// <summary>
        /// Номер ФН.
        /// </summary>
        [JsonPropertyName("fn_number")]
        public string FnNumber { get; set; }

        /// <summary>
        /// Регистрационный номер ККТ.
        /// </summary>
        [JsonPropertyName("ecr_registration_number")]
        public string EcrRegistrationNumber { get; set; }

        /// <summary>
        /// Фискальный номер документа.
        /// </summary>
        [JsonPropertyName("fiscal_document_number")]
        public int FiscalDocumentNumber { get; set; }

        /// <summary>
        /// Фискальный признак документа.
        /// </summary>
        [JsonPropertyName("fiscal_document_attribute")]
        public long FiscalDocumentAttribute { get; set; }

        /// <summary>
        /// Адрес сайта ФНС.
        /// </summary>
        [JsonPropertyName("fns_site")]
        public string FnsSite { get; set; }

        /// <summary>
        /// ИНН ОФД, через которого был зарегистрирован чек.
        /// </summary>
        [JsonPropertyName("ofd_inn")]
        public string OfdInn { get; set; }

        /// <summary>
        /// URL для просмотра чека на сайте ОФД.
        /// </summary>
        /// <remarks>
        /// Отображается только для чеков, зарегистрированных с помощью:
        /// - Платформа ОФД(ООО "Эвотор ОФД", ИНН 9715260691)
        /// - Первый ОФД (АО "ЭСК", ИНН 7709364346)
        /// </remarks>
        [JsonPropertyName("ofd_receipt_url")]
        public string OfdReceiptUrl { get; set; }
    }
}
