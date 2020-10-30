using ServicesTest.Domain;
using ServicesTest.Domain.Composite;
using ServicesTest.Domain.Exceptions;
using ServicesTest.Facade;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace ServicesTest.DAL.Tools
{
    internal static class SqlHelper
    {
        static string conString, segString, bkpString, bkpStringPath;
        static BinaryFormatter _formateadorBinario = new BinaryFormatter();

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
                FacadeService.ManageException(new DALException(ex));
                return null;
            }
        }

        // restore
        public static Int32 ExecuteNonQueryRestore(String commandText,
            CommandType commandType, string connection, SqlParameter[] parameters)           
        {
            SqlConnection conn = getConnection(connection);
            int response = 0;

            try
            {
                SqlCommand cmd = new SqlCommand();

                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = commandText;
                cmd.CommandType = commandType;
                cmd.Parameters.Add(new SqlParameter("@ruta", @bkpStringPath));
           
                response = cmd.ExecuteNonQuery();

                conn.Close();
                cmd.Dispose();

                return response;
            }
            catch (Exception ex)
            {
                FacadeService.ManageException(new DALException(ex));
                return response;
            }
            
        }
        public static Int32 ExecuteNonQueryUpdateUser(String commandText,
            CommandType commandType, string connection, Usuario parameters)
        {
            SqlConnection conn = getConnection(connection);
            int response = 0;

            try
            {
                SqlCommand cmd = new SqlCommand();

                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = commandText;
                cmd.CommandType = commandType;
                cmd.Parameters.Add(new SqlParameter("@Nombre", parameters.Nombre));
                cmd.Parameters.Add(new SqlParameter("@Apellido", parameters.Apellido));
                cmd.Parameters.Add(new SqlParameter("@Direccion", parameters.Direccion));
                cmd.Parameters.Add(new SqlParameter("@Telefono", parameters.Telefono));
                cmd.Parameters.Add(new SqlParameter("@Email", parameters.Email));
                cmd.Parameters.Add(new SqlParameter("@Contraseña", parameters.Password));
                cmd.Parameters.Add(new SqlParameter("@Hablitado", Convert.ToByte(parameters.Habilitado)));
                cmd.Parameters.Add(new SqlParameter("@DVH", parameters.DVH));
                cmd.Parameters.Add(new SqlParameter("@Usuario", parameters.Cod_Usuario));

                String permiso = "";
                foreach (var item in parameters.Permisos)
                {
                    permiso = permiso + item.Nombre + " ";
                }
                cmd.Parameters.AddWithValue("Permisos", permiso);



                response = cmd.ExecuteNonQuery();

                conn.Close();
                cmd.Dispose();

                return response;
            }
            catch (Exception ex)
            {
                FacadeService.ManageException(new DALException(ex));
                return response;
            }

        }
        public static Int32 ExecuteNonQueryUpdateDVV(String commandText,
            CommandType commandType, string connection, string parameters)
        {
            SqlConnection conn = getConnection(connection);
            int response = 0;

            try
            {
                SqlCommand cmd = new SqlCommand();

                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = commandText;
                cmd.CommandType = commandType;
                cmd.Parameters.Add(new SqlParameter("@DVV", parameters));

                response = cmd.ExecuteNonQuery();

                conn.Close();
                cmd.Dispose();

                return response;
            }
            catch (Exception ex)
            {
                FacadeService.ManageException(new DALException(ex));
                return response;
            }

        }


        public static Int32 ExecuteNonQueryUsers(String commandText,
            CommandType commandType, string connection, Usuario parameters)
        {
            using (var trxScope = new TransactionScope())
            {
                SqlConnection conn = getConnection(connection);
                try
                {
                    conn.Open();
                    var comm = new SqlCommand(commandText);
                    comm.Connection = conn;

                    comm.Parameters.AddWithValue("Usuario", parameters.Cod_Usuario);
                    comm.Parameters.AddWithValue("Nombre", parameters.Nombre);
                    comm.Parameters.AddWithValue("Apellido", parameters.Apellido);
                    comm.Parameters.AddWithValue("Direccion", parameters.Direccion);
                    comm.Parameters.AddWithValue("Telefono", parameters.Telefono);
                    comm.Parameters.AddWithValue("Email", parameters.Email);
                    comm.Parameters.AddWithValue("Contraseña", parameters.Password);
                    comm.Parameters.AddWithValue("FechaAlta", parameters.FechaAlta);
                    comm.Parameters.AddWithValue("Habilitado", 1);
                    comm.Parameters.AddWithValue("DVH", parameters.DVH);
                    comm.Parameters.AddWithValue("Idioma", parameters.Idioma);

                    String permiso = "";
                    foreach (var item in parameters.Permisos)
                    {
                        permiso = permiso + item.Nombre + " ";
                    }                    
                    comm.Parameters.AddWithValue("Permisos", permiso);

                    var resultado = comm.ExecuteNonQuery();
                    trxScope.Complete();

                    return resultado;
                }
                catch (Exception ex)
                {
                    FacadeService.ManageException(new DALException(ex));
                    return 0;
                }

            }
        }

        public static Int32 ExecuteNonQueryBitacora(String commandText,
            CommandType commandType, string connection, Bitacora parameters)
        {
            /*if (Convert.ToString(parameters.Criticidad) == "Mayor") {
                parameters.Descripcion = Serializar<string>(parameters.Descripcion.Substring(0, 512));

            } */
            using (var trxScope = new TransactionScope())
            {
                SqlConnection conn = getConnection(connection);
                try
                {
                    conn.Open();
                    var comm = new SqlCommand(commandText);
                    comm.Connection = conn;

                    comm.Parameters.AddWithValue("Fecha", parameters.Fecha);
                    comm.Parameters.AddWithValue("Descripcion", parameters.Descripcion.Substring(0,512));
                    comm.Parameters.AddWithValue("Criticidad", Convert.ToString(parameters.Criticidad));
                    comm.Parameters.AddWithValue("Usuario", parameters.Usuario);

                    var resultado = comm.ExecuteNonQuery();
                    trxScope.Complete();

                    return resultado;
                }
                catch (Exception ex)
                {
                    FacadeService.ManageException(new DALException(ex));
                    return 0;
                }
            }
        }
        // do backup
        public static Int32 ExecuteNonQueryBackup(String commandText,
           CommandType commandType, string connection, Backup parameters)
        {
            SqlCommand cmd;
            SqlConnection conn = getConnection(connection);
            // crea el .bak
            try
            {
                conn.Open();
                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "dbo.spFull_Backup";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ruta", @bkpStringPath));

                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                cmd.Dispose();
                conn.Close();

                //////////  AGREGAR EL BACKUP DE SECURITY
            }
            catch (Exception ex)
            {
                FacadeService.ManageException(new DALException(ex));
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
                    Console.WriteLine(ex);
                    FacadeService.ManageException(new DALException(ex));
                    return 0;
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
                FacadeService.ManageException(new DALException(ex));
                return null;
            }
        }
    }
}
