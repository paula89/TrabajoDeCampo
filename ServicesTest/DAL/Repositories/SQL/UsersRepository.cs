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
            get => "SELECT Usuario, Nombre, Apellido, Direccion, Telefono, Email, Permisos, FechaAlta, Habilitado " +
                "FROM [dbo].[Usuarios]";
        }
        private string InsertStatement
        {
            get => "INSERT INTO [dbo].[Usuarios] (Usuario, Nombre, Apellido, Direccion, Telefono, Email, Contraseña, Permisos, FechaAlta, Habilitado, DVH)" +
                " VALUES (@Usuario, @Nombre, @Apellido, @Direccion, @Telefono, @Email, @Contraseña, @Permisos, @FechaAlta, @Habilitado, @DVH)";
        }
        private string LoginSelectFilterStatement
        {
            get => "SELECT * FROM [dbo].[Usuarios] " +
                "WHERE Usuario = @Usuario " +
                "and Contraseña = @Contraseña ";
        }

        private string SelectFilterStatement
        {
            get => "SELECT Usuario, Nombre, Apellido, Direccion, Telefono, Email, Permisos, FechaAlta, Habilitado" +
                " FROM [dbo].[Usuarios] " +
                "WHERE FechaAlta >= @FechaAltaDesde " +
                "AND FechaAlta <= @FechaAltaHasta ";                
        }


        private string SelectRolesStatement {
            get => "Select * FROM [dbo].[Roles]";  // id, roles
        }
        #endregion

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

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

        public bool GetLogin(Array filtros)
        {
            bool encontrado = false;

            try
            {
                List<SqlParameter> parametros = new List<SqlParameter>();

                parametros.Add(new SqlParameter("@Usuario", filtros.GetValue(0)));
                parametros.Add(new SqlParameter("@Contraseña", filtros.GetValue(1)));
                System.Console.WriteLine(SelectFilterStatement);
                System.Console.WriteLine(parametros.ToArray().ToString());

                using (var dr = SqlHelper.ExecuteReader(LoginSelectFilterStatement, System.Data.CommandType.Text, "security", parametros.ToArray()))
                {
                    Object[] values = new Object[dr.FieldCount];
                    while (dr.Read())
                    {
                        dr.GetValues(values);
                        encontrado = true;
                    }
                }

                return encontrado;
            }
            catch (Exception ex)
            {
                FacadeService.ManageException(new DALException(ex));
                return encontrado;
            }
        }

        
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

        public int Insert(Usuario usuario)
        {
            int inserted = SqlHelper.ExecuteNonQueryUsers(InsertStatement, System.Data.CommandType.Text, "security", usuario);
            return inserted;
        }

        public void Update(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Usuario> GetAll(Array filtros)
        {
            try
            {
                List<Usuario> usuarios = new List<Usuario>();
                List<SqlParameter> parametros = new List<SqlParameter>();
                string statement; 
                switch (filtros.Length) {
                    case 2:
                        parametros.Add(new SqlParameter("@Usuario",filtros.GetValue(0)));
                        parametros.Add(new SqlParameter("@Contraseña", filtros.GetValue(1)));
                        statement = LoginSelectFilterStatement;
                        break;
                    case 0:
                        parametros.Add(new SqlParameter("", ""));
                        statement = SelectAllStatement;
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
               /* List<SqlParameter> param;
                if (parametros.ToArray().Length > 0)
                {
                    param = parametros;
                } */
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
                        permisoUsuario.Nombre = values[7].ToString();
                        familia.Permisos.Add(permisoUsuario);
                        usuario.Permisos.Add(familia);
                        usuario.FechaAlta = Convert.ToDateTime(values[8].ToString());
                        usuario.Habilitado = Convert.ToBoolean(values[9]);
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
