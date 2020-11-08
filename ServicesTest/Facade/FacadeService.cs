using ServicesTest.BLL;
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
        /// <summary>
        /// init the manage exceptions 
        /// </summary>
        /// <param name="ex"></param>
        public static void ManageException(Exception ex)
        {
            ExceptionManager.Current.Handle(ex);
        }
        /// <summary>
        /// write the traces
        /// </summary>
        /// <param name="message"></param>
        /// <param name="e"></param>
        public static void Write(string message, EventLevel e)
        {
            TraceManager.Current.Write(message, e);
        }
        /// <summary>
        /// translate a word or phrase
        /// </summary>
        /// <param name="cultureInfo"></param>
        /// <returns></returns>
        public static ResourceManager Translate(string cultureInfo)
        {
            return LanguageManager.Current.Translate(cultureInfo);
        }
        /// <summary>
        /// init a register backup
        /// </summary>
        public static void ManageBackup() 
        {
            BackupManager.Current.Registrar();
        }
        /// <summary>
        /// init the user update
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public static int ActualizarUsuario(Usuario usuario)
        {
            return UsersManager.Current.ActualizarUsuario(usuario);
        }
        /// <summary>
        /// register a user 
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public static int RegistrarUsuario(Usuario usuario) 
        {
            return UsersManager.Current.RegistrarUsuario(usuario);
        }

        public static void GetUsers() { 
        
        
        }

        /// <summary>
        /// init the register DVV
        /// </summary>
        /// <param name="DVV"></param>
        /// <returns></returns>
        public static int RegistrarDVV(decimal DVV) {
            return UsersManager.Current.RegistrarDVV(DVV);
        }

    }
}
