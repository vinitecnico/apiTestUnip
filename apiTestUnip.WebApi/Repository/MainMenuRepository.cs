using System.Collections.Generic;
using System.Threading.Tasks;
using apiTestUnip.WebApi.Model;
using MongoDB.Bson;
using MongoDB.Driver;

namespace apiTestUnip.WebApi.Repository
{
    public class MainMenuRepository : IRepository<MainMenu>
    {
        private readonly IContext<MainMenu> _context;

        public MainMenuRepository(IContext<MainMenu> context)
        {
            _context = context;
        }

        public async Task Create(MainMenu item)
        {
            await _context.collection.InsertOneAsync(item);
        }

        public async Task<bool> Delete(string id)
        {
            var result = await _context.collection.FindOneAndDeleteAsync(x => x.Id == ObjectId.Parse(id));
            return true;
        }

        public async Task<IEnumerable<MainMenu>> GetAll()
        {
            return await _context.collection.Find(_ => true).ToListAsync();
        }

        public async Task<MainMenu> GetById(string id)
        {
            return await _context.collection.Find(x => x.Id == ObjectId.Parse(id)).FirstOrDefaultAsync();
        }

        public async Task Update(string id, MainMenu item)
        {
            var filter = Builders<MainMenu>.Filter.Eq(s => s.Id, ObjectId.Parse(id));
            var update = Builders<MainMenu>.Update.Set(s => s.name, item.name);
            await _context.collection.UpdateOneAsync(filter, update);
        }
    }
}