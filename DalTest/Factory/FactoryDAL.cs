﻿using DalTest.Contracts;
using DomainTest;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DalTest.Factory
{
    public class FactoryDAL
    {
        #region Singleton

        private readonly static FactoryDAL instance = new FactoryDAL();

        public static FactoryDAL Current
        {
            get
            {
                return instance;
            }
        }

        private FactoryDAL()
        {
            //Implement here the initialization code
        }
#endregion

        public IGenericRepository<Bitacora> GetBitacoraRepository()
        {
            try
            {
                string nombreNamespaceClaseAccesoDatos = ConfigurationManager.AppSettings["AccesoDatos"] + ".BitacoraRepository";
                object instancia = Activator.CreateInstance(Type.GetType(nombreNamespaceClaseAccesoDatos));

                return (IGenericRepository<Bitacora>)instancia;
            }
            catch (Exception exc)
            {
                System.Console.WriteLine("exc :::" + exc.Message);
                return null;
            }
        }

    }
}