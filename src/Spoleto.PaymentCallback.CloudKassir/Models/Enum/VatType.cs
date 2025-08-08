using System;

namespace Spoleto.PaymentCallback.CloudKassir.Models
{
    /// <summary>
    /// Ставка НДС
    /// </summary>
    public enum VatType
    {
        /// <summary>
        /// НДС не облагается
        /// </summary>
        None = -1,

        /// <summary>
        /// НДС 0%
        /// </summary>
        Vat0 = 0,

        /// <summary>
        /// НДС 5%
        /// </summary>
        Vat5 = 5,

        /// <summary>
        /// НДС 7%
        /// </summary>
        Vat7 = 7,

        /// <summary>
        /// НДС 10%
        /// </summary>
        Vat10 = 10,

        /// <summary>
        /// НДС 12% (только для онлайн-касс в Казахстане)
        /// </summary>
        Vat12 = 12,

        /// <summary>
        /// НДС 20%
        /// </summary>
        Vat20 = 20,

        /// <summary>
        /// Расчетный НДС 5/105
        /// </summary>
        Vat105 = 105,

        /// <summary>
        /// Расчетный НДС 7/107
        /// </summary>
        Vat107 = 107,

        /// <summary>
        /// Расчетный НДС 10/110
        /// </summary>
        Vat110 = 110,

        /// <summary>
        /// Расчетный НДС 20/120
        /// </summary>
        Vat120 = 120
    }
}
