using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Tracing;
using ServicesTest.BLL;
using DomainTest;
using BLLTest.Managers;

namespace BLLTest.Facade
{
    public static class FacadeServiceBusiness
    {
        public static void ManageException(Exception ex)
        {
            ExceptionManager.Current.Handle(ex);
        }

        public static void Write(string message, EventLevel e)
        {
            TraceManager.Current.Write(message, e);
        }
        public static int RegistrarMateriaPrima(MateriaPrima materiaPrima)
        {
            return MateriaPrimaManager.Current.RegistrarMateriaPrima(materiaPrima);
        }

        public static int RegistrarHerramienta(Herramientas herramienta)
        {
            return HerramientasManager.Current.RegistrarHerramienta(herramienta);
        }
    }
}
