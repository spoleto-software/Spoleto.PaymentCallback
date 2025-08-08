using System;

namespace Spoleto.PaymentCallback.CloudKassir.Models
{
    /// <summary>
    /// Признак агента
    /// </summary>
    public enum AgentSign
    {
        /// <summary>
        /// Банковский платежный агент
        /// </summary>
        BankPaymentAgent = 0,

        /// <summary>
        /// Банковский платежный субагент
        /// </summary>
        BankPaymentSubagent = 1,

        /// <summary>
        /// Платежный агент
        /// </summary>
        PaymentAgent = 2,

        /// <summary>
        /// Платежный субагент
        /// </summary>
        PaymentSubagent = 3,

        /// <summary>
        /// Поверенный
        /// </summary>
        Attorney = 4,

        /// <summary>
        /// Комиссионер
        /// </summary>
        Commissioner = 5,

        /// <summary>
        /// Агент
        /// </summary>
        Agent = 6
    }
}
