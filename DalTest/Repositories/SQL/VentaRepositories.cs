using DomainTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DalTest.Repositories.SQL
{
    /// <summary>
    /// this class implements the interface IGenericRepository to create the differents transactions to the Venta
    /// </summary>
    public class VentaRepositories : DALTest.Contracts.IGenericRepository<DomainTest.Venta>
    {
        /// <summary>
        /// Delete a Venta
        /// </summary>
        /// <param name="id"></param>
        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Return allthe Venta by filters
        /// </summary>
        /// <param name="filtros"></param>
        /// <returns></returns>
        public IEnumerable<Venta> GetAll(Array filtros)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Return all the Venta
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Venta> GetAll()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// insert a new Venta
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public int Insert(Venta o)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// update a venta
        /// </summary>
        /// <param name="o"></param>
        public void Update(Venta o)
        {
            throw new NotImplementedException();
        }
    }
}
