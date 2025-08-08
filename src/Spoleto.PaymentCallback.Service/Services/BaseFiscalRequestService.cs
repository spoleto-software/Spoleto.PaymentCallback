using MongoDB.Driver;
using Spoleto.PaymentCallback.Service.Models.Base;

namespace Spoleto.PaymentCallback.Service.Services
{
    public abstract class BaseFiscalRequestService<TRequest> where TRequest : BaseFiscalRequest
    {
        protected readonly IMongoCollection<TRequest> _fiscalRequests;
        protected readonly ILogger<BaseFiscalRequestService<TRequest>> _logger;

        protected BaseFiscalRequestService(
            FiscalServiceDatabaseSettings settings,
            string collectionName,
            ILogger<BaseFiscalRequestService<TRequest>> logger = null)
        {
            _logger = logger;

            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _fiscalRequests = database.GetCollection<TRequest>(collectionName);

            CreateIndexes();
        }

        private void CreateIndexes()
        {
            try
            {
                var indexKeysDefinition = Builders<TRequest>.IndexKeys.Ascending(x => x.Uuid);
                var indexModel = new CreateIndexModel<TRequest>(indexKeysDefinition);
                _fiscalRequests.Indexes.CreateOne(indexModel);
            }
            catch (Exception ex)
            {
                _logger?.LogError(ex, "Failed to create indexes for {CollectionType}", typeof(TRequest).Name);
                throw;
            }
        }

        public virtual async Task<List<TRequest>> GetAsync() =>
            await _fiscalRequests.Find(_ => true).ToListAsync();

        public virtual async Task<TRequest> GetAsync(string uuid) =>
            await _fiscalRequests.Find(f => f.Uuid == uuid)
                .SortByDescending(f => f.Timestamp)
                .FirstOrDefaultAsync();

        public virtual async Task<TRequest> GetAsyncBySaleSlipId(Guid saleSlipId) =>
            await _fiscalRequests.Find(f => f.SaleSlipId == saleSlipId)
                .SortByDescending(f => f.Timestamp)
                .FirstOrDefaultAsync();

        public virtual async Task<TRequest> GetAsyncByFiscalCheckNumber(int number)
        {
            var allRequests = await GetAsync();
            return allRequests
                .Where(r => r.GetFiscalDocumentNumber() == number)
                .OrderByDescending(r => r.Timestamp)
                .FirstOrDefault();
        }

        public virtual async Task<TRequest> CreateAsync(TRequest fiscalRequest)
        {
            await _fiscalRequests.InsertOneAsync(fiscalRequest);
            return fiscalRequest;
        }

        public virtual async Task UpdateAsync(string uuid, TRequest fiscalRequestIn)
        {
            await _fiscalRequests.ReplaceOneAsync(f => f.Uuid == uuid, fiscalRequestIn);
        }

        public virtual async Task RemoveAsync(TRequest fiscalRequestIn) =>
            await _fiscalRequests.DeleteOneAsync(f => f.Id == fiscalRequestIn.Id);

        public virtual async Task RemoveAsync(string uuid) =>
            await _fiscalRequests.DeleteManyAsync(f => f.Uuid == uuid);

    }

}
