using ServicesTest.BLL;
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
        //Definir contratos....

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

    }
}
