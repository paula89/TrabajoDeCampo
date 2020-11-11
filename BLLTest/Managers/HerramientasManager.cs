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


        public int RegistrarHerramienta(Herramientas herramienta)
        {
            return instancia.GetHerramientasRepository().Insert(herramienta);
        }


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

