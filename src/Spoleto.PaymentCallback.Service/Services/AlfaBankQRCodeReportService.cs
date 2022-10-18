using System.Linq.Expressions;
using MongoDB.Driver;
using Spoleto.PaymentCallback.Service.Models.Alfa;
using Spoleto.PaymentCallback.Service.Models.AtolOnline;

namespace Spoleto.PaymentCallback.Service.Services
{
    public class AlfaBankQRCodeReportService
    {
        private readonly IMongoCollection<QRCodeReportModel> _qrCodeReports;

        public AlfaBankQRCodeReportService(IAlfaServiceDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _qrCodeReports = database.GetCollection<QRCodeReportModel>(settings.QRCodeReportsCollectionName);

            var fiscalRequestBuilder = Builders<QRCodeReportModel>.IndexKeys;
            var indexModel1 = new CreateIndexModel<QRCodeReportModel>(fiscalRequestBuilder.Ascending(x => x.QrcId));
            var indexName1 = _qrCodeReports.Indexes.CreateOne(indexModel1);

            var indexModel2 = new CreateIndexModel<QRCodeReportModel>(fiscalRequestBuilder.Ascending(x => x.TrxId));
            var indexName2 = _qrCodeReports.Indexes.CreateOne(indexModel2);
        }

        public async Task<List<QRCodeReportModel>> GetAsync(Expression<Func<QRCodeReportModel, bool>> filter, int? limit) =>
            await _qrCodeReports.Find(filter).SortByDescending(f => f.Timestamp).Limit(limit).ToListAsync();

        public async Task<List<QRCodeReportModel>> GetAsyncByQrcId(string qrcId) =>
            await _qrCodeReports.Find(f => f.QrcId == qrcId).ToListAsync();

        public async Task<QRCodeReportModel> GetAsync(string trxId) =>
            await _qrCodeReports.Find(f => f.TrxId == trxId).SortByDescending(f => f.Timestamp).FirstOrDefaultAsync();


        public async Task<QRCodeReportModel> CreateAsync(QRCodeReportModel fiscalRequest)
        {
            await _qrCodeReports.InsertOneAsync(fiscalRequest);
            return fiscalRequest;
        }

        public async Task UpdateAsync(string trxId, QRCodeReportModel fiscalRequestIn) =>
            await _qrCodeReports.ReplaceOneAsync(f => f.TrxId == trxId, fiscalRequestIn);

        public async Task RemoveAsync(QRCodeReportModel fiscalRequestIn) =>
           await _qrCodeReports.DeleteOneAsync(f => f.Id == fiscalRequestIn.Id);

        public async Task RemoveAsync(string trxId) =>
            await _qrCodeReports.DeleteManyAsync(f => f.TrxId == trxId);
    }
}
