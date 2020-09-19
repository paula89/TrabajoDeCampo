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

        IEnumerable<Usuario> currentUser;
        public int RegistrarUsuario(Usuario usuario)
        {
            return instancia.GetUsersRepository().Insert(usuario);
        }
        public int ActualizarUsuario(Usuario usuario)
        {
            return instancia.GetUsersRepository().Update(usuario);
        }

        public int RegistrarDVV(decimal DVV) {
            return instancia.GetUsersRepository().UpdateDVV(DVV);
        }
        public IEnumerable<String> ObtenerRoles() {
            return instancia.GetUsersRepository().GetAllRoles();
        }

        public IEnumerable<String> ObtenerIdiomas()
        {
            return instancia.GetUsersRepository().GetAllIdiomas();
        }

        public IEnumerable<Usuario> ObtenerUsuariosLogin(string[] filtros)
        {
            //return instancia.GetUsersRepository().GetLogin(filtros);

                var usuarioSesion = instancia.GetUsersRepository().GetAll(filtros);
            return usuarioSesion.ToList();
        }

        public IEnumerable<Usuario> ListarUsuariosFilter(string[] filtros)
        {
            //return instancia.GetUsersRepository().GetLogin(filtros);

            var usuarioSesion = instancia.GetUsersRepository().GetAll(filtros);
            return usuarioSesion.ToList();
        }

        public IEnumerable<Usuario> ListarDVH()
        {
            var usuarioSesion = instancia.GetUsersRepository().GetAllDVH();
            return usuarioSesion.ToList();
        }
        

        public IEnumerable<Usuario> ListarUsuarios()
        {
            var usuarioSesion = instancia.GetUsersRepository().GetAll();
            return usuarioSesion.ToList();
        }

        public IEnumerable<Usuario> GetLogin(string[] filtros)
        {
            currentUser = instancia.GetUsersRepository().GetLogin(filtros); ;
            return currentUser;
        }

        public decimal GetDVV() {
            return instancia.GetUsersRepository().GetDVV();
        }

    }

}
