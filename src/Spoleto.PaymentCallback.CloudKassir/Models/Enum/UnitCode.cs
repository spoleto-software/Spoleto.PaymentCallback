using System;

namespace Spoleto.PaymentCallback.CloudKassir.Models
{
    /// <summary>
    /// Мера количества предмета расчета
    /// </summary>
    public enum UnitCode
    {
        /// <summary>
        /// шт. или ед
        /// </summary>
        Unit = 0,

        /// <summary>
        /// Грамм
        /// </summary>
        Gram = 10,

        /// <summary>
        /// Килограмм
        /// </summary>
        Kilogram = 11,

        /// <summary>
        /// Тонна
        /// </summary>
        Ton = 12,

        /// <summary>
        /// Сантиметр
        /// </summary>
        Centimetre = 20,

        /// <summary>
        /// Дециметр
        /// </summary>
        Decimetre = 21,

        /// <summary>
        /// Метр
        /// </summary>
        Metre = 22,

        /// <summary>
        /// Квадратный сантиметр
        /// </summary>
        SquareCentimetre = 30,

        /// <summary>
        /// Квадратный дециметр
        /// </summary>
        SquareDecimetre = 31,

        /// <summary>
        /// Квадратный метр
        /// </summary>
        SquareMetre = 32,

        /// <summary>
        /// Миллилитр
        /// </summary>
        Milliliter = 40,

        /// <summary>
        /// Литр
        /// </summary>
        Litre = 41,

        /// <summary>
        /// Кубический метр
        /// </summary>
        CubicMeter = 42,

        /// <summary>
        /// Киловатт час
        /// </summary>
        KilowattHour = 50,

        /// <summary>
        /// Гигакалория
        /// </summary>
        Gigacalorie = 51,

        /// <summary>
        /// Сутки (день)
        /// </summary>
        Day = 70,

        /// <summary>
        /// Час
        /// </summary>
        Hour = 71,

        /// <summary>
        /// Минута
        /// </summary>
        Minute = 72,

        /// <summary>
        /// Секунда
        /// </summary>
        Second = 73,

        /// <summary>
        /// Килобайт
        /// </summary>
        Kilobyte = 80,

        /// <summary>
        /// Мегабайт
        /// </summary>
        Megabyte = 81,

        /// <summary>
        /// Гигабайт
        /// </summary>
        Gigabyte = 82,

        /// <summary>
        /// Терабайт
        /// </summary>
        Terabyte = 83,

        /// <summary>
        /// Иная система измерения
        /// </summary>
        None = 255
    }
}
