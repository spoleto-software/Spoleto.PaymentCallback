using System;
using System.Collections.Generic;
using System.Text;
using Spoleto.MQ.Messages;

namespace Spoleto.PaymentCallback.CloudKassir.Models
{
    public class CKFiscalReport : ReceiptNotification, IUniqueMessage
    {
        /// <summary>
        /// Уникальное имя очереди для RabbitMQ.
        /// </summary>
        public string UniqueName => $"{nameof(CKFiscalReport)}.{Id}";

        public DateTime? Timestamp { get; set; }
    }
}
