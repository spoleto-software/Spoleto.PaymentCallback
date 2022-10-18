using Spoleto.MQ.Messages;

namespace Spoleto.PaymentCallback.AlfaBank
{
    /// <summary>
    /// Уникальное сообщение для отправки по RabbitMQ.
    /// </summary>
    public class AlfaBankQRCodeReport : QRCodeReport, IUniqueMessage
    {
        /// <summary>
        /// Уникальное имя очереди для RabbitMQ.
        /// </summary>
        public string UniqueName => $"{nameof(AlfaBankQRCodeReport)}.{QrcId}";
    }
}
