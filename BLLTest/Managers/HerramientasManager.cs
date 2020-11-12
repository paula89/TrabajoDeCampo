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
    /// this class manage the Herramientas
    /// </summary>
    public class HerramientasManager
    {
        #region Singleton
        private readonly static HerramientasManager _instance = new HerramientasManager();
        private FactoryDAL instancia;

        public static HerramientasManager Current
        {
            get
            {
                return _instance;
            }
        }

        private HerramientasManager()
        {
            instancia = FactoryDAL.Current;
        }
        #endregion

        /// <summary>
        /// save the Herramientas
        /// </summary>
        /// <param name="herramienta"></param>
        /// <returns></returns>
        public int RegistrarHerramienta(Herramientas herramienta)
        {
            return instancia.GetHerramientasRepository().Insert(herramienta);
        }
        /// <summary>
        /// update the Herramientas
        /// </summary>
        /// <param name="herramienta"></param>
        /// <returns></returns>
        public int ActualizarHerramienta(Herramientas herramienta)
        {
            return instancia.GetHerramientasRepository().Update(herramienta);
        }
        /// <summary>
        /// get the Herramientas by filters
        /// </summary>
        /// <param name="filtros"></param>
        /// <returns></returns>
        public IEnumerable<Herramientas> ListarHerramientaFilters(string[] filtros)
        {
            IEnumerable<Herramientas> herramientas = new List<Herramientas>();
            try
            {
                herramientas = instancia.GetHerramientasRepository().GetAll(filtros);
                return herramientas.ToList();
            }
            catch (Exception ex)
            {
                FacadeServiceBusiness.ManageException(new DALException(ex));
                return herramientas;
            }

        }
        /// <summary>
        /// get all the Herramientas
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Herramientas> ListarHerramientas()
        {
            IEnumerable<Herramientas> herramientas = new List<Herramientas>();
            try
            {
                herramientas = instancia.GetHerramientasRepository().GetAll();
                return herramientas.ToList();
            }
            catch (Exception ex)
            {
                FacadeServiceBusiness.ManageException(new DALException(ex));
                return null;
            }

        }



    }
}

