using System;

namespace Spoleto.PaymentCallback.CloudKassir.Models
{
    /// <summary>
    /// Признак предмета расчета
    /// </summary>
    public enum PaymentObject
    {
        /// <summary>
        /// Неизвестный предмет оплаты
        /// </summary>
        Unknown = 0,

        /// <summary>
        /// Товар
        /// </summary>
        Commodity = 1,

        /// <summary>
        /// Подакцизный товар
        /// </summary>
        ExcisedCommodity = 2,

        /// <summary>
        /// Работа
        /// </summary>
        Job = 3,

        /// <summary>
        /// Услуга
        /// </summary>
        Service = 4,

        /// <summary>
        /// Ставка азартной игры
        /// </summary>
        GamblingBet = 5,

        /// <summary>
        /// Выигрыш азартной игры
        /// </summary>
        GamblingWin = 6,

        /// <summary>
        /// Лотерейный билет
        /// </summary>
        LotteryTicket = 7,

        /// <summary>
        /// Выигрыш лотереи
        /// </summary>
        LotteryWin = 8,

        /// <summary>
        /// Предоставление РИД
        /// </summary>
        RidAccess = 9,

        /// <summary>
        /// Платеж
        /// </summary>
        Payment = 10,

        /// <summary>
        /// Агентское вознаграждение
        /// </summary>
        AgentReward = 11,

        /// <summary>
        /// Выплата
        /// </summary>
        Composite = 12,

        /// <summary>
        /// Иной предмет расчета
        /// </summary>
        Another = 13,

        /// <summary>
        /// Имущественное право
        /// </summary>
        PropertyLaw = 14,

        /// <summary>
        /// Внереализационный доход
        /// </summary>
        NonOperatingIncome = 15,

        /// <summary>
        /// Страховые взносы
        /// </summary>
        InsuranceContributions = 16,

        /// <summary>
        /// Торговый сбор
        /// </summary>
        TradeFee = 17,

        /// <summary>
        /// Курортный сбор
        /// </summary>
        ResortFee = 18,

        /// <summary>
        /// Залог
        /// </summary>
        CautionMoney = 19,

        /// <summary>
        /// Расход
        /// </summary>
        ExpensesIncurred = 20,

        /// <summary>
        /// Взносы на обязательное пенсионное страхование ИП
        /// </summary>
        ContributionsOnIp = 21,

        /// <summary>
        /// Взносы на обязательное пенсионное страхование
        /// </summary>
        ContributionsSimple = 22,

        /// <summary>
        /// Взносы на обязательное медицинское страхование ИП
        /// </summary>
        ContributionsMedical = 23,

        /// <summary>
        /// Взносы на обязательное медицинское страхование
        /// </summary>
        ContributionsMedicalSimple = 24,

        /// <summary>
        /// Взносы на обязательное социальное страхование
        /// </summary>
        ContributionsSocial = 25,

        /// <summary>
        /// Платеж казино
        /// </summary>
        CasinoPayment = 26,

        /// <summary>
        /// Выдача денежных средств (ффд 1.2)
        /// </summary>
        CashWithdrawal = 27,

        /// <summary>
        /// АТНМ (ффд 1.2)
        /// </summary>
        Atnm = 30,

        /// <summary>
        /// АТМ (ффд 1.2)
        /// </summary>
        Atm = 31,

        /// <summary>
        /// ТНМ (ффд 1.2)
        /// </summary>
        Tnm = 32,

        /// <summary>
        /// ТМ (ффд 1.2)
        /// </summary>
        Tm = 33
    }
}
