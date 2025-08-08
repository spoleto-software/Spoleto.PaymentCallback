using System;

namespace Spoleto.PaymentCallback.CloudKassir.Models
{
    /// <summary>
    /// Тип чека / Признак расчета
    /// </summary>
    public enum ReceiptType
    {
        /// <summary>
        /// Приход - Выдается при получении средств от покупателя
        /// </summary>
        Income,

        /// <summary>
        /// Возврат прихода - Выдается при возврате покупателю средств
        /// </summary>
        IncomeReturn,

        /// <summary>
        /// Расход - Выдается при выдаче средств покупателю
        /// </summary>
        Expense,

        /// <summary>
        /// Возврат расхода - Выдается при получении средств от покупателя, выданных ему
        /// </summary>
        ExpenseReturn
    }
}
