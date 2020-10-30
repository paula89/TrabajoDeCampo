using ServicesTest.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Transactions;
using System.Threading.Tasks;
using DomainTest;
using System.Reflection;

namespace DALTest.DAL.Tools
{
    internal static class SqlHelper
    {
        static string conString;
        static SqlHelper()
        {
            conString = ConfigurationManager.ConnectionStrings["MainConString"].ConnectionString;
            
        }

        public static SqlConnection getConnection(string connection)
        {
            SqlConnection conn;
            try {
               
                conn = new SqlConnection(conString);
                
                return conn;
            } 
            catch (Exception ex)
            {
                throw(new DALException(ex));
            }
        }

        
        public static Int32 ExecuteNonQueryMateriaPrima(String commandText,
            CommandType commandType, string connection, MateriaPrima parameters)
        {
            using (var trxScope = new TransactionScope())
            {
                try
                {
                    SqlConnection conn = getConnection(connection);
                    conn.Open();
                    var comm = new SqlCommand(commandText);
                    comm.Connection = conn;

                    PropertyInfo[] properties = InformarPropiedades(parameters);
                    String[] parametros = InformarParametros(parameters);
                    int i = 0;
                    foreach (PropertyInfo propiedad in properties)
                    {
                        comm.Parameters.AddWithValue(propiedad.Name, parametros[i]);
                        i++;
                    }
                    /*
                    comm.Parameters.AddWithValue("IdMateriaPrima", parameters.IdMateriaPrima);
                    comm.Parameters.AddWithValue("Nombre", parameters.nombre);
                    comm.Parameters.AddWithValue("Proveedor", parameters.proveedor);
                    comm.Parameters.AddWithValue("Cantidad", parameters.cantidad);
                    comm.Parameters.AddWithValue("Marca", parameters.marca);
                    comm.Parameters.AddWithValue("Usuario", parameters.usuario);
                    comm.Parameters.AddWithValue("Comentario", parameters.comentario);
                    comm.Parameters.AddWithValue("FechaAlta", parameters.fechaAlta);
                    comm.Parameters.AddWithValue("FechaVencimiento", parameters.vencimiento);*/
                    //comm.Parameters.AddWithValue("Habilitada", 1);
                    var resultado = comm.ExecuteNonQuery();
                    trxScope.Complete();

                    return resultado;
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine(ex.Message);
                    throw (new DALException(ex));
                }
            }
        }

        public static SqlDataReader ExecuteReader(String commandText,
            CommandType commandType, string connection, params SqlParameter[] parameters)
        {
            SqlConnection conn = getConnection(connection);
            try
            {
                using (SqlCommand cmd = new SqlCommand(commandText, conn))
                {
                    cmd.CommandType = commandType;
                    cmd.Parameters.AddRange(parameters);
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                    return reader;
                }
            }
            catch (Exception ex) {
                throw (new DALException(ex));
            }
        }
        public static string[] InformarParametros(object pObjeto) {
            var parametros = pObjeto.GetType()
                    .GetProperties()
                    .Select(p =>
                    {
                        object value = p.GetValue(pObjeto, null);
                        return value == null ? null : value.ToString();
                    })
                    .ToArray();
            return parametros;
        }

        public static PropertyInfo[] InformarPropiedades(object pObjeto)
        {
            Type tipo = pObjeto.GetType();
            PropertyInfo[] propiedades = tipo.GetProperties();
            return propiedades;
        }

    }
}
