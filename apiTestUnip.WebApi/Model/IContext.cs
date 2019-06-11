using MongoDB.Driver;

namespace apiTestUnip.WebApi.Model
{
    public interface IContext<T> where T : new()
    {
        IMongoCollection<T> collection { get; }
    }
}