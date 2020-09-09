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
            get => "SELECT * FROM [dbo].[Usuarios]";
        }
        private string InsertStatement
        {
            get => "INSERT INTO [dbo].[Usuarios] (Usuario, Nombre, Apellido, Direccion, Telefono, Email, Contraseña, Permisos, FechaAlta)" +
                " VALUES (@Usuario, @Nombre, @Apellido, @Direccion, @Telefono, @Email, @Contraseña, @Permisos, @FechaAlta)";
        }
        private string SelectFilterStatement
        {
            get => "SELECT * FROM [dbo].[Usuarios] " +
                "WHERE Role = @ " +
                "and Fecha <= @ " +
                "order by Fecha";
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

        public IEnumerable<Usuario> GetAll(Array filtros)
        {
            try
            {
                List<Usuario> usuarios = new List<Usuario>();

                List<SqlParameter> parametros = new List<SqlParameter>();

                parametros.Add(new SqlParameter("@desde", Convert.ToDateTime(filtros.GetValue(0))));
                parametros.Add(new SqlParameter("@hasta", Convert.ToDateTime(filtros.GetValue(1))));
                System.Console.WriteLine(SelectFilterStatement);
                System.Console.WriteLine(parametros.ToArray().ToString());

                using (var dr = SqlHelper.ExecuteReader(SelectFilterStatement, System.Data.CommandType.Text, "security", parametros.ToArray()))
                {
                    Object[] values = new Object[dr.FieldCount];

                    while (dr.Read())
                    {
                        dr.GetValues(values);
                        Usuario usuario = new Usuario();
                        usuario.Cod_Usuario = values[0].ToString();
                        usuario.Nombre = values[1].ToString();
                        usuario.Apellido = values[2].ToString();
                        usuario.Direccion = values[3].ToString();
                        usuario.Telefono = values[4].ToString();
                        usuario.Email = values[5].ToString();
                        //usuario.Permisos.Add(recorrerPermisos((FamiliaComponent)values[3]));

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
    }
}
