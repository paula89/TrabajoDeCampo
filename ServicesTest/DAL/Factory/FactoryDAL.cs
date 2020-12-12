using ServicesTest.DAL.Contracts;
using ServicesTest.DAL.Repositories.SQL;
using ServicesTest.Domain;
using System;
using System.Configuration;
using System.Windows;

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
        /// <summary>
        /// get the bitacora's path repository
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// return the file path with the tranlations
        /// </summary>
        /// <returns></returns>
        public string GetTranslateRepository() {
            try
            {
                string language = System.IO.Directory.GetCurrentDirectory() + @"\idiomas";
                //string language = ConfigurationManager.ConnectionStrings["languages"].ConnectionString;
                              
                return language;
            }
            catch (Exception exc)
            {
                System.Console.WriteLine("exc :::" + exc.Message);
                return null;
            }
        }
        /// <summary>
        /// get the backup's path repository
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// get the backup's restore repository
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// get the users path repository
        /// </summary>
        /// <returns></returns>
        public UsersRepository GetUsersRepository() {
            string nombreNamespaceClaseAccesoDatos = ConfigurationManager.AppSettings["AccesoDatos"] + ".UsersRepository";
            object instancia = Activator.CreateInstance(Type.GetType(nombreNamespaceClaseAccesoDatos));

            return instancia as UsersRepository;
        }
        /// <summary>
        /// get the tracking's path repository
        /// </summary>
        /// <returns></returns>
        public TrackingRepository GetTrackingRepository()
        {
            string nombreNamespaceClaseAccesoDatos = ConfigurationManager.AppSettings["AccesoDatos"] + ".TrackingRepository";
            object instancia = Activator.CreateInstance(Type.GetType(nombreNamespaceClaseAccesoDatos));

            return instancia as TrackingRepository;
        }


    }
}
