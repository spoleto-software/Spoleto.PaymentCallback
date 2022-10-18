using System.Text.Json.Serialization;

namespace Spoleto.PaymentCallback.AtolOnline.Models
{
    /// <summary>
    /// Ошибка.
    /// </summary>
    public class ErrorInfo
    {
        /// <summary>
        /// уникальный идентификатор ошибки.
        /// </summary>
        [JsonPropertyName("error_id")]
        public string ErrorId { get; set; }

        /// <summary>
        /// код ошибки.
        /// </summary>
        [JsonPropertyName("code")]
        public int Code { get; set; }

        /// <summary>
        /// текст ошибки.
        /// </summary>
        [JsonPropertyName("text")]
        public string Text { get; set; }

        /// <summary>
        /// тип ошибки.
        /// </summary>
        [JsonPropertyName("type")]
        public ErrorType Type { get; set; }

        public override string ToString() => Text;
    }
}
