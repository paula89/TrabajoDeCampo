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
            bkpStringPath = bkpString + DateTime.Now + ".bak";
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
                catch (DALException ex)
                {
                    FacadeService.ManageException(ex);
                    Console.WriteLine("error ::: " + ex.Message);
                    return 0;
                }
            }
        }


        public static Int32 ExecuteNonQuery(String commandText,
           CommandType commandType, string connection, Backup parameters)
        {
            parameters.Fecha = DateTime.Now;
            parameters.Descripcion = "Backup automatico";
            parameters.Path = bkpString;


            using (var trxScope = new TransactionScope())
            {
                SqlConnection conn = getConnection(connection);

                try
                {
                    conn.Open();
                    var comm = new SqlCommand($"BACKUP DATABASE TCSecurity TO DISK ={bkpString}");
                    var resultado = comm.ExecuteNonQuery();
                    trxScope.Complete();

                }
                catch (DALException ex)
                {
                    FacadeService.ManageException(ex);
                    Console.WriteLine("error ::: " + ex.Message);
                    return 0;
                }


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
                catch (DALException ex)
                {
                    FacadeService.ManageException(ex);
                    Console.WriteLine("error ::: " + ex.Message);
                    return 0;
                }
            }
        }


        public static SqlConnection getConnection(string connection) {
            SqlConnection conn;
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
                    // When using CommandBehavior.CloseConnection, the connection will be closed when the 
                    // IDataReader is closed.
                    SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                    return reader;
                }
            }
            catch (DALException ex) {
                FacadeService.ManageException(ex);
                Console.WriteLine("error ::: " + ex.Message);
                return null;
            }
        }
    }
}
