using System;

namespace Spoleto.PaymentCallback.CloudKassir.Models
{
    /// <summary>
    /// Коды предупреждений
    /// </summary>
    public static class WarningCodes
    {

        /// <summary>
        /// Ошибка кассы
        /// </summary>
        public const int CashRegisterError = 5;

        /// <summary>
        /// Ошибка криптопроцессора
        /// </summary>
        public const int CryptoError = 1;

        /// <summary>
        /// ФН заполнен
        /// </summary>
        public const int FnBufferFull = 3;

        /// <summary>
        /// Буфер ФН переполнен
        /// </summary>
        public const int FnBufferOverflow = 4;

        /// <summary>
        /// Срок действия фискального накопителя истек
        /// </summary>
        public const int FnExpired = 1;

        /// <summary>
        /// Есть касса (кассы) с заполненным ФН
        /// </summary>
        public const int FnFull = 2;

        /// <summary>
        /// Ошибка кассы
        /// </summary>
        public const int KktError = 4;
        /// <summary>
        /// Есть касса (кассы) с неотправляющимися в ОФД документами
        /// </summary>
        public const int OfdQueueNotEmpty = 1;

        /// <summary>
        /// Переполнение очереди отправки в ОФД
        /// </summary>
        public const int OfdQueueOverflow = 2;
    }
}
