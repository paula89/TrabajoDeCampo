using DomainTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesTest.BLL
{
    public class BitacoraManager
    {


        #region Singleton
        private readonly static BitacoraManager _instance = new BitacoraManager();

        public static BitacoraManager Current
        {
            get
            {
                return _instance;
            }
        }

        private BitacoraManager()
        {
            //Implement here the initialization code
        }
        #endregion


        public void Registrar(Bitacora bitacora)
        {
            DalTest.Factory.FactoryDAL.Current.GetBitacoraRepository();// = new DAL.BitacoraDAL();
                                                               //  return .Registrar(bitacora);
        }

        public IEnumerable<Bitacora> ObtenerBitacoras()
        {
            return DalTest.Factory.FactoryDAL.Current.GetBitacoraRepository().GetAll();
        }
    }
}
