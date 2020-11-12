using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALTest.Contracts
{
    /// <summary>
    /// interface to the differents repositories
    /// </summary>
    /// <typeparam name="T"></typeparam>
        public interface IGenericRepository<T> where T : class, new()
        {
            int Insert(T o);

            void Update(T o);

            void Delete(Guid id);

        IEnumerable<T> GetAll(Array filtros);

    }

}
