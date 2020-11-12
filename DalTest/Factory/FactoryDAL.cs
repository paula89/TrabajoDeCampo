using DalTest.Repositories.SQL;
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
    /// <summary>
    /// this class is the factory of the differents endpoint to the repositories
    /// </summary>
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
        /// <summary>
        /// Return the repository to the MateriaPrima
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// Return the repository to the Herramientas
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// Return the respository to the Presupuesto
        /// </summary>
        /// <returns></returns>
        public CalculosPresupuestoRepositories GetCalculoPresupuestoRepository()
        {
            try
            {
                string nombreNamespaceClaseAccesoDatos = ConfigurationManager.AppSettings["AccesoDatosBusiness"] + ".CalculosPresupuestoRepositories";
                object instancia = Activator.CreateInstance(Type.GetType(nombreNamespaceClaseAccesoDatos));

                return instancia as CalculosPresupuestoRepositories;
            }
            catch (Exception exc)
            {
                System.Console.WriteLine("exc :::" + exc.Message);
                return null;
            }
        }
        /// <summary>
        /// Return the repository to losses calculation
        /// </summary>
        /// <returns></returns>
        public CalculosPerdidasRepositories GetCalculoPerdidasRepository()
        {
            try
            {
                string nombreNamespaceClaseAccesoDatos = ConfigurationManager.AppSettings["AccesoDatosBusiness"] + ".CalculosPerdidasRepositories";
                object instancia = Activator.CreateInstance(Type.GetType(nombreNamespaceClaseAccesoDatos));

                return instancia as CalculosPerdidasRepositories;
            }
            catch (Exception exc)
            {
                System.Console.WriteLine("exc :::" + exc.Message);
                return null;
            }
        }
        /// <summary>
        /// Return the repository to the Producto
        /// </summary>
        /// <returns></returns>
        public ProductosRepositories GetProductosRepository()
        {
            try
            {
                string nombreNamespaceClaseAccesoDatos = ConfigurationManager.AppSettings["AccesoDatosBusiness"] + ".ProductosRepositories";
                object instancia = Activator.CreateInstance(Type.GetType(nombreNamespaceClaseAccesoDatos));

                return instancia as ProductosRepositories;
            }
            catch (Exception exc)
            {
                System.Console.WriteLine("exc :::" + exc.Message);
                return null;
            }
        }
        /// <summary>
        /// Return the repository to the Promociones
        /// </summary>
        /// <returns></returns>
        public PromocionesRepositories GetPromocionesRepository()
        {
            try
            {
                string nombreNamespaceClaseAccesoDatos = ConfigurationManager.AppSettings["AccesoDatosBusiness"] + ".PromocionesRepositories";
                object instancia = Activator.CreateInstance(Type.GetType(nombreNamespaceClaseAccesoDatos));

                return instancia as PromocionesRepositories;
            }
            catch (Exception exc)
            {
                System.Console.WriteLine("exc :::" + exc.Message);
                return null;
            }
        }
        /// <summary>
        /// Return the repository to the Venta
        /// </summary>
        /// <returns></returns>
        public VentaRepositories GetVentaRepository()
        {
            try
            {
                string nombreNamespaceClaseAccesoDatos = ConfigurationManager.AppSettings["AccesoDatosBusiness"] + ".VentaRepositories";
                object instancia = Activator.CreateInstance(Type.GetType(nombreNamespaceClaseAccesoDatos));

                return instancia as VentaRepositories;
            }
            catch (Exception exc)
            {
                System.Console.WriteLine("exc :::" + exc.Message);
                return null;
            }
        }
    }
}
