using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Spoleto.PaymentCallback.Service.Models.AtolOnline;
using MongoDB.Driver;

namespace Spoleto.PaymentCallback.Service.Services
{
    public class AtolOnlineFiscalRequestService
    {
        private readonly IMongoCollection<FiscalRequest> _fiscalRequests = null;

        public AtolOnlineFiscalRequestService(IAtolOnlineServiceDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _fiscalRequests = database.GetCollection<FiscalRequest>(settings.FiscalRequestsCollectionName);

            var fiscalRequestBuilder = Builders<FiscalRequest>.IndexKeys;
            var indexModel = new CreateIndexModel<FiscalRequest>(fiscalRequestBuilder.Ascending(x => x.Uuid));
            var indexName = _fiscalRequests.Indexes.CreateOne(indexModel);
        }

        public async Task<List<FiscalRequest>> GetAsync() =>
            await _fiscalRequests.Find(f => true).ToListAsync();

        public async Task<FiscalRequest> GetAsync(string uuid) =>
            await _fiscalRequests.Find(f => f.Uuid == uuid).SortByDescending(f => f.Timestamp).FirstOrDefaultAsync();

        public async Task<FiscalRequest> GetAsyncBySaleSlipId(Guid saleSlipId) =>
            await _fiscalRequests.Find(f => f.SaleSlipId == saleSlipId).SortByDescending(f => f.Timestamp).FirstOrDefaultAsync();

        public async Task<FiscalRequest> GetAsyncByFiscalCheckNumber(int number) =>
            await _fiscalRequests.Find(f => f.OriginalReportModel.Payload.FiscalDocumentNumber == number).SortByDescending(f => f.Timestamp).FirstOrDefaultAsync();

        public async Task<FiscalRequest> CreateAsync(FiscalRequest fiscalRequest)
        {
            await _fiscalRequests.InsertOneAsync(fiscalRequest);
            return fiscalRequest;
        }

        public async Task UpdateAsync(string uuid, FiscalRequest fiscalRequestIn) =>
            await _fiscalRequests.ReplaceOneAsync(f => f.Uuid == uuid, fiscalRequestIn);

        public async Task RemoveAsync(FiscalRequest fiscalRequestIn) =>
           await _fiscalRequests.DeleteOneAsync(f => f.Id == fiscalRequestIn.Id);

        public async Task RemoveAsync(string uuid) =>
            await _fiscalRequests.DeleteManyAsync(f => f.Uuid == uuid);
    }
}
