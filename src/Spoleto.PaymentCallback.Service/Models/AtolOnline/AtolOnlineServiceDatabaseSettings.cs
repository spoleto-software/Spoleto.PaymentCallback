namespace Spoleto.PaymentCallback.Service.Models.AtolOnline
{
    public class AtolOnlineServiceDatabaseSettings : IAtolOnlineServiceDatabaseSettings
    {
        public string FiscalRequestsCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface IAtolOnlineServiceDatabaseSettings
    {
        string FiscalRequestsCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
