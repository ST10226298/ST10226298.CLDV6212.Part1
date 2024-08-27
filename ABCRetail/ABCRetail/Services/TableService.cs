using Azure;
using Azure.Data.Tables;
using ABCRetail.Models;
using System.Threading.Tasks;

namespace ABCRetail.Services
{
    public class TableService
    {
        private readonly TableClient _tableClient;

        public TableService(IConfiguration configuration)
        {
            var connectionString = configuration["AzureStorage:ConnectionString"];
            var serviceClient = new TableServiceClient(connectionString);
            _tableClient = serviceClient.GetTableClient("CustomerID");
            _tableClient.CreateIfNotExists();
        }

        public async Task AddEntityAsync(CustomerID profile)
        {
            await _tableClient.AddEntityAsync(profile);
        }
    }
}
