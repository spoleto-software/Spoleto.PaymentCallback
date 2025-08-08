using System;

namespace Spoleto.PaymentCallback.CloudKassir.Models
{
    /// <summary>
    /// Признак способа расчета
    /// </summary>
    public enum PaymentMethod
    {
        /// <summary>
        /// Предоплата 100%
        /// </summary>
        FullPrepayment = 1,

        /// <summary>
        /// Предоплата
        /// </summary>
        PartialPrepayment = 2,

        /// <summary>
        /// Аванс
        /// </summary>
        AdvancePay = 3,

        /// <summary>
        /// Полный расчёт
        /// </summary>
        FullPay = 4,

        /// <summary>
        /// Частичный расчёт и кредит
        /// </summary>
        PartialPayAndCredit = 5,

        /// <summary>
        /// Передача в кредит
        /// </summary>
        Credit = 6,

        /// <summary>
        /// Оплата кредита
        /// </summary>
        CreditPayment = 7
    }
}
