namespace Spoleto.PaymentCallback.Service.Models.Base
{
    public abstract class FiscalServiceDatabaseSettings
    {
        public string FiscalRequestsCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
