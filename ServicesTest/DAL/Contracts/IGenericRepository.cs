﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesTest.DAL.Contracts
{
    
        public interface IGenericRepository<T> where T : class, new()
        {
            int Insert(T o);

            int Update(T o);

            void Delete(Guid id);

            IEnumerable<T> GetAll(Array filtros);

        }
    
}
