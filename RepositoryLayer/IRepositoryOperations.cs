using Domainlayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer
{
    public interface IRepositoryOperations<T> 
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        IEnumerable<T> Get();
        T GetById(int id);
        void Save();
    }
}
