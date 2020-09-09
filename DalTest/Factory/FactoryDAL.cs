using DALTest.Contracts;
using DomainTest;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALTest.Factory
{
    public class FactoryDAL
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

        public IGenericRepository<Producto> GetBitacoraRepository()
        {
            try
            {
                string nombreNamespaceClaseAccesoDatos = ConfigurationManager.AppSettings["AccesoDatos"] + ".BitacoraRepository";
                object instancia = Activator.CreateInstance(Type.GetType(nombreNamespaceClaseAccesoDatos));

                return instancia as IGenericRepository<Producto>;
            }
            catch (Exception exc)
            {
                System.Console.WriteLine("exc :::" + exc.Message);
                return null;
            }
        }

        
    }
}
