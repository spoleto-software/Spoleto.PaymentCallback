using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Spoleto.PaymentCallback.CloudKassir.Models
{
    /// <summary>
    /// Данные кассы
    /// </summary>
    public class KktStateData
    {

        /// <summary>
        /// Место осуществления расчёта
        /// </summary>
        [JsonPropertyName("CalculationPlace")]
        public string CalculationPlace { get; set; }

        /// <summary>
        /// Заводской номер кассы
        /// </summary>
        [JsonPropertyName("DeviceNumber")]
        public string DeviceNumber { get; set; }

        /// <summary>
        /// Версия прошивки кассы
        /// </summary>
        [JsonPropertyName("FirmwareVersion")]
        public string FirmwareVersion { get; set; }

        /// <summary>
        /// ККМ фискализирована
        /// </summary>
        [JsonPropertyName("Fiscal")]
        public bool Fiscal { get; set; }

        /// <summary>
        /// Дата окончания фискального накопителя
        /// </summary>
        [JsonPropertyName("FiscalDateEnd")]
        public DateTime FiscalDateEnd { get; set; }

        /// <summary>
        /// Номер ФН
        /// </summary>
        [JsonPropertyName("FiscalNumber")]
        public string FiscalNumber { get; set; }

        /// <summary>
        /// Заполненность ФН, где 1 - ФН заполнен
        /// </summary>
        [JsonPropertyName("FnOccupancy")]
        public decimal FnOccupancy { get; set; }
        /// <summary>
        /// ИНН
        /// </summary>
        [JsonPropertyName("Inn")]
        public string Inn { get; set; }

        /// <summary>
        /// Для бланков строгой отчётности
        /// </summary>
        [JsonPropertyName("IsBso")]
        public bool IsBso { get; set; }

        /// <summary>
        /// ККТ не может бить чеки
        /// </summary>
        [JsonPropertyName("IsReceiptProcessingBlocked")]
        public bool IsReceiptProcessingBlocked { get; set; }

        /// <summary>
        /// Название модели кассового аппарата
        /// </summary>
        [JsonPropertyName("KkmModelName")]
        public string KkmModelName { get; set; }

        /// <summary>
        /// ОФД
        /// </summary>
        [JsonPropertyName("OfdName")]
        public string OfdName { get; set; }

        /// <summary>
        /// Количество документов не отправленных в ОФД
        /// </summary>
        [JsonPropertyName("OfdQueueDocsCount")]
        public int OfdQueueDocsCount { get; set; }

        /// <summary>
        /// Регистрационный номер ККМ
        /// </summary>
        [JsonPropertyName("RegNumber")]
        public string RegNumber { get; set; }

        /// <summary>
        /// Место нахождения (установки) ккм
        /// </summary>
        [JsonPropertyName("SettlePlace")]
        public string SettlePlace { get; set; }

        /// <summary>
        /// Статус (1-онлайн, 2-оффлайн, 3-ошибка)
        /// </summary>
        [JsonPropertyName("Status")]
        public int Status { get; set; }

        /// <summary>
        /// Массив с предупреждениями по кассам
        /// </summary>
        [JsonPropertyName("Warnings")]
        public List<WarningInfo> Warnings { get; set; }
    }
}
