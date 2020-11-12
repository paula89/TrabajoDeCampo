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
    /// this class manage the differents calculations
    /// </summary>
    public class CalculosManager
    {
        #region Singleton
        private readonly static CalculosManager _instance = new CalculosManager();
        private FactoryDAL instancia;

        public static CalculosManager Current
        {
            get
            {
                return _instance;
            }
        }

        private CalculosManager()
        {
            instancia = FactoryDAL.Current;
        }
        #endregion

        /// <summary>
        /// save a budget
        /// </summary>
        /// <param name="presupuesto"></param>
        /// <returns></returns>
        public int RegistrarPresupuesto(Presupuesto presupuesto)
        {
            return instancia.GetCalculoPresupuestoRepository().Insert(presupuesto);
        }
        /// <summary>
        /// get all the budget by filters
        /// </summary>
        /// <param name="filtros"></param>
        /// <returns></returns>

        public IEnumerable<Presupuesto> ListarpresupuestosFilters(string[] filtros)
        {
            IEnumerable<Presupuesto> presupuestos = new List<Presupuesto>();
            try
            {
                presupuestos = instancia.GetCalculoPresupuestoRepository().GetAll(filtros);
                return presupuestos.ToList();
            }
            catch (Exception ex)
            {
                FacadeServiceBusiness.ManageException(new DALException(ex));
                return presupuestos;
            }

        }
        /// <summary>
        /// get all the budget
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Presupuesto> ListarPresupuesto()
        {
            IEnumerable<Presupuesto> presupuestos = new List<Presupuesto>();
            try
            {
                presupuestos = instancia.GetCalculoPresupuestoRepository().GetAll();
                return presupuestos.ToList();
            }
            catch (Exception ex)
            {
                FacadeServiceBusiness.ManageException(new DALException(ex));
                return null;
            }

        }
        /// <summary>
        /// save the losses
        /// </summary>
        /// <param name="perdida"></param>
        /// <returns></returns>
        public int RegistrarPerdida(Perdidas perdida)
        {
            return instancia.GetCalculoPerdidasRepository().Insert(perdida);
        }

        /// <summary>
        /// get the losses by filters
        /// </summary>
        /// <param name="filtros"></param>
        /// <returns></returns>
        public IEnumerable<Perdidas> ListarPerdidasFilters(string[] filtros)
        {
            IEnumerable<Perdidas> perdidas = new List<Perdidas>();
            try
            {
                perdidas = instancia.GetCalculoPerdidasRepository().GetAll(filtros);
                return perdidas.ToList();
            }
            catch (Exception ex)
            {
                FacadeServiceBusiness.ManageException(new DALException(ex));
                return perdidas;
            }

        }
        /// <summary>
        /// get all the losses
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Perdidas> ListarPerdidas()
        {
            IEnumerable<Perdidas> perdidas = new List<Perdidas>();
            try
            {
                perdidas = instancia.GetCalculoPerdidasRepository().GetAll();
                return perdidas.ToList();
            }
            catch (Exception ex)
            {
                FacadeServiceBusiness.ManageException(new DALException(ex));
                return null;
            }

        }

    }
}
