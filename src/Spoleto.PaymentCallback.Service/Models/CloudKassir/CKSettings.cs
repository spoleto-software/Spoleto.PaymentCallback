namespace Spoleto.PaymentCallback.Service.Models.CloudKassir
{
    public class CKSettings
    {
        public string ApiSecret { get; set; }
        public bool EnableHmacValidation { get; set; } = true; // enable by default
        public bool EnableMessageQueue { get; set; } = true;
    }
}
