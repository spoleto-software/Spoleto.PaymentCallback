using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Spoleto.PaymentCallback.CloudKassir.Models
{
    /// <summary>
    /// Товарная позиция в чеке
    /// </summary>
    public class ReceiptItem
    {

        /// <summary>
        /// Дополнительная информация внутри конкретной позиции чека
        /// </summary>
        [JsonPropertyName("AdditionalPositionInfo")]
        public string AdditionalPositionInfo { get; set; }

        /// <summary>
        /// Данные агента, тег ОФД 1223
        /// </summary>
        [JsonPropertyName("AgentData")]
        public AgentData AgentData { get; set; }

        /// <summary>
        /// Признак агента, тег ОФД 1222
        /// </summary>
        [JsonPropertyName("AgentSign")]
        public int? AgentSign { get; set; }

        /// <summary>
        /// Price * Quantity с учетом скидки
        /// </summary>
        [JsonPropertyName("Amount")]
        public decimal Amount { get; set; }

        /// <summary>
        /// Код страны происхождения товара (3 символа), тег ОФД 1230
        /// </summary>
        [JsonPropertyName("CountryOriginCode")]
        public string CountryOriginCode { get; set; }

        /// <summary>
        /// Регистрационный номер таможенной декларации (32 символа), тег ОФД 1231
        /// </summary>
        [JsonPropertyName("CustomsDeclarationNumber")]
        public string CustomsDeclarationNumber { get; set; }

        /// <summary>
        /// Сумма акциза
        /// </summary>
        [JsonPropertyName("Excise")]
        public decimal? Excise { get; set; }

        /// <summary>
        /// Разделитель GS
        /// </summary>
        [JsonPropertyName("GroupSeparator")]
        public string GroupSeparator { get; set; }

        /// <summary>
        /// Отраслевой реквизит предмета расчета, тег ОФД 1260
        /// </summary>
        [JsonPropertyName("IndustryRequisiteCollection")]
        public List<IndustryRequisite> IndustryRequisiteCollection { get; set; }
        /// <summary>
        /// Наименование товара или услуги
        /// </summary>
        [JsonPropertyName("Label")]
        public string Label { get; set; }

        /// <summary>
        /// Дробное количество маркированного товара, тег ОФД 1291
        /// </summary>
        [JsonPropertyName("MarkPartQuantity")]
        public MarkPartQuantity MarkPartQuantity { get; set; }

        /// <summary>
        /// Единица измерения
        /// </summary>
        [JsonPropertyName("MeasurementUnit")]
        public string MeasurementUnit { get; set; }

        /// <summary>
        /// Способ расчёта
        /// </summary>
        [JsonPropertyName("Method")]
        public int? Method { get; set; }

        /// <summary>
        /// Предмет расчёта
        /// </summary>
        [JsonPropertyName("Object")]
        public int? Object { get; set; }

        /// <summary>
        /// Цена за единицу товара/услуги
        /// </summary>
        [JsonPropertyName("Price")]
        public decimal Price { get; set; }

        /// <summary>
        /// Данные маркировки товара, тег ОФД 1162
        /// </summary>
        [JsonPropertyName("ProductCodeData")]
        public ProductCodeData ProductCodeData { get; set; }

        /// <summary>
        /// Данные поставщика платежного агента, тег ОФД 1224
        /// </summary>
        [JsonPropertyName("PurveyorData")]
        public PurveyorData PurveyorData { get; set; }

        /// <summary>
        /// Количество
        /// </summary>
        [JsonPropertyName("Quantity")]
        public decimal Quantity { get; set; }

        /// <summary>
        /// Код маркировки, тег ОФД 2000
        /// </summary>
        [JsonPropertyName("RawMarkCode")]
        public string RawMarkCode { get; set; }

        /// <summary>
        /// Дополнительный реквизит предмета расчета, тег ОФД 1191
        /// </summary>
        [JsonPropertyName("SaleObjectData")]
        public string SaleObjectData { get; set; }

        /// <summary>
        /// Мера количества предмета расчета, тег ОФД 2108
        /// </summary>
        [JsonPropertyName("UnitCode")]
        public int? UnitCode { get; set; }

        /// <summary>
        /// Ставка НДС услуги/товара
        /// </summary>
        [JsonPropertyName("Vat")]
        public decimal? Vat { get; set; }
    }
}
