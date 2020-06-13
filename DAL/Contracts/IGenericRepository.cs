using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Contracts
{
    public interface IGenericRepository<T> where T : class, new()
    {
        void Insert(T o);

        void Update(T o);

        void Delete(Guid id);

        IEnumerable<T> GetAll();

    }
}
