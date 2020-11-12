using DomainTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DalTest.Repositories.SQL
{
    /// <summary>
    /// this class implements the interface IGenericRepository to create the differents transactions to the budget calculation
    /// </summary>
    public class CalculosPresupuestoRepositories : DALTest.Contracts.IGenericRepository<DomainTest.Presupuesto>
    {
        /// <summary>
        /// delete a budget calculation
        /// </summary>
        /// <param name="id"></param>
        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// get all the budget calculation by filters
        /// </summary>
        /// <param name="filtros"></param>
        /// <returns></returns>
        public IEnumerable<Presupuesto> GetAll(Array filtros)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// get all the budgets calculation
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Presupuesto> GetAll()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// insert a new budget
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public int Insert(Presupuesto o)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// update a budget calculation calculation
        /// </summary>
        /// <param name="o"></param>
        public void Update(Presupuesto o)
        {
            throw new NotImplementedException();
        }
    }
}
