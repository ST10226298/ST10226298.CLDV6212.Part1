using Azure;
using Azure.Data.Tables;
using System;

namespace ABCRetail.Models
{
    public class CustomerID : ITableEntity
    {
        public string PartitionKey { get; set; }
        public string RowKey { get; set; }
        public DateTimeOffset? Timestamp { get; set; }
        public ETag ETag { get; set; }

        // Custom properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public CustomerID()
        {
            PartitionKey = "CustomerID";
            RowKey = Guid.NewGuid().ToString();
        }
    }
}
