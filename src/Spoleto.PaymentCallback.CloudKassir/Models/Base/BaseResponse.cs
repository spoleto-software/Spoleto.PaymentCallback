using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Spoleto.PaymentCallback.CloudKassir.Models
{

    /// <summary>
    /// Базовый ответ API
    /// </summary>
    public class BaseResponse
    {
        /// <summary>
        /// Результат выполнения запроса (успешно или нет)
        /// </summary>
        [JsonPropertyName("Success")]
        public bool Success { get; set; }

        /// <summary>
        /// Дополнительная информация
        /// </summary>
        [JsonPropertyName("Message")]
        public string Message { get; set; }

        /// <summary>
        /// Предупреждение
        /// </summary>
        [JsonPropertyName("Warning")]
        public string Warning { get; set; }

        /// <summary>
        /// Коды предупреждений
        /// </summary>
        [JsonPropertyName("WarningCodes")]
        public List<int> WarningCodes { get; set; }

        /// <summary>
        /// Внутренний результат
        /// </summary>
        [JsonPropertyName("InnerResult")]
        public object InnerResult { get; set; }
    }

    /// <summary>
    /// Базовый ответ с моделью
    /// </summary>
    public class BaseResponse<T> : BaseResponse
    {
        /// <summary>
        /// Модель данных
        /// </summary>
        [JsonPropertyName("Model")]
        public T Model { get; set; }
    }


}
