namespace Spoleto.PaymentCallback.AtolOnline.Models
{
    public enum ErrorType
    {
        /// <summary>
        /// системная ошибка
        /// </summary>
        system,

        /// <summary>
        /// ошибка при работе с ККТ
        /// </summary>
        driver,

        /// <summary>
        /// превышено время ожидания.
        /// Время ожидания задается в системе. На данный момент установлено 300 сек;
        /// </summary>
        timeout,

        /// <summary>
        /// неизвестная ошибка.
        /// </summary>
        unknown,
    }
}
