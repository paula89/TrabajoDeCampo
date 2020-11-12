using DALTest.Contracts;
using DALTest.DAL.Tools;
using DomainTest;
using ServicesTest.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALTest.Repositories.SQL
{
    /// <summary>
    /// this class implements the interface IGenericRepository to create the differents transactions to the Materia Prima
    /// </summary>
    public class MateriaPrimaRepositories : IGenericRepository<MateriaPrima>
    {

        #region Statements
        private string SelectAllStatement
        {
            get => "SELECT Nombre, Proveedor, Cantidad, Marca, Usuario, Comentario, FechaAlta, FechaVencimiento, Habilitada" +
                " FROM [dbo].[MateriaPrima]";
        }
        private string InsertStatement
        {
            get => "INSERT INTO [dbo].[MateriaPrima] (IdMateriaPrima, Nombre, Proveedor, Cantidad, Marca, Usuario, Comentario, FechaAlta, FechaVencimiento, Habilitada)" +
                " VALUES (@IdMateriaPrima, @Nombre, @Proveedor, @Cantidad, @Marca, @Usuario, @Comentario, @FechaAlta, @FechaVencimiento, @Habilitada)";
        }
        private string SelectFilterStatement
        {
            get => "SELECT * FROM [dbo].[MateriaPrima] " +
                "WHERE FechaVencimiento <= @FechaVencimiento ";
        }


        #endregion
        /// <summary>
        /// delete a MateriaPrima
        /// </summary>
        /// <param name="id"></param>
        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// insert a new MateriaPrima
        /// </summary>
        /// <param name="materiaPrima"></param>
        /// <returns></returns>
        public int Insert(MateriaPrima materiaPrima)
        {
            int inserted = SqlHelper.ExecuteNonQueryMateriaPrima(InsertStatement, System.Data.CommandType.Text, "business", materiaPrima);
            return inserted;
        }
        /// <summary>
        /// Retuen all the MateriaPrima by filters
        /// </summary>
        /// <param name="filtros"></param>
        /// <returns></returns>
        public IEnumerable<MateriaPrima> GetAll(Array filtros)
        {
            try
            {
                List<MateriaPrima> materiaPrimas = new List<MateriaPrima>();
                List<SqlParameter> parametros = new List<SqlParameter>();
                string statement = SelectFilterStatement;
                
                    parametros.Add(new SqlParameter("@FechaVencimiento", Convert.ToDateTime(filtros.GetValue(0))));
                    if (filtros.GetValue(1).ToString() != "")
                    {
                        parametros.Add(new SqlParameter("@Nombre", filtros.GetValue(1)));
                        statement = statement + "AND Nombre = @Nombre ";
                    //statement = statement + "AND Nombre LIKE '%@Nombre%'";
                }
                if (filtros.GetValue(2).ToString() != "")
                    {
                        parametros.Add(new SqlParameter("@Proveedor", filtros.GetValue(2)));
                        statement = statement + "AND Proveedor = @Proveedor";
                    // statement = statement + "AND Proveedor LIKE '%@Proveedor%'";

                }

                System.Console.WriteLine(statement);
                System.Console.WriteLine(parametros.ToArray().ToString());

                using (var dr = SqlHelper.ExecuteReader(statement, System.Data.CommandType.Text, "security", parametros.ToArray()))
                {
                    Object[] values = new Object[dr.FieldCount];
                    while (dr.Read())
                    {
                        dr.GetValues(values);
                        MateriaPrima materiaPrima = new MateriaPrima();
                        materiaPrima.IdMateriaPrima = new Guid(values[0].ToString());
                        materiaPrima.nombre = values[1].ToString();
                        materiaPrima.proveedor = values[2].ToString();
                        materiaPrima.cantidad = Convert.ToInt32(values[3]);
                        materiaPrima.marca = values[4].ToString();
                        materiaPrima.usuario = values[5].ToString();
                        materiaPrima.comentario = values[6].ToString();
                        materiaPrima.fechaAlta = Convert.ToDateTime(values[7].ToString());
                        materiaPrima.fechaVencimiento = Convert.ToDateTime(values[8].ToString());
                        materiaPrima.habilitada = Convert.ToBoolean(values[9]);
                        materiaPrimas.Add(materiaPrima);
                    }
                }
                return materiaPrimas;
            }
            catch (Exception ex)
            {
                throw(new DALException(ex));
            }
        }
    

        /// <summary>
        /// return all the materiaPrima
        /// </summary>
        /// <returns></returns>
        public List<MateriaPrima> GetAll()
        {
            try
            {
                List<MateriaPrima> materiaPrimas = new List<MateriaPrima>();
                string statement = SelectAllStatement;
                System.Console.WriteLine(statement);

                using (SqlDataReader dr = SqlHelper.ExecuteReader(statement, System.Data.CommandType.Text, "security"))
                {
                    Object[] values = new Object[dr.FieldCount];
                    while (dr.Read())
                    {
                        dr.GetValues(values);
                        MateriaPrima materiaPrima = new MateriaPrima();
                        //materiaPrima.IdMateriaPrima = new Guid(values[0].ToString());
                        materiaPrima.nombre = values[0].ToString();
                        materiaPrima.proveedor = values[1].ToString();
                        materiaPrima.cantidad = Convert.ToInt32(values[2]);
                        materiaPrima.marca = values[3].ToString();
                        materiaPrima.usuario = values[4].ToString();
                        materiaPrima.comentario = values[5].ToString();
                        materiaPrima.fechaAlta = Convert.ToDateTime(values[6].ToString());
                        materiaPrima.fechaVencimiento = Convert.ToDateTime(values[7].ToString());
                        materiaPrima.habilitada = Convert.ToBoolean(values[8]);
                        materiaPrimas.Add(materiaPrima);
                    }
                }
                
                return materiaPrimas;
            }
            catch (Exception ex)
            {
                throw (new DALException(ex));
            }
        }



     
        /// <summary>
        /// update a MateriaPrima
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public int Update(MateriaPrima o)
        {
            throw new NotImplementedException();
        }

        void IGenericRepository<MateriaPrima>.Update(MateriaPrima o)
        {
            throw new NotImplementedException();
        }
    }
}
