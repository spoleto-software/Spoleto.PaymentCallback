namespace Spoleto.PaymentCallback.AtolOnline.Models
{
    /// <summary>
    /// Статусы ответа сервиса.
    /// </summary>
    public enum StatusType
    {
        /// <summary>
        /// готово
        /// </summary>
        done,

        /// <summary>
        /// ошибка
        /// </summary>
        fail,

        /// <summary>
        /// ожидание
        /// </summary>
        wait
    }
}
