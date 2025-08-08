using System;
using System.Text.Json.Serialization;

namespace Spoleto.PaymentCallback.CloudKassir.Models
{
    /// <summary>
    /// Операционный реквизит чека
    /// </summary>
    public class OperationReceiptRequisite
    {

        /// <summary>
        /// Данные операции, тег ОФД 1272
        /// </summary>
        [JsonPropertyName("OperationData")]
        public string OperationData { get; set; }

        /// <summary>
        /// Дата, время операции, тег ОФД 1273
        /// </summary>
        [JsonPropertyName("OperationDate")]
        public DateTime OperationDate { get; set; }
        /// <summary>
        /// Идентификатор операции, тег ОФД 1271
        /// </summary>
        [JsonPropertyName("OperationIdentifier")]
        public int OperationIdentifier { get; set; }
    }
}
