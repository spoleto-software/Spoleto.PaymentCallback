using System.Text.Json.Serialization;

namespace Spoleto.PaymentCallback.AtolOnline.Models
{
    /// <summary>
    /// Важная информация.
    /// </summary>
    public class WarningModel
    {
        /// <summary>
        /// Имеет значение «callback_url не соответствует маске».
        /// </summary>
        /// <remarks>
        /// Отображается в случае, если значение параметра callback_url в запросе на регистрацию документа было указано некорректно.
        /// </remarks>
        [JsonPropertyName("callback_url")]
        public string CallbackUrl { get; set; }
    }
}
