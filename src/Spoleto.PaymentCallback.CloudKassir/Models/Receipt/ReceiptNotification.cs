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
        public string Id { get; set; }

        /// <summary>
        /// Номер чека
        /// </summary>
        public string DocumentNumber { get; set; }

        /// <summary>
        /// Номер смены
        /// </summary>
        public string SessionNumber { get; set; }

        /// <summary>
        /// Номер чека в смене
        /// </summary>
        public string Number { get; set; }

        /// <summary>
        /// Фискальный признак документа
        /// </summary>
        public string FiscalSign { get; set; }

        /// <summary>
        /// Заводской номер ККТ
        /// </summary>
        public string DeviceNumber { get; set; }

        /// <summary>
        /// Регистрационный номер ККТ
        /// </summary>
        public string RegNumber { get; set; }

        /// <summary>
        /// Номер фискального накопителя
        /// </summary>
        public string FiscalNumber { get; set; }

        /// <summary>
        /// ИНН
        /// </summary>
        public string Inn { get; set; }

        /// <summary>
        /// Признак расчета
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Наименование оператора фискальных данных
        /// </summary>
        public string Ofd { get; set; }

        /// <summary>
        /// URL адрес с копией чека
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// URL адрес с QR кодом для проверки чека в ФНС
        /// </summary>
        public string QrCodeUrl { get; set; }

        /// <summary>
        /// Идентификатор транзакции
        /// </summary>
        public long? TransactionId { get; set; }

        /// <summary>
        /// Сумма чека
        /// </summary>
        public string Amount { get; set; }

        /// <summary>
        /// Дата/время выдачи чека во временной зоне UTC
        /// </summary>
        public string DateTime { get; set; }

        /// <summary>
        /// Номер заказа
        /// </summary>
        public string InvoiceId { get; set; }

        /// <summary>
        /// Идентификатор пользователя
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// Состав чека
        /// </summary>
        public string Receipt { get; set; }

        /// <summary>
        /// Место осуществления расчетов
        /// </summary>
        public string CalculationPlace { get; set; }

        /// <summary>
        /// Имя кассира
        /// </summary>
        public string CashierName { get; set; }

        /// <summary>
        /// Место нахождения (установки) ккм
        /// </summary>
        public string SettlePlace { get; set; }

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
