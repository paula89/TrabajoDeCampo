using BLLTest.Facade;
using DALTest.Factory;
using DomainTest;
using ServicesTest.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLTest.Managers
{
    /// <summary>
    /// this class manage the Producto
    /// </summary>
    public class ProductoManager
    {
        #region Singleton
        private readonly static ProductoManager _instance = new ProductoManager();
        private FactoryDAL instancia;

        public static ProductoManager Current
        {
            get
            {
                return _instance;
            }
        }

        private ProductoManager()
        {
            instancia = FactoryDAL.Current;
        }
        #endregion

        /// <summary>
        /// save a Producto
        /// </summary>
        /// <param name="producto"></param>
        /// <returns></returns>
        public int RegistrarProducto(Producto producto)
        {
            return instancia.GetProductosRepository().Insert(producto);
        }

        /// <summary>
        /// get the Productos by filters
        /// </summary>
        /// <param name="filtros"></param>
        /// <returns></returns>
        public IEnumerable<Producto> ListarProductosFilters(string[] filtros)
        {
            IEnumerable<Producto> producto = new List<Producto>();
            try
            {
                producto = instancia.GetProductosRepository().GetAll(filtros);
                return producto.ToList();
            }
            catch (Exception ex)
            {
                FacadeServiceBusiness.ManageException(new DALException(ex));
                return producto;
            }

        }
        /// <summary>
        /// get all the Productos
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Producto> ListarProductos()
        {
            IEnumerable<Producto> productos = new List<Producto>();
            try
            {
                productos = instancia.GetProductosRepository().GetAll();
                return productos.ToList();
            }
            catch (Exception ex)
            {
                FacadeServiceBusiness.ManageException(new DALException(ex));
                return null;
            }

        }


    }
}
