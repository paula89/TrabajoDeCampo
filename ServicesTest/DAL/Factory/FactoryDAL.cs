using ServicesTest.DAL.Contracts;
using ServicesTest.DAL.Repositories.SQL;
using ServicesTest.Domain;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesTest.DAL.Factory
{
    public class FactoryDAL
    {
        #region Singleton

        private readonly static FactoryDAL instance = new FactoryDAL();

        public static FactoryDAL Current
        {
            get
            {
                return instance;
            }
        }

        private FactoryDAL()
        {
            //Implement here the initialization code
        }
#endregion

        public IGenericRepository<Bitacora> GetBitacoraRepository()
        {
            try
            {
                string nombreNamespaceClaseAccesoDatos = ConfigurationManager.AppSettings["AccesoDatos"] + ".BitacoraRepository";
                object instancia = Activator.CreateInstance(Type.GetType(nombreNamespaceClaseAccesoDatos));

                return instancia as IGenericRepository<Bitacora>;
            }
            catch (Exception exc)
            {
                System.Console.WriteLine("exc :::" + exc.Message);
                return null;
            }
        }

               public IGenericRepository<Backup> GetBackupRepository() {
            try {
                string nombreNamespaceClaseAccesoDatos = ConfigurationManager.AppSettings["AccesoDatos"] + ".BackupRepository";
                object instancia = Activator.CreateInstance(Type.GetType(nombreNamespaceClaseAccesoDatos));

                return instancia as IGenericRepository<Backup>;
                
            }
            catch (Exception ex) {
                System.Console.WriteLine("exc :::" + ex.Message);
                return null;
            }
        
        }

        public BackupRepository GetBackupRestoreRepository()
        {
            try
            {
                string nombreNamespaceClaseAccesoDatos = ConfigurationManager.AppSettings["AccesoDatos"] + ".BackupRepository";
                object instancia = Activator.CreateInstance(Type.GetType(nombreNamespaceClaseAccesoDatos));

                return instancia as BackupRepository;

            }
            catch (Exception ex)
            {
                System.Console.WriteLine("exc :::" + ex.Message);
                return null;
            }

        }

        public UsersRepository GetUsersRepository() {
            string nombreNamespaceClaseAccesoDatos = ConfigurationManager.AppSettings["AccesoDatos"] + ".UsersRepository";
            object instancia = Activator.CreateInstance(Type.GetType(nombreNamespaceClaseAccesoDatos));

            return instancia as UsersRepository;
        }
        public TrackingRepository GetTrackingRepository()
        {
            string nombreNamespaceClaseAccesoDatos = ConfigurationManager.AppSettings["AccesoDatos"] + ".TrackingRepository";
            object instancia = Activator.CreateInstance(Type.GetType(nombreNamespaceClaseAccesoDatos));

            return instancia as TrackingRepository;
        }


    }
}
