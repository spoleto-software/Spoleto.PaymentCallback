using System;

namespace Spoleto.PaymentCallback.CloudKassir.Models
{
    /// <summary>
    /// Статус кассы
    /// </summary>
    public enum KktStatus
    {
        /// <summary>
        /// Онлайн
        /// </summary>
        Online = 1,

        /// <summary>
        /// Оффлайн
        /// </summary>
        Offline = 2,

        /// <summary>
        /// Ошибка
        /// </summary>
        Error = 3
    }
}
