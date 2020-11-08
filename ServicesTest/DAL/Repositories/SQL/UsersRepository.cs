using ServicesTest.DAL.Contracts;
using ServicesTest.DAL.Tools;
using ServicesTest.Domain.Composite;
using ServicesTest.Domain.Exceptions;
using ServicesTest.Facade;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesTest.DAL.Repositories.SQL
{
    public class UsersRepository : IGenericRepository<Usuario>
    {
        #region Statements
        private string SelectAllStatement
        {
            get => "SELECT Usuario, Nombre, Apellido, Direccion, Telefono, Email, Permisos, FechaAlta, Habilitado, Idioma " +
                "FROM [dbo].[Usuarios]";
        }
        private string SelectAllDVHStatement
        {
            get => "SELECT Usuario, Nombre,FechaAlta, DVH " +
                "FROM [dbo].[Usuarios]";
        }
        private string InsertStatement
        {
            get => "INSERT INTO [dbo].[Usuarios] (Usuario, Nombre, Apellido, Direccion, Telefono, Email, Contraseña, Permisos, FechaAlta, Habilitado, DVH, Idioma)" +
                " VALUES (@Usuario, @Nombre, @Apellido, @Direccion, @Telefono, @Email, @Contraseña, @Permisos, @FechaAlta, @Habilitado, @DVH, @Idioma)";
        }
        private string UpdateUserStatement
        {
            get => "UPDATE [dbo].[Usuarios] " +
                "SET Nombre = @Nombre, " +
                "Apellido = @Apellido, " +
                "Direccion = @Direccion, " +
                "Telefono = @Telefono, " +
                "Email = @Email, " +
                "Contraseña = @Contraseña, " +
                "Permisos = @Permisos, " +
                "Habilitado = @Hablitado, " +
                "DVH = @DVH " +
                "WHERE Usuario = @Usuario";
        }
        private string LoginSelectStatement
        {
            get => "SELECT Usuario, Nombre, Permisos, FechaAlta, DVH, Idioma FROM [dbo].[Usuarios] " +
                "WHERE Usuario = @Usuario " +
                "AND Contraseña = @Contraseña " +
                "AND Habilitado = 1";
        }

        private string LoginSelectFilterStatement
        {
            get => "SELECT Usuario, Nombre, Apellido, Direccion, Telefono, Email, Permisos, FechaAlta, Habilitado, DVH, Contraseña" +
                " FROM [dbo].[Usuarios] " +
                "WHERE Usuario = @Usuario ";
        }

        private string SelectFilterStatement
        {
            get => "SELECT Usuario, Nombre, Apellido, Direccion, Telefono, Email, Permisos, FechaAlta, Habilitado, DVH, Contraseña" +
                " FROM [dbo].[Usuarios] " +
                "WHERE FechaAlta >= @FechaAltaDesde " +
                "AND FechaAlta <= @FechaAltaHasta ";                
        }


        private string SelectRolesStatement {
            get => "Select * FROM [dbo].[Roles]";  // id, roles
        }
        private string SelectConfigurationStatement
        {
            get => "Select Value FROM [dbo].[Configuracion] where Clave = @Clave";  
        }

        private string UpdateDVVStatement {
            get => "UPDATE [dbo].[Configuracion] " +
                "SET Value = @DVV " +
                "WHERE Clave = 'DVV'";
        }

        #endregion

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// get all the languages
        /// </summary>
        /// <returns></returns>
        public IEnumerable<String> GetAllIdiomas()
        {
            try
            {
                List<String> idiomas = new List<String>();
                List<SqlParameter> parametros = new List<SqlParameter>();
                parametros.Add(new SqlParameter("@Clave", "Idioma"));

                using (var dr = SqlHelper.ExecuteReader(SelectConfigurationStatement, System.Data.CommandType.Text, "security", parametros.ToArray()))
                {
                    Object[] values = new Object[dr.FieldCount];

                    while (dr.Read())
                    {
                        dr.GetValues(values);
                        String idioma = values[0].ToString();

                        idiomas.Add(idioma);
                    }
                }

                return idiomas;
            }
            catch (Exception ex)
            {

                FacadeService.ManageException(new DALException(ex));
                return null;
            }

        }
        /// <summary>
        /// get all roles
        /// </summary>
        /// <returns></returns>
        public IEnumerable<String> GetAllRoles() {
            try { 
                List<String> roles = new List<String>();

                using (var dr = SqlHelper.ExecuteReader(SelectRolesStatement, System.Data.CommandType.Text, "security"))
                {
                    Object[] values = new Object[dr.FieldCount];

                    while (dr.Read())
                    {
                        dr.GetValues(values);
                        String nombreRol = values[1].ToString();
                        
                        roles.Add(nombreRol);
                    }
                }

                return roles;
            }
            catch (Exception ex)
            {

                FacadeService.ManageException(new DALException(ex));
                return null;
            }

        }

        /// <summary>
        /// get the DVV
        /// </summary>
        /// <returns></returns>
        public decimal GetDVV() {

            try
            {
                decimal dvv = 0;
                List<SqlParameter> parametros = new List<SqlParameter>();
                parametros.Add(new SqlParameter("@Clave", "DVV"));

                using (var dr = SqlHelper.ExecuteReader(SelectConfigurationStatement, System.Data.CommandType.Text, "security", parametros.ToArray()))
                {
                    Object[] values = new Object[dr.FieldCount];
                    while (dr.Read())
                    {
                        dr.GetValues(values);
                        dvv =  Convert.ToDecimal(values[0]);

                    }
                }

                return dvv;
            }
            catch (Exception ex)
            {
                FacadeService.ManageException(new DALException(ex));
                return 0;
            }
        }


        /// <summary>
        ///  Verify user login and if exist respond with the data about it
        /// </summary>
        /// <param name="filtros"></param>
        /// <returns></returns>
        public IEnumerable<Usuario> GetLogin(Array filtros)
        {

            try
            {
                List<SqlParameter> parametros = new List<SqlParameter>();
                List<Usuario> usuarios = new List<Usuario>();

                parametros.Add(new SqlParameter("@Usuario", filtros.GetValue(0)));
                parametros.Add(new SqlParameter("@Contraseña", filtros.GetValue(1)));
                System.Console.WriteLine(LoginSelectStatement);
                System.Console.WriteLine(parametros.ToArray().ToString());

                using (var dr = SqlHelper.ExecuteReader(LoginSelectStatement, System.Data.CommandType.Text, "security", parametros.ToArray()))
                {
                    Object[] values = new Object[dr.FieldCount];
                    Usuario usuario = new Usuario();
                    while (dr.Read())
                    {
                        dr.GetValues(values);
                        usuario.Cod_Usuario = values[0].ToString();
                        usuario.Nombre = values[1].ToString();
                        Patente permisoUsuario = new Patente();
                        Familia familia = new Familia();
                        permisoUsuario.Nombre = values[2].ToString();
                        familia.Permisos.Add(permisoUsuario);
                        usuario.Permisos.Add(familia);
                        usuario.FechaAlta = Convert.ToDateTime(values[3].ToString());
                        usuario.DVH = Convert.ToDecimal(values[4].ToString());
                        usuario.Idioma = values[5].ToString();
                        usuarios.Add(usuario);
                    }
                }

                return usuarios;
            }
            catch (Exception ex)
            {
                FacadeService.ManageException(new DALException(ex));
                return null;
            }
        }

        /// <summary>
        /// cycle permissions in the composite pattern
        /// </summary>
        /// <param name="permisos"></param>
        /// <param name="separator"></param>
        /// <returns></returns>
        public List<FamiliaComponent> recorrerPermisos(List<FamiliaComponent> permisos, string separator = "") {
            separator = separator + "-";
            List<FamiliaComponent> permisoUsuario = new List<FamiliaComponent>();
            foreach (var item in permisos)
            {
                if (item.GetChilds() == 0)
                {
                    permisoUsuario.Add(item);
                    Console.WriteLine($"{separator} Acceso a UI: {item.Nombre} ");
                }
                else
                {
                    dynamic value = item;
                    recorrerPermisos(value.Permisos, separator);
                }
            }
            return permisoUsuario;
        }
        /// <summary>
        /// insert a new user
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public int Insert(Usuario usuario)
        {
            int inserted = SqlHelper.ExecuteNonQueryUsers(InsertStatement, System.Data.CommandType.Text, "security", usuario);
            return inserted;
        }
        /// <summary>
        /// updte the DVV
        /// </summary>
        /// <param name="DVV"></param>
        /// <returns></returns>
        public int UpdateDVV(decimal DVV)
        {
            int updated = SqlHelper.ExecuteNonQueryUpdateDVV(UpdateDVVStatement, System.Data.CommandType.Text, "security", DVV.ToString());
            return updated;
        }
        /// <summary>
        /// update users
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public int Update(Usuario usuario)
        {
            int updated = SqlHelper.ExecuteNonQueryUpdateUser(UpdateUserStatement, System.Data.CommandType.Text, "security",usuario);
            return updated;
        }
        /// <summary>
        /// get all about users
        /// </summary>
        /// <param name="filtros"></param>
        /// <returns></returns>
        public IEnumerable<Usuario> GetAll(Array filtros)
        {
            try
            {
                List<Usuario> usuarios = new List<Usuario>();
                List<SqlParameter> parametros = new List<SqlParameter>();
                string statement; 
                switch (filtros.Length) {
                    case 1:
                        parametros.Add(new SqlParameter("@Usuario",filtros.GetValue(0)));
                        statement = LoginSelectFilterStatement;
                        break;
                    default:
                        parametros.Add(new SqlParameter("@FechaAltaDesde", Convert.ToDateTime(filtros.GetValue(0))));
                        parametros.Add(new SqlParameter("@FechaAltaHasta", Convert.ToDateTime(filtros.GetValue(1))));
                        if (filtros.GetValue(2).ToString().Length > 0)
                        {
                            parametros.Add(new SqlParameter("@Nombre", filtros.GetValue(2)));
                            statement = SelectFilterStatement + "AND Nombre LIKE '%@Nombre%';";
                        }
                        else {
                            statement = SelectFilterStatement;
                        }
                        break;
                }
                
                
                System.Console.WriteLine(statement);
                System.Console.WriteLine(parametros.ToArray().ToString());
            
                using (var dr = SqlHelper.ExecuteReader(statement, System.Data.CommandType.Text, "security", parametros.ToArray()))
                {
                    Object[] values = new Object[dr.FieldCount];
                    while (dr.Read())
                    {
                        dr.GetValues(values);
                        Usuario usuario = new Usuario();
                        Familia familia = new Familia();
                        usuario.Cod_Usuario = values[0].ToString();
                        usuario.Nombre = values[1].ToString();
                        usuario.Apellido = values[2].ToString();
                        usuario.Direccion = values[3].ToString();
                        usuario.Telefono = values[4].ToString();
                        usuario.Email = values[5].ToString();
                        Patente permisoUsuario = new Patente();
                        permisoUsuario.Nombre = values[6].ToString();
                        familia.Permisos.Add(permisoUsuario);
                        usuario.Permisos.Add(familia);
                        usuario.FechaAlta = Convert.ToDateTime(values[7].ToString());
                        usuario.Habilitado = Convert.ToBoolean(values[8]);
                        usuario.DVH = Convert.ToDecimal(values[9]);
                        usuario.Password = values[10].ToString();
                        usuarios.Add(usuario);
                    }

                }
                return usuarios;
            }
            catch (Exception ex)
            {
                FacadeService.ManageException(new DALException(ex));
                return null;
            }
        }
        /// <summary>
        /// get all the DVHs
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Usuario> GetAllDVH()
        {
            try
            {
                List<Usuario> usuarios = new List<Usuario>();
                string statement = SelectAllDVHStatement;


                System.Console.WriteLine(statement);

                using (var dr = SqlHelper.ExecuteReader(statement, System.Data.CommandType.Text, "security"))
                {
                    Object[] values = new Object[dr.FieldCount];
                    while (dr.Read())
                    {
                        dr.GetValues(values);
                        Usuario usuario = new Usuario();
                        usuario.Cod_Usuario = values[0].ToString();
                        usuario.Nombre = values[1].ToString();
                        usuario.FechaAlta = Convert.ToDateTime(values[2]);
                        usuario.DVH = Convert.ToDecimal(values[3]);
                        usuarios.Add(usuario);
                    }
                }
                return usuarios;
            }
            catch (Exception ex)
            {
                FacadeService.ManageException(new DALException(ex));
                return null;
            }
        }
    /// <summary>
    /// get all the users
    /// </summary>
    /// <returns></returns>
    public IEnumerable<Object> GetAll()
        {
            try
            {
                List<Usuario> usuarios = new List<Usuario>();
                string statement = SelectAllStatement;


                System.Console.WriteLine(statement);

                using (var dr = SqlHelper.ExecuteReader(statement, System.Data.CommandType.Text, "security"))
                {
                    Object[] values = new Object[dr.FieldCount];
                    while (dr.Read())
                    {
                        dr.GetValues(values);
                        Usuario usuario = new Usuario();
                        Familia familia = new Familia();
                        usuario.Cod_Usuario = values[0].ToString();
                        usuario.Nombre = values[1].ToString();
                        usuario.Apellido = values[2].ToString();
                        usuario.Direccion = values[3].ToString();
                        usuario.Telefono = values[4].ToString();
                        usuario.Email = values[5].ToString();
                        Patente permisoUsuario = new Patente();
                        permisoUsuario.Nombre = values[6].ToString();
                        familia.Permisos.Add(permisoUsuario);
                        //usuario.Permisos.Add(familia);
                        usuario.FechaAlta = Convert.ToDateTime(values[7].ToString());
                        usuario.Habilitado = Convert.ToBoolean(values[8]);
                        usuario.Idioma = values[9].ToString();
                        usuarios.Add(usuario);
                    }
                }
                return usuarios;
            }
            catch (Exception ex)
            {
                FacadeService.ManageException(new DALException(ex));
                return null;
            }
        }
    }




}
