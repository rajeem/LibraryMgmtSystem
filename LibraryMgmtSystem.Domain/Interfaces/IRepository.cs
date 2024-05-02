using LibraryMgmtSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMgmtSystem.Domain.Interfaces
{
    public interface IRepository
    {
        T Get<T>(string id) where T : Entity;
        void Add<T>(T entity) where T : Entity;
        void Update<T>(T entity) where T : Entity;
        void Delete<T>(string id) where T: Entity;
        List<T> GetAll<T>() where T: Entity;
    }
}
