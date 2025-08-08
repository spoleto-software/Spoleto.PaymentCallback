using System;

namespace Spoleto.PaymentCallback.CloudKassir.Models
{
    /// <summary>
    /// Система налогообложения
    /// </summary>
    public enum TaxationSystem
    {
        /// <summary>
        /// Общая система налогообложения
        /// </summary>
        Common = 0,

        /// <summary>
        /// Упрощенная система налогообложения (Доход)
        /// </summary>
        SimplifiedIncome = 1,

        /// <summary>
        /// Упрощенная система налогообложения (Доход минус Расход)
        /// </summary>
        SimplifiedIncomeMinusExpense = 2,

        /// <summary>
        /// Единый налог на вмененный доход
        /// </summary>
        ENVD = 3,

        /// <summary>
        /// Единый сельскохозяйственный налог
        /// </summary>
        ESN = 4,

        /// <summary>
        /// Патентная система налогообложения
        /// </summary>
        Patent = 5
    }
}
