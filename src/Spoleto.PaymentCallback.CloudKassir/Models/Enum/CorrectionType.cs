using System;

namespace Spoleto.PaymentCallback.CloudKassir.Models
{
    /// <summary>
    /// Тип коррекции
    /// </summary>
    public enum CorrectionType
    {
        /// <summary>
        /// Самостоятельно
        /// </summary>
        Self = 0,

        /// <summary>
        /// По предписанию
        /// </summary>
        ByPrescription = 1
    }
}
