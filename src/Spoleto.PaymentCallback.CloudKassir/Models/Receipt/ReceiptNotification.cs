using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Spoleto.PaymentCallback.CloudKassir.Models
{
    /// <summary>
    /// Уведомление о сформированном чеке (form-data)
    /// </summary>
    public class ReceiptNotification
    {
        private CustomerReceipt _customerReceipt;

        /// <summary>
        /// Уникальный идентификатор чека
        /// </summary>
        [JsonPropertyName("Id")]
        public string Id { get; set; }

        /// <summary>
        /// Номер чека
        /// </summary>
        [JsonPropertyName("DocumentNumber")]
        public string DocumentNumber { get; set; }

        /// <summary>
        /// Номер смены
        /// </summary>
        [JsonPropertyName("SessionNumber")]
        public string SessionNumber { get; set; }

        /// <summary>
        /// Номер чека в смене
        /// </summary>
        [JsonPropertyName("Number")]
        public string Number { get; set; }

        /// <summary>
        /// Фискальный признак документа
        /// </summary>
        [JsonPropertyName("FiscalSign")]
        public string FiscalSign { get; set; }

        /// <summary>
        /// Заводской номер ККТ
        /// </summary>
        [JsonPropertyName("DeviceNumber")]
        public string DeviceNumber { get; set; }

        /// <summary>
        /// Регистрационный номер ККТ
        /// </summary>
        [JsonPropertyName("RegNumber")]
        public string RegNumber { get; set; }

        /// <summary>
        /// Номер фискального накопителя
        /// </summary>
        [JsonPropertyName("FiscalNumber")]
        public string FiscalNumber { get; set; }

        /// <summary>
        /// ИНН
        /// </summary>
        [JsonPropertyName("Inn")]
        public string Inn { get; set; }

        /// <summary>
        /// Признак расчета
        /// </summary>
        [JsonPropertyName("Type")]
        public string Type { get; set; }

        /// <summary>
        /// Наименование оператора фискальных данных
        /// </summary>
        [JsonPropertyName("Ofd")]
        public string Ofd { get; set; }

        /// <summary>
        /// URL адрес с копией чека
        /// </summary>
        [JsonPropertyName("Url")]
        public string Url { get; set; }

        /// <summary>
        /// URL адрес с QR кодом для проверки чека в ФНС
        /// </summary>
        [JsonPropertyName("QrCodeUrl")]
        public string QrCodeUrl { get; set; }

        /// <summary>
        /// Идентификатор транзакции
        /// </summary>
        [JsonPropertyName("TransactionId")]
        public long? TransactionId { get; set; }

        /// <summary>
        /// Сумма чека
        /// </summary>
        [JsonPropertyName("Amount")]
        public string Amount { get; set; }

        /// <summary>
        /// Дата/время выдачи чека во временной зоне UTC
        /// </summary>
        [JsonPropertyName("DateTime")]
        public string DateTime { get; set; }

        /// <summary>
        /// Номер заказа
        /// </summary>
        [JsonPropertyName("InvoiceId")]
        public string InvoiceId { get; set; }

        /// <summary>
        /// Идентификатор пользователя
        /// </summary>
        [JsonPropertyName("AccountId")]
        public string AccountId { get; set; }

        /// <summary> 
        /// JSON строка с данными чека (как приходит от CloudKassir)
        /// </summary>
        [JsonIgnore]
        public string Receipt { get; set; }

        /// <summary>
        /// Место осуществления расчетов
        /// </summary>
        [JsonPropertyName("CalculationPlace")]
        public string CalculationPlace { get; set; }

        /// <summary>
        /// Имя кассира
        /// </summary>
        [JsonPropertyName("CashierName")]
        public string CashierName { get; set; }

        /// <summary>
        /// Место нахождения (установки) ккм
        /// </summary>
        [JsonPropertyName("SettlePlace")]
        public string SettlePlace { get; set; }

        /// <summary>
        /// Состав чека
        /// </summary>
        [JsonPropertyName("Receipt")]
        public CustomerReceipt CustomerReceipt
        {
            get
            {
                if (_customerReceipt == null && !string.IsNullOrEmpty(Receipt))
                {
                    try
                    {
                        _customerReceipt = JsonSerializer.Deserialize<CustomerReceipt>(Receipt);
                    }
                    catch (JsonException)
                    {
                        _customerReceipt = null;
                    }
                }
                return _customerReceipt;
            }
        }
    }

}
