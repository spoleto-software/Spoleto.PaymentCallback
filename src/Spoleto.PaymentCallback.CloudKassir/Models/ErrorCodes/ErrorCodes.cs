using System;

namespace Spoleto.PaymentCallback.CloudKassir.Models
{
    /// <summary>
    /// Коды ошибок при формировании онлайн-чека
    /// </summary>
    public static class ErrorCodes
    {
        /// <summary>
        /// Неизвестная ошибка
        /// </summary>
        public const int UnknownError = -1;

        /// <summary>
        /// Отсутствует ККТ для фискализации транзакции для данной организации
        /// </summary>
        public const int NoKktForOrganization = 2;

        /// <summary>
        /// Переданная система налогообложения не установлена ни в одной кассе для данной организации
        /// </summary>
        public const int TaxationSystemNotSet = 3;

        /// <summary>
        /// Переданы не все необходимые данные агента
        /// </summary>
        public const int IncompleteAgentData = 4;

        /// <summary>
        /// Отсутствует ИНН поставщика или телефон поставщика при агентском расчете
        /// </summary>
        public const int MissingPurveyorData = 5;

        /// <summary>
        /// Оформление услуг не разрешено при регистрации ККТ или телефон покупателя передан в неверном формате
        /// </summary>
        public const int ServicesNotAllowedOrInvalidPhone = 6;

        /// <summary>
        /// Неверный формат ИНН поставщика
        /// </summary>
        public const int InvalidPurveyorInn = 7;

        /// <summary>
        /// Ресурс хранения документов исчерпан (ФН переполнен)
        /// </summary>
        public const int FnFull = 8;

        /// <summary>
        /// Ошибка агентских данных
        /// </summary>
        public const int AgentDataError = 9;

        /// <summary>
        /// Не зашифрованные персональные данные
        /// </summary>
        public const int UnencryptedPersonalData = 10;

        /// <summary>
        /// Не передан ИНН
        /// </summary>
        public const int MissingInn = 11;

        /// <summary>
        /// Отсутствует информация о товарах/услугах
        /// </summary>
        public const int MissingItems = 12;

        /// <summary>
        /// Сумма по всем способам оплаты меньше итога чека
        /// </summary>
        public const int InsufficientPaymentSum = 13;

        /// <summary>
        /// Вносимая безналичной оплатой сумма больше суммы чека
        /// </summary>
        public const int ExcessiveElectronicPayment = 14;

        /// <summary>
        /// Нет подходящей ККМ для данной организации
        /// </summary>
        public const int NoSuitableKkm = 15;

        /// <summary>
        /// Нет касс с подходящим терминалом
        /// </summary>
        public const int NoKktWithTerminal = 16;

        /// <summary>
        /// Нет касс с признаком БСО
        /// </summary>
        public const int NoKktWithBso = 17;

        /// <summary>
        /// Нет касс без признака БСО
        /// </summary>
        public const int NoKktWithoutBso = 18;

        /// <summary>
        /// Нет касс поддерживающих наличный расчет
        /// </summary>
        public const int NoKktWithCash = 19;

        /// <summary>
        /// Нет касс с агентским признаком
        /// </summary>
        public const int NoKktWithAgentSign = 20;

        /// <summary>
        /// Нет касс с поддержкой тега - Дополнительный реквизит пользователя
        /// </summary>
        public const int NoKktWithUserRequisite = 21;

        /// <summary>
        /// Превышен лимит тестовых чеков за день
        /// </summary>
        public const int TestReceiptLimitExceeded = 22;

        /// <summary>
        /// Неверный формат цены/суммы - не более двух знаков после точки
        /// </summary>
        public const int InvalidPriceFormat = 23;

        /// <summary>
        /// Неверный формат email
        /// </summary>
        public const int InvalidEmailFormat = 24;

        /// <summary>
        /// Нет оплаченных ККМ для обработки чека
        /// </summary>
        public const int NoPaidKkm = 25;

        /// <summary>
        /// Не переданы необходимые данные
        /// </summary>
        public const int RequiredDataMissing = 26;

        /// <summary>
        /// Некорректные данные
        /// </summary>
        public const int InvalidData = 27;
    }
}
