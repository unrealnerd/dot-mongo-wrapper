using MongoDB.Driver;

namespace inventory.api.Repository
{
    public interface IDataContext<T>
    {
        IMongoCollection<T> Collection { get; } 
    }
}