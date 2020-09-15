﻿using ServicesTest.DAL.Factory;
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
        private FactoryDAL instancia;

        public static BackupManager Current
        {
            get
            {
                return _instance;
            }
        }

        private BackupManager()
        {
            instancia = FactoryDAL.Current;
        }
        #endregion


        public void Registrar()
        {
            Backup backup = new Backup();
            instancia.GetBackupRepository().Insert(backup);
        }

        public IEnumerable<Backup> ObtenerBackup(string[] filtros)
        {
            return instancia.GetBackupRepository().GetAll(filtros);
        }

        public int RestaurarBackup(string path) {
            return instancia.GetBackupRestoreRepository().RestoreBackup(path);
        }
    
}
}
