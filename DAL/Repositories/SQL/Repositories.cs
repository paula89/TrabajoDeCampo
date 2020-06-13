using DAL.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using Domain;

namespace DAL.Repositories.SQL
{
    public class Repositories : IGenericRepository<Producto>
    {
        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Producto> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(Producto o)
        {
            throw new NotImplementedException();
        }

        public void Update(Producto o)
        {
            throw new NotImplementedException();
        }
    }
}
