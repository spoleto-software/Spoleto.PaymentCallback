using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Spoleto.PaymentCallback.CloudKassir.Models
{
    /// <summary>
    /// Ответ статуса чека с предупреждениями
    /// </summary>
    public class ReceiptStatusResponse : BaseResponse<string>
    {
        /// <summary>
        /// Предупреждения
        /// </summary>
        [JsonPropertyName("Warnings")]
        public List<WarningInfo> Warnings { get; set; }
    }
}
