using ServicesTest.DAL.Factory;
using ServicesTest.Domain.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesTest.BLL
{
    public class UsersManager
    {
        #region Singleton
        private readonly static UsersManager _instance = new UsersManager();
        private FactoryDAL instancia;

        public static UsersManager Current
        {
            get
            {
                return _instance;
            }
        }

        private UsersManager()
        {
            instancia = FactoryDAL.Current;
        }
        #endregion


        public int RegistrarUsuario(Usuario usuario)
        {
            return instancia.GetUsersRepository().Insert(usuario);
        }

        public IEnumerable<String> ObtenerRoles() {
            return instancia.GetUsersRepository().GetAllRoles();
        }

        public IEnumerable<Usuario> ObtenerUsuariosLogin(string[] filtros)
        {
            //return instancia.GetUsersRepository().GetLogin(filtros);

                var usuarioSesion = instancia.GetUsersRepository().GetAll(filtros);
            return usuarioSesion.ToList();
        }

        public IEnumerable<Usuario> ListarUsuarios(string[] filtros)
        {
            //return instancia.GetUsersRepository().GetLogin(filtros);

            var usuarioSesion = instancia.GetUsersRepository().GetAll(filtros);
            return usuarioSesion.ToList();
        }

        public bool GetLogin(string[] filtros)
        {
            return instancia.GetUsersRepository().GetLogin(filtros);
        }

    }

}
