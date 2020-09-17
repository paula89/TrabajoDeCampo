﻿using ServicesTest.BLL;
using ServicesTest.DAL.Repositories.SQL;
using ServicesTest.Domain.Composite;
using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace ServicesTest.Facade
{
    public static class FacadeService
    {

        public static void ManageException(Exception ex)
        {
            ExceptionManager.Current.Handle(ex);
        }

        public static void Write(string message, EventLevel e)
        {
            TraceManager.Current.Write(message, e);
        }

        public static ResourceManager Translate(string cultureInfo)
        {
            return LanguageManager.Current.Translate(cultureInfo);
        }

        public static void ManageBackup() 
        {
            BackupManager.Current.Registrar();
        }

        public static int RegistrarUsuario(Usuario usuario) 
        {
            return UsersManager.Current.RegistrarUsuario(usuario);
        }

        public static void GetUsers() { 
        
        
        }


        public static int RegistrarDVV(decimal DVV) {
            return UsersManager.Current.RegistrarDVV(DVV);
        }

    }
}
