using DALTest.Contracts;
using DALTest.DAL.Tools;
using DomainTest;
using ServicesTest.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALTest.Repositories.SQL
{
    public class MateriaPrimaRepositories : IGenericRepository<MateriaPrima>
    {

        #region Statements
        private string SelectAllStatement
        {
            get => "SELECT * FROM [dbo].[MateriaPrima]";
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

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public int Insert(MateriaPrima materiaPrima)
        {
            int inserted = SqlHelper.ExecuteNonQueryMateriaPrima(InsertStatement, System.Data.CommandType.Text, "business", materiaPrima);
            return inserted;
        }

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
                        parametros.Add(new SqlParameter("@Nombre", filtros.GetValue(0)));
                        statement = statement + "AND Nombre LIKE '%@Nombre%'";
                    }
                    if (filtros.GetValue(2).ToString() != "")
                    {
                        parametros.Add(new SqlParameter("@Proveedor", filtros.GetValue(0)));
                        statement = statement + "AND Proveedor LIKE '%@Proveedor%'";
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
                        materiaPrima.vencimiento = Convert.ToDateTime(values[8].ToString());
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
    


        public IEnumerable<MateriaPrima> GetAll()
        {
            try
            {
                List<MateriaPrima> materiaPrimas = new List<MateriaPrima>();
                string statement = SelectAllStatement;               

                System.Console.WriteLine(statement);

                using (var dr = SqlHelper.ExecuteReader(statement, System.Data.CommandType.Text, "security"))
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
                        materiaPrima.vencimiento = Convert.ToDateTime(values[8].ToString());
                        materiaPrima.habilitada = Convert.ToBoolean(values[9]);
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



     

        public void Update(MateriaPrima o)
        {
            throw new NotImplementedException();
        }
    }
}
