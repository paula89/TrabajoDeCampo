using ServicesTest.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DalTest.Entity_framework;
using DALTest.Contracts;

namespace DALTest.Repositories.SQL
{
    /// <summary>
    /// this class implements the interface IGenericRepository to create the differents transactions to the Herramientas
    /// </summary>
    public class HerramientasRepositories: DALTest.Contracts.IGenericRepository<DomainTest.Herramientas>
    {
        /// <summary>
        /// Delete a Herramienta
        /// </summary>
        /// <param name="id"></param>
        public void Delete(Guid id)
        {
            using (TCEntitiesHerramientas db = new TCEntitiesHerramientas())
            {
                DalTest.Entity_framework.Herramientas herramienta = db.Herramientas.Find(id);
                db.Herramientas.Remove(herramienta);
            }
        }
        /// <summary>
        /// Return all the Herramientas 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<DomainTest.Herramientas> GetAll()
        {
            List<DomainTest.Herramientas> HerramientasList = new List<DomainTest.Herramientas>();

            using (TCEntitiesHerramientas db = new TCEntitiesHerramientas())
            {
                var tool = new DomainTest.Herramientas();
                var herramientas = db.Herramientas;
                foreach (var oHerramienta in herramientas)
                {
                    tool.IdHerramienta = new Guid(oHerramienta.IdHerramienta);
                    tool.nombre = oHerramienta.Nombre;
                    tool.proveedor = oHerramienta.Proveedor;
                    tool.habilitado = oHerramienta.Habilitado;
                    tool.marca = oHerramienta.Marca;
                    tool.tiempoDeUso = (float)oHerramienta.TiempoDeUso;
                    tool.cantidad = oHerramienta.Cantidad;
                    tool.comentario = oHerramienta.Comentario;
                    tool.fechaAlta = oHerramienta.FechaAlta;
                    HerramientasList.Add(tool);
                }

            }
            return HerramientasList;
        }
        /// <summary>
        /// return all the Herramientas by filters
        /// </summary>
        /// <param name="filtros"></param>
        /// <returns></returns>
        public IEnumerable<DomainTest.Herramientas> GetAll(Array filtros)
        {
            List<DomainTest.Herramientas> HerramientasList = new List<DomainTest.Herramientas>();

            using (TCEntitiesHerramientas db = new TCEntitiesHerramientas())
            {
                var tool = new DomainTest.Herramientas();
                var herramientas = db.Herramientas;
                foreach (var oHerramienta in herramientas)
                {
                    tool.IdHerramienta = new Guid(oHerramienta.IdHerramienta);
                    tool.nombre = oHerramienta.Nombre;
                    tool.proveedor = oHerramienta.Proveedor;
                    tool.habilitado = oHerramienta.Habilitado;
                    tool.marca = oHerramienta.Marca;
                    tool.tiempoDeUso = (float)oHerramienta.TiempoDeUso;
                    tool.cantidad = oHerramienta.Cantidad;
                    tool.comentario = oHerramienta.Comentario;
                    tool.fechaAlta = oHerramienta.FechaAlta;
                    HerramientasList.Add(tool);
                }

            }
            return HerramientasList;
        }

        /// <summary>
        /// insert a new Herramienta
        /// </summary>
        /// <param name="herramienta"></param>
        /// <returns></returns>
        public int Insert(DomainTest.Herramientas herramienta)
        {
            try
            {
                var tool = new DalTest.Entity_framework.Herramientas();
                using (TCEntitiesHerramientas db = new TCEntitiesHerramientas())
                {
                    tool.IdHerramienta = Convert.ToString(herramienta.IdHerramienta);
                    tool.Nombre = herramienta.nombre;
                    tool.Proveedor = herramienta.proveedor;
                    tool.Habilitado = true;
                    tool.Marca = herramienta.marca;
                    tool.TiempoDeUso = herramienta.tiempoDeUso;
                    tool.Cantidad = herramienta.cantidad;
                    tool.Comentario = herramienta.comentario;
                    tool.FechaAlta = herramienta.fechaAlta;
                    db.Herramientas.Add(tool);
                    db.SaveChanges();
                }
                return 1;
            }
            catch (Exception ex) {
                throw (new DALException(ex));
            }
        }
        /// <summary>
        /// update a Herramienta
        /// </summary>
        /// <param name="herramienta"></param>
        /// <returns></returns>
        public int Update(DomainTest.Herramientas herramienta)
        {
            using (TCEntitiesHerramientas db = new TCEntitiesHerramientas())
            {
                db.Entry(herramienta).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            return 1;
        }

        void IGenericRepository<DomainTest.Herramientas>.Update(DomainTest.Herramientas o)
        {
            throw new NotImplementedException();
        }
    }
}
