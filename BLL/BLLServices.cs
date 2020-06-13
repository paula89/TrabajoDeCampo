using DAL.i18n;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Resources;
using System.Text;

namespace BLL
{
    // FACADE
    public static class BLLServices
    
        {
            //Definir contratos....

            public static void ManageException(Exception ex)
            {
                //ExceptionManager.Current.Handle(ex);
            }

             
        /*
        public static ResourceManager Translate(string cultureInfo)
            {
                return LanguageManager.Current.Translate(cultureInfo);
            }
        */

        }
    
}
