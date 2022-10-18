using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Spoleto.PaymentCallback.AtolOnline.Models
{
    public class ReportModel
    {
        /// <summary>
        /// Уникальный идентификатор.
        /// Максимальная длина строки – 128
        /// </summary>
        [JsonPropertyName("uuid")]
        public string Uuid { get; set; }

        /// <summary>
        /// Дата и время документа внешней системы в формате: «dd.mm.yyyy HH:MM:SS»
        /// </summary>
        [JsonPropertyName("timestamp")]
        public string Timestamp { get; set; }

        /// <summary>
        /// URL, на который необходимо ответить после обработки документа.
        /// </summary>
        [JsonPropertyName("callback_url")]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// Статус.
        /// </summary>
        [JsonPropertyName("status")]
        public StatusType Status { get; set; }

        /// <summary>
        /// Идентификатор группы ККТ.
        /// </summary>
        [JsonPropertyName("group_code")]
        public string GroupCode { get; set; }

        /// <summary>
        /// Наименование сервера.
        /// </summary>
        [JsonPropertyName("daemon_code")]
        public string DaemonCode { get; set; }

        /// <summary>
        /// Код ККТ.
        /// </summary>
        [JsonPropertyName("device_code")]
        public string DeviceCode { get; set; }

        /// <summary>
        /// Идентификатор документа внешней системы, уникальный среди всех документов, отправленных в данную группу ККТ.
        /// </summary>
        [JsonPropertyName("external_id")]
        public string ExternalId { get; set; }

        /// <summary>
        /// Описание ошибки, если возникли проблемы.
        /// </summary>
        [JsonPropertyName("error")]
        public ErrorInfo Error { get; set; }

        /// <summary>
        /// Важная информация.
        /// </summary>
        [JsonPropertyName("warnings")]
        public List<WarningModel> Warnings { get; set; }

        /// <summary>
        /// Реквизиты фискализации документа.
        /// </summary>
        [JsonPropertyName("payload")]
        public PayloadModel Payload { get; set; }
    }
}
