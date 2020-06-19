using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using DAL.Factory;
using Domain;

namespace Services.BLL
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
                DAL.Factory.FactoryDAL.Current.GetBitacoraRepository();// = new DAL.BitacoraDAL();
                                                                       //  return bitaDAL.Registrar(bitacora);
            }

            public IEnumerable<Bitacora> ObtenerBitacoras()
            {
                var repo =  FactoryDAL.Current.GetBitacoraRepository();
            return repo.GetAll();
            }
        }
    
}
