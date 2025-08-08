using System;

namespace Spoleto.PaymentCallback.CloudKassir.Models
{
    /// <summary>
    /// Статус чека
    /// </summary>
    public enum ReceiptStatus
    {
        /// <summary>
        /// В очереди
        /// </summary>
        Queued,

        /// <summary>
        /// Обработан
        /// </summary>
        Processed,

        /// <summary>
        /// Ошибка
        /// </summary>
        Error,

        /// <summary>
        /// Не найден
        /// </summary>
        NotFound
    }
}
