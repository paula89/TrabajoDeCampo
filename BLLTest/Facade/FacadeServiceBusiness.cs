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
    /// <summary>
    /// class that use the Facade pattern 
    /// </summary>
    public static class FacadeServiceBusiness
    {
        /// <summary>
        /// Manage the exceptions to create the Bitacora or messages user
        /// </summary>
        /// <param name="ex"></param>
        public static void ManageException(Exception ex)
        {
            ExceptionManager.Current.Handle(ex);
        }
        /// <summary>
        /// Write the Bitacora with the traces
        /// </summary>
        /// <param name="message"></param>
        /// <param name="e"></param>
        public static void Write(string message, EventLevel e)
        {
            TraceManager.Current.Write(message, e);
        }
        /// <summary>
        /// save the MateriaPrima
        /// </summary>
        /// <param name="materiaPrima"></param>
        /// <returns></returns>
        public static int RegistrarMateriaPrima(MateriaPrima materiaPrima)
        {
            return MateriaPrimaManager.Current.RegistrarMateriaPrima(materiaPrima);
        }
        /// <summary>
        /// save the Herramienta
        /// </summary>
        /// <param name="herramienta"></param>
        /// <returns></returns>
        public static int RegistrarHerramienta(Herramientas herramienta)
        {
            return HerramientasManager.Current.RegistrarHerramienta(herramienta);
        }
        /// <summary>
        /// save the Product
        /// </summary>
        /// <param name="producto"></param>
        /// <returns></returns>
        public static int RegistrarProducto(Producto producto)
        {
            return ProductoManager.Current.RegistrarProducto(producto);
        }
        /// <summary>
        /// Save the promotions
        /// </summary>
        /// <param name="promocion"></param>
        /// <returns></returns>
        public static int RegistrarPromocion(Promocion promocion)
        {
            return PromocionManager.Current.RegistrarPromocion(promocion);
        }
        /// <summary>
        /// save the Ventas
        /// </summary>
        /// <param name="venta"></param>
        /// <returns></returns>
        public static int RegistrarVenta(Venta venta)
        {
            return VentaManager.Current.RegistrarVenta(venta);
        }
        /// <summary>
        /// save a losses
        /// </summary>
        /// <param name="perdida"></param>
        /// <returns></returns>
        public static int RegistrarPerdida(Perdidas perdida)
        {
            return CalculosManager.Current.RegistrarPerdida(perdida);
        }
        /// <summary>
        /// save a budget
        /// </summary>
        /// <param name="presupuesto"></param>
        /// <returns></returns>
        public static int RegistrarPresupuesto(Presupuesto presupuesto)
        {
            return CalculosManager.Current.RegistrarPresupuesto(presupuesto);
        }
    }
}
