namespace Spoleto.PaymentCallback.Service.Models.AtolOnline
{
    public class AlfaBankServiceDatabaseSettings : IAlfaServiceDatabaseSettings
    {
        public string QRCodeReportsCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface IAlfaServiceDatabaseSettings
    {
        string QRCodeReportsCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
