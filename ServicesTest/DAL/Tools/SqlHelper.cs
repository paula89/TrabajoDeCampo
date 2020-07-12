using ServicesTest.Domain;
using ServicesTest.Domain.Exceptions;
using ServicesTest.Facade;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ServicesTest.DAL.Tools
{
    internal static class SqlHelper
    {
        static string conString, segString, bkpString, bkpStringPath;
        static SqlHelper()
        {
            conString = ConfigurationManager.ConnectionStrings["MainConString"].ConnectionString;
            segString = ConfigurationManager.ConnectionStrings["SecurityConString"].ConnectionString;
            bkpString = ConfigurationManager.ConnectionStrings["BackupConnection"].ConnectionString;
            bkpStringPath = bkpString + "TC" + DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString()+DateTime.Now.Day.ToString() 
                + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + ".bak";
        }

        public static SqlConnection getConnection(string connection)
        {
            SqlConnection conn;
            try {
                if (connection.Contains("security"))
                {
                    conn = new SqlConnection(segString);
                }
                else
                {
                    conn = new SqlConnection(conString);
                }
                return conn;
            } 
            catch (Exception ex)
            {
                FacadeService.ManageException((DALException)ex);
                return null;
            }
        }

        // restore
        public static Int32 ExecuteNonQuery(String commandText,
            CommandType commandType, string connection, SqlParameter[] parameters)           
        {
            SqlConnection conn = getConnection(connection);
            int response = 0;
            try
            {
                SqlCommand cmd = new SqlCommand();
                CommandPrepare(cmd, conn, (SqlTransaction)null, commandType, commandText, parameters);
           
                response = cmd.ExecuteNonQuery();

                conn.Close();
                cmd.Dispose();

                return response;
            }
            catch (Exception ex)
            {
                FacadeService.ManageException((DALException)ex);
                return response;
            }
            
        }




        public static Int32 ExecuteNonQuery(String commandText,
            CommandType commandType, string connection, Bitacora parameters)
        {
            using (var trxScope = new TransactionScope())
            {
                SqlConnection conn = getConnection(connection);
                try
                {
                    conn.Open();
                    var comm = new SqlCommand(commandText);
                    comm.Connection = conn;

                    comm.Parameters.AddWithValue("Fecha", parameters.Fecha);
                    comm.Parameters.AddWithValue("Descripcion", parameters.Descripcion);
                    comm.Parameters.AddWithValue("Criticidad", Convert.ToString(parameters.Criticidad));
                    comm.Parameters.AddWithValue("Usuario", parameters.Usuario);

                    var resultado = comm.ExecuteNonQuery();
                    trxScope.Complete();

                    return resultado;
                }
                catch (Exception ex)
                {
                    FacadeService.ManageException((DALException)ex);
                    return 0;
                }
            }
        }

        public static Int32 ExecuteNonQuery(String commandText,
           CommandType commandType, string connection, Backup parameters)
        {
            SqlCommand cmd;
            SqlConnection conn = getConnection(connection);
            // crea el .bak
            try
            {
                cmd = new SqlCommand();
                List<SqlParameter> parametros = new List<SqlParameter>();
                parametros.Add(new SqlParameter("@ruta", @bkpStringPath));            
                CommandPrepare(cmd, conn, (SqlTransaction)null, CommandType.StoredProcedure, "dbo.spFull_Backup", parametros.ToArray());
            
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                cmd.Dispose();
                conn.Close();
            }
            catch (Exception ex)
            {
                FacadeService.ManageException((DALException)ex);
                return 0;
            }   

            // insert en la base con la ruta del .bak
            using (var trxScope = new TransactionScope())
            {
                parameters.Fecha = DateTime.Now;
                parameters.Descripcion = "Backup automatico";
                parameters.Path = bkpString;

                try
                {
                    conn.Open();
                    var comm = new SqlCommand(commandText);
                    comm.Connection = conn;

                    comm.Parameters.AddWithValue("Fecha", parameters.Fecha);
                    comm.Parameters.AddWithValue("Descripcion", parameters.Descripcion);
                    comm.Parameters.AddWithValue("Path", bkpStringPath);

                    var resultado = comm.ExecuteNonQuery();
                    trxScope.Complete();

                    return resultado;
                }
                catch (Exception ex)
                {
                    FacadeService.ManageException((DALException)ex);
                    return 0;
                }
            }
        }

        private static void CommandPrepare(SqlCommand command, SqlConnection connection, SqlTransaction transaction, 
            CommandType commandType, String commandText, SqlParameter[] commandParameters)
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
            command.Connection = connection;
            command.CommandText = commandText;
            command.Transaction = transaction;
            command.CommandType = commandType;

            if (commandParameters != null)
            {
                AddParams(command, commandParameters);
            }
            return;
        }

        private static void AddParams(SqlCommand command, SqlParameter[] commandParameters)
        {
            if (commandParameters != null)
            {
                foreach (SqlParameter parameter in commandParameters)
                {
                    if (parameter != null)
                    {
                        if ((parameter.Direction == ParameterDirection.InputOutput ||
                            parameter.Direction == ParameterDirection.Input) &&
                            (parameter.Value == null))
                        {
                            parameter.Value = DBNull.Value;
                        }
                        command.Parameters.Add(parameter);
                    }
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
                FacadeService.ManageException((DALException)ex);
                return null;
            }
        }
    }
}
