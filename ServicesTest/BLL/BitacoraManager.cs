using ServicesTest.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServicesTest.DAL.Factory;

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
        }
        #endregion


        public void Registrar(Bitacora bitacora)
        {
            FactoryDAL.Current.GetBitacoraRepository().Insert(bitacora);
        }

        public IEnumerable<Bitacora> ObtenerBitacoras()
        {
            return FactoryDAL.Current.GetBitacoraRepository().GetAll();
        }
    }
}
