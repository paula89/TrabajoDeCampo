using DomainTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DalTest.Repositories.SQL
{
    /// <summary>
    /// this class implements the interface IGenericRepository to create the differents transactions to the Producto
    /// </summary>
    public class ProductosRepositories : DALTest.Contracts.IGenericRepository<DomainTest.Producto>
    {
        /// <summary>
        /// delete a Producto
        /// </summary>
        /// <param name="id"></param>
        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Return all the Producto by filters
        /// </summary>
        /// <param name="filtros"></param>
        /// <returns></returns>
        public IEnumerable<Producto> GetAll(Array filtros)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// return all the Producto
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Producto> GetAll()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// insert a new Producto
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public int Insert(Producto o)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// update a Producto
        /// </summary>
        /// <param name="o"></param>
        public void Update(Producto o)
        {
            throw new NotImplementedException();
        }
    }
}
