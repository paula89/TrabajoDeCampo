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

        public IGenericRepository<Bitacora> GetBitacoraRepository()
        {
            try
            {
                System.Console.WriteLine("nombreNamespaceClaseAccesoDatos:: " + "entre");
                string nombreNamespaceClaseAccesoDatos = ConfigurationManager.AppSettings["AccesoDatos"] + ".Repositories";
                System.Console.WriteLine("nombreNamespaceClaseAccesoDatos:: " + nombreNamespaceClaseAccesoDatos);
                object instancia = Activator.CreateInstance(Type.GetType(nombreNamespaceClaseAccesoDatos));

                return (IGenericRepository<Bitacora>)instancia;
            }
            catch (Exception exc) {
                System.Console.WriteLine("exc :::" + exc.Message);
                return null;
            }
        }
        
    }
}
