using BLLTest.Facade;
using DALTest.Factory;
using DomainTest;
using ServicesTest.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLTest
{
    public class MateriaPrimaManager
    {
        #region Singleton
        private readonly static MateriaPrimaManager _instance = new MateriaPrimaManager();
        private FactoryDAL instancia;

        public static MateriaPrimaManager Current
        {
            get
            {
                return _instance;
            }
        }

        private MateriaPrimaManager()
        {
            instancia = FactoryDAL.Current;
        }
        #endregion


        public int RegistrarMateriaPrima(MateriaPrima materiaPrima)
        {
            return instancia.GetMateriaPrimaRepository().Insert(materiaPrima);
        }


        public IEnumerable<MateriaPrima> ListarMateriaPrimaFilters(string[] filtros)
        {
            IEnumerable<MateriaPrima> materiasPrimas = new List<MateriaPrima>();
            try
            {
                materiasPrimas = instancia.GetMateriaPrimaRepository().GetAll(filtros);
                return materiasPrimas.ToList();
            }
            catch (Exception ex) {
                FacadeServiceBusiness.ManageException(new DALException(ex));
                return materiasPrimas;
            }

        }

        public IEnumerable<MateriaPrima> ListarMateriaPrima()
        {
            IEnumerable<MateriaPrima> materiasPrimas = new List<MateriaPrima>();
            try
            {
                materiasPrimas = instancia.GetMateriaPrimaRepository().GetAll();
                return materiasPrimas.ToList();
            }
            catch (Exception ex)
            {
                FacadeServiceBusiness.ManageException(new DALException(ex));
                return materiasPrimas;
            }

        }



    }
}

