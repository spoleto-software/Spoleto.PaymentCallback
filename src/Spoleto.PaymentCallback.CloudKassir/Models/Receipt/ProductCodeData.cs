using System;
using System.Text.Json.Serialization;

namespace Spoleto.PaymentCallback.CloudKassir.Models
{
    /// <summary>
    /// Данные маркировки товара
    /// </summary>
    public class ProductCodeData
    {
        /// <summary>
        /// HEX представление штрих/бар кода маркировки целиком
        /// </summary>
        [JsonPropertyName("CodeProductNomenclature")]
        public string CodeProductNomenclature { get; set; }
    }
}
