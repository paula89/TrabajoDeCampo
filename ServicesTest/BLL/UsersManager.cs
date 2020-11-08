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
        /// <summary>
        /// register a new user
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public int RegistrarUsuario(Usuario usuario)
        {
            return instancia.GetUsersRepository().Insert(usuario);
        }
        /// <summary>
        /// update an user
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public int ActualizarUsuario(Usuario usuario)
        {
            return instancia.GetUsersRepository().Update(usuario);
        }
        /// <summary>
        /// register the new DVV
        /// </summary>
        /// <param name="DVV"></param>
        /// <returns></returns>
        public int RegistrarDVV(decimal DVV) {
            return instancia.GetUsersRepository().UpdateDVV(DVV);
        }
        /// <summary>
        /// get all the roles to create an user
        /// </summary>
        /// <returns></returns>
        public IEnumerable<String> ObtenerRoles() {
            return instancia.GetUsersRepository().GetAllRoles();
        }
        /// <summary>
        /// get all the languages to create an user
        /// </summary>
        /// <returns></returns>
        public IEnumerable<String> ObtenerIdiomas()
        {
            return instancia.GetUsersRepository().GetAllIdiomas();
        }
        /// <summary>
        /// get the user to init the session by filters
        /// </summary>
        /// <param name="filtros"></param>
        /// <returns></returns>
        public IEnumerable<Usuario> ObtenerUsuariosLogin(string[] filtros)
        {
            var usuarioSesion = instancia.GetUsersRepository().GetAll(filtros);
            return usuarioSesion.ToList();
        }
        /// <summary>
        /// get the users by filters
        /// </summary>
        /// <param name="filtros"></param>
        /// <returns></returns>
        public IEnumerable<Usuario> ListarUsuariosFilter(string[] filtros)
        {
            var usuarioSesion = instancia.GetUsersRepository().GetAll(filtros);
            return usuarioSesion.ToList();
        }
        /// <summary>
        /// get the DVHs 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Usuario> ListarDVH()
        {
            var usuarioSesion = instancia.GetUsersRepository().GetAllDVH();
            return usuarioSesion.ToList();
        }
        
        /// <summary>
        /// get all the users
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Object> ListarUsuarios()
        {
            var usuarioSesion = instancia.GetUsersRepository().GetAll();
            return usuarioSesion.ToList();
        }
        /// <summary>
        /// get the user that is login in the system
        /// </summary>
        /// <param name="filtros"></param>
        /// <returns></returns>
        public IEnumerable<Usuario> GetLogin(string[] filtros)
        {
            currentUser = instancia.GetUsersRepository().GetLogin(filtros); ;
            return currentUser;
        }
        /// <summary>
        /// get the DVVs
        /// </summary>
        /// <returns></returns>
        public decimal GetDVV() {
            return instancia.GetUsersRepository().GetDVV();
        }

    }

}
