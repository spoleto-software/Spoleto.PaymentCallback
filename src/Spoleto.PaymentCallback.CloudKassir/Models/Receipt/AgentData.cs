using System;
using System.Text.Json.Serialization;

namespace Spoleto.PaymentCallback.CloudKassir.Models
{
    /// <summary>
    /// Данные агента, Тег ОФД 1223
    /// </summary>
    public class AgentData
    {
        /// <summary>
        /// Наименование операции банковского платежного агента или субагента, тег ОФД 1044
        /// </summary>
        [JsonPropertyName("AgentOperationName")]
        public string AgentOperationName { get; set; }

        /// <summary>
        /// Телефон платежного агента, тег ОФД 1073
        /// </summary>
        [JsonPropertyName("PaymentAgentPhone")]
        public string PaymentAgentPhone { get; set; }

        /// <summary>
        /// Телефон оператора по приему платежей, тег ОФД 1074
        /// </summary>
        [JsonPropertyName("PaymentReceiverOperatorPhone")]
        public string PaymentReceiverOperatorPhone { get; set; }

        /// <summary>
        /// Адрес оператора перевода, тег ОФД 1005
        /// </summary>
        [JsonPropertyName("TransferOperatorAddress")]
        public string TransferOperatorAddress { get; set; }

        /// <summary>
        /// ИНН оператора перевода, тег ОФД 1016
        /// </summary>
        [JsonPropertyName("TransferOperatorInn")]
        public string TransferOperatorInn { get; set; }

        /// <summary>
        /// Наименование оператора перевода, тег ОФД 1026
        /// </summary>
        [JsonPropertyName("TransferOperatorName")]
        public string TransferOperatorName { get; set; }

        /// <summary>
        /// Телефон оператора перевода, тег ОФД 1075
        /// </summary>
        [JsonPropertyName("TransferOperatorPhone")]
        public string TransferOperatorPhone { get; set; }
    }
}
