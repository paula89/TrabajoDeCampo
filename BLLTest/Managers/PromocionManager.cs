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
    /// this class manage the Promocion
    /// </summary>
   public  class PromocionManager
    {
        #region Singleton
        private readonly static PromocionManager _instance = new PromocionManager();
        private FactoryDAL instancia;

        public static PromocionManager Current
        {
            get
            {
                return _instance;
            }
        }

        private PromocionManager()
        {
            instancia = FactoryDAL.Current;
        }
        #endregion

        /// <summary>
        /// save a Promocion
        /// </summary>
        /// <param name="promocion"></param>
        /// <returns></returns>
        public int RegistrarPromocion(Promocion promocion)
        {
            return instancia.GetPromocionesRepository().Insert(promocion);
        }
        /// <summary>
        /// update a Promotion
        /// </summary>
        /// <param name="promocion"></param>
        /// <returns></returns>
        public int ActualizarPromocion(Promocion promocion)
        {
            try
            {
                instancia.GetPromocionesRepository().Update(promocion);
                return 1;
            }
            catch (Exception ex) {
                return 0;
            }
        }
        /// <summary>
        /// Get the Promocion by filters
        /// </summary>
        /// <param name="filtros"></param>
        /// <returns></returns>
        public IEnumerable<Promocion> ListarPromocionFilters(string[] filtros)
        {
            IEnumerable<Promocion> promociones = new List<Promocion>();
            try
            {
                promociones = instancia.GetPromocionesRepository().GetAll(filtros);
                return promociones.ToList();
            }
            catch (Exception ex)
            {
                FacadeServiceBusiness.ManageException(new DALException(ex));
                return promociones;
            }

        }
        /// <summary>
        /// Get all the Ventas
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Promocion> ListarVentas()
        {
            IEnumerable<Promocion> promociones = new List<Promocion>();
            try
            {
                promociones = instancia.GetPromocionesRepository().GetAll();
                return promociones.ToList();
            }
            catch (Exception ex)
            {
                FacadeServiceBusiness.ManageException(new DALException(ex));
                return null;
            }

        }


    }
}
