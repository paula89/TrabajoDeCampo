using DALTest.Contracts;
using DALTest.Repositories.SQL;
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

        public MateriaPrimaRepositories GetMateriaPrimaRepository()
        {
            try
            {
                string nombreNamespaceClaseAccesoDatos = ConfigurationManager.AppSettings["AccesoDatosBusiness"] + ".MateriaPrimaRepositories";
                object instancia = Activator.CreateInstance(Type.GetType(nombreNamespaceClaseAccesoDatos));

                return instancia as MateriaPrimaRepositories;
            }
            catch (Exception exc)
            {
                System.Console.WriteLine("exc :::" + exc.Message);
                return null;
            }
        }
        public HerramientasRepositories GetHerramientasRepository()
        {
            try
            {
                string nombreNamespaceClaseAccesoDatos = ConfigurationManager.AppSettings["AccesoDatosBusiness"] + ".HerramientasRepositories";
                object instancia = Activator.CreateInstance(Type.GetType(nombreNamespaceClaseAccesoDatos));

                return instancia as HerramientasRepositories;
            }
            catch (Exception exc)
            {
                System.Console.WriteLine("exc :::" + exc.Message);
                return null;
            }
        }

    }
}
