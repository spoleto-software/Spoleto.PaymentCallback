using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Spoleto.PaymentCallback.CloudKassir.Models
{
    /// <summary>
    /// Запрос на фискализацию кассы
    /// </summary>
    public class FiscalizeRequest
    {
        /// <summary>
        /// ИНН организации или индивидуального предпринимателя - пользователя кассы
        /// </summary>
        [JsonPropertyName("Inn")]
        public string Inn { get; set; }

        /// <summary>
        /// Заводской номер кассы
        /// </summary>
        [JsonPropertyName("DeviceNumber")]
        public string DeviceNumber { get; set; }

        /// <summary>
        /// Номер фискального накопителя
        /// </summary>
        [JsonPropertyName("FiscalNumber")]
        public string FiscalNumber { get; set; }

        /// <summary>
        /// Регистрационный номер кассы
        /// </summary>
        [JsonPropertyName("RegNumber")]
        public string RegNumber { get; set; }

        /// <summary>
        /// Адрес сайта (сайтов) - место расчетов
        /// </summary>
        [JsonPropertyName("Url")]
        public string Url { get; set; }

        /// <summary>
        /// Оператор фискальных данных
        /// </summary>
        [JsonPropertyName("Ofd")]
        public string Ofd { get; set; }

        /// <summary>
        /// Одно или несколько значений системы налогообложения
        /// </summary>
        [JsonPropertyName("TaxationSystem")]
        public List<int> TaxationSystem { get; set; }

        /// <summary>
        /// Email магазина
        /// </summary>
        [JsonPropertyName("MerchantEmail")]
        public string MerchantEmail { get; set; }

        /// <summary>
        /// Телефон магазина
        /// </summary>
        [JsonPropertyName("MerchantPhone")]
        public string MerchantPhone { get; set; }

        /// <summary>
        /// Для бланков строгой отчётности (БСО)
        /// </summary>
        [JsonPropertyName("IsBso")]
        public bool? IsBso { get; set; }
    }
}
