using ServicesTest.DAL.Factory;
using ServicesTest.Domain;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesTest.BLL
{
    public class BackupManager
    {
        #region Singleton
        private readonly static BackupManager _instance = new BackupManager();

        public static BackupManager Current
        {
            get
            {
                return _instance;
            }
        }

        private BackupManager()
        {
        }
        #endregion


        public void Registrar()
        {
            Backup backup = new Backup();
            FactoryDAL.Current.GetBackupRepository().Insert(backup);
        }

        public IEnumerable<Backup> ObtenerBackup()
        {
            return FactoryDAL.Current.GetBackupRepository().GetAll();
        }
    
}
}
