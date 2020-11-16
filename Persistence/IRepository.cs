using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public interface IRepository<ID, E> where E : Entity<ID>
    {
        E FindOne(ID id);
        List<E> FindAll();
        void Save(E entity);
        void Delete(ID id);
        void Update(E entity);
        int Size();
    }
}
