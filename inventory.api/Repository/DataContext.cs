using Microsoft.Extensions.Options;
using MongoDB.Driver;
using inventory.api.Options;

namespace inventory.api.Repository
{
    public class DataContext<T> : IDataContext<T>
    {
        private readonly IMongoDatabase Database = null;
        private readonly IOptions<InventoryOptions> Options;
        //TODO: remove dependency with phrases options
        public DataContext(IOptions<InventoryOptions> options)
        {
            Options = options;
            var client = new MongoClient(options.Value.ConnectionString);
            if (client != null)
                Database = client.GetDatabase(options.Value.Database);
        }

        public IMongoCollection<T> Collection => Database.GetCollection<T>(Options.Value.Collection);

    }
}