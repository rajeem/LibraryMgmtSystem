using LibraryMgmtSystem.Domain.Entities;
using LibraryMgmtSystem.Domain.Interfaces;
using System.Text.Json;

namespace LibraryMgmtSystem.Infrastructure
{
    public class FlatFileRepository : IRepository
    {
        public void Add<T>(T entity) where T : Entity
        {
            var list = GetList<T>();
            list.Add(entity);
            File.WriteAllText(typeof(T).Name + ".dat", JsonSerializer.Serialize(list));
        }

        public void Delete<T>(string id) where T : Entity
        {
            var list = GetList<T>();
            list = list.Where(x => x.Id != id).ToList();
            File.WriteAllText(typeof(T).Name + ".dat", JsonSerializer.Serialize(list));
        }

        public T Get<T>(string id) where T : Entity
        {
            var list = GetList<T>();

            return list.SingleOrDefault(x => x.Id == id);
        }

        public List<T> GetAll<T>() where T : Entity
        {
            var list = GetList<T>();

            return list;
        }

        public void Update<T>(T entity) where T : Entity
        {
            var list = GetList<T>();

            list = list.Where(x => x.Id != entity.Id).ToList();
            list.Add(entity);
            File.WriteAllText(typeof(T).Name + ".dat", JsonSerializer.Serialize(list));
        }

        private List<T> GetList<T>()
        {
            var listTxt = File.Exists(typeof(T).Name + ".dat") ? File.ReadAllText(typeof(T).Name + ".dat") : "[]";
            var list = string.IsNullOrWhiteSpace(listTxt) ? new List<T>() : (JsonSerializer.Deserialize<List<T>>(listTxt) ?? new List<T>());
            return list;
        }
    }
}
