using DomainTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DalTest.Repositories.SQL
{
    /// <summary>
    /// this class implements the interface IGenericRepository to create the differents transactions to the losses calculation
    /// </summary>
    public class CalculosPerdidasRepositories : DALTest.Contracts.IGenericRepository<DomainTest.Perdidas>
    {
        /// <summary>
        /// delete a calculation
        /// </summary>
        /// <param name="id"></param>
        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// returns all the calculations by filters
        /// </summary>
        /// <param name="filtros"></param>
        /// <returns></returns>
        public IEnumerable<Perdidas> GetAll(Array filtros)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// return all the calculations
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Perdidas> GetAll()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// insert a new losses calculation
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public int Insert(Perdidas o)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// update a losses calculation
        /// </summary>
        /// <param name="o"></param>
        public void Update(Perdidas o)
        {
            throw new NotImplementedException();
        }
    }
}
