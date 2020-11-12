using DomainTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DalTest.Repositories.SQL
{
    /// <summary>
    /// this class implements the interface IGenericRepository to create the differents transactions to the Promociones
    /// </summary>
    public class PromocionesRepositories : DALTest.Contracts.IGenericRepository<DomainTest.Promocion>
    {
        /// <summary>
        /// delete a Promocion
        /// </summary>
        /// <param name="id"></param>
        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// get all the Promocion by filters
        /// </summary>
        /// <param name="filtros"></param>
        /// <returns></returns>
        public IEnumerable<Promocion> GetAll(Array filtros)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// return all the Promocion
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Promocion> GetAll()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// insert a new Producto
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public int Insert(Promocion o)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// update a Promocion
        /// </summary>
        /// <param name="o"></param>
        public void  Update(Promocion o)
        {
            throw new NotImplementedException();
        }
    }
}
