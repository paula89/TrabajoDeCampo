using BLLTest.Facade;
using DALTest.Factory;
using DomainTest;
using ServicesTest.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLTest.Managers
{
    /// <summary>
    /// this class manage the Venta
    /// </summary>
    public class VentaManager
    {
        #region Singleton
        private readonly static VentaManager _instance = new VentaManager();
        private FactoryDAL instancia;

        public static VentaManager Current
        {
            get
            {
                return _instance;
            }
        }

        private VentaManager()
        {
            instancia = FactoryDAL.Current;
        }
        #endregion

        /// <summary>
        /// save a Venta
        /// </summary>
        /// <param name="venta"></param>
        /// <returns></returns>
        public int RegistrarVenta(Venta venta)
        {
            return instancia.GetVentaRepository().Insert(venta);
        }

        /// <summary>
        /// Get the Venta by filters
        /// </summary>
        /// <param name="filtros"></param>
        /// <returns></returns>
        public IEnumerable<Venta> ListarVentaFilters(string[] filtros)
        {
            IEnumerable<Venta> venta = new List<Venta>();
            try
            {
                venta = instancia.GetVentaRepository().GetAll(filtros);
                return venta.ToList();
            }
            catch (Exception ex)
            {
                FacadeServiceBusiness.ManageException(new DALException(ex));
                return venta;
            }

        }
        /// <summary>
        /// get all the Venta
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Venta> ListarVentas()
        {
            IEnumerable<Venta> ventas = new List<Venta>();
            try
            {
                ventas = instancia.GetVentaRepository().GetAll();
                return ventas.ToList();
            }
            catch (Exception ex)
            {
                FacadeServiceBusiness.ManageException(new DALException(ex));
                return null;
            }

        }

    }
}
