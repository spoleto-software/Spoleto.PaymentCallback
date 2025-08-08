using System;

namespace Spoleto.PaymentCallback.CloudKassir.Models
{
    /// <summary>
    /// Признак расчета коррекции
    /// </summary>
    public enum CorrectionReceiptType
    {
        /// <summary>
        /// Корректировка прихода
        /// </summary>
        IncomeCorrection = 1,

        /// <summary>
        /// Возврат прихода
        /// </summary>
        IncomeReturn = 2,

        /// <summary>
        /// Корректировка расхода
        /// </summary>
        ExpenseCorrection = 3,

        /// <summary>
        /// Возврат расхода
        /// </summary>
        ExpenseReturn = 4
    }
}
