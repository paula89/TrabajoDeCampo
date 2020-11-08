using ServicesTest.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServicesTest.DAL.Factory;
using ServicesTest.DAL.Repositories.File;

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

        /// <summary>
        /// this method insert a new row in the bitacora
        /// </summary>
        /// <param name="bitacora"></param>
        public void Registrar(Bitacora bitacora)
        {
            FactoryDAL.Current.GetBitacoraRepository().Insert(bitacora);
        }
        /// <summary>
        /// this function get all the rows about bitacora 
        /// </summary>
        /// <param name="filtros"></param>
        /// <returns></returns>
        public IEnumerable<Bitacora> ObtenerBitacoras(string[] filtros)
        {
            return FactoryDAL.Current.GetBitacoraRepository().GetAll(filtros);
        }
        /// <summary>
        /// This function return all the rows in the bitacora file
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Bitacora> ObtenerBitacorasFile()
        {
            return BitacoraSerialization.GetBitacora();
        }
    }
}
