using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using DAL.Contracts;
using Domain;

namespace DAL.Factory
{
    public sealed class FactoryDAL
    {
        #region Singleton
        private readonly static FactoryDAL instance = new FactoryDAL();

        public static FactoryDAL Current
        {
            get
            {
                return instance;
            }
        }

        private FactoryDAL()
        {
            //Implement here the initialization code
        }
        #endregion

        public IGenericRepository<Producto> GetCustomerRepository()
        {

            string nombreNamespaceClaseAccesoDatos = ConfigurationManager.AppSettings["AccesoDatos"] + ".Repositories";
            object instancia = Activator.CreateInstance(Type.GetType(nombreNamespaceClaseAccesoDatos));

            return (IGenericRepository<Producto>)instancia;
        }
        
    }
}
