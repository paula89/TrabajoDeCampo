using ServicesTest.DAL.Factory;
using ServicesTest.Domain.Exceptions;
using ServicesTest.Facade;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ServicesTest.BLL
{
    public sealed class LanguageManager
    {
        #region Singleton
        public readonly static LanguageManager _instance = new LanguageManager();

        public static LanguageManager Current
        {
            get
            {
                return _instance;
            }
        }

        private LanguageManager()
        {
            //cultureInfo = Thread.CurrentThread.CurrentUICulture.Name;
        }
        #endregion




        /// <summary>
        /// return the language to start the application
        /// </summary>
        /// <param name="cultureInfo"></param>
        /// <returns></returns>
        public ResourceManager Translate(string cultureInfo)
        {
            string pathLanguage = FactoryDAL.Current.GetTranslateRepository();
            string file;             
            try
            {
                // Idioma.Culture = new CultureInfo(cultureInfo);
                switch (cultureInfo)
                {
                    case "En-US":
                        file = "Idioma";
                        break;
                    default:
                        file = "Idioma." + cultureInfo;
                        break;
                }

                ResourceManager Idioma = ResourceManager.CreateFileBasedResourceManager(file, pathLanguage, null);

                Thread.CurrentThread.CurrentUICulture = new CultureInfo(cultureInfo);

                return Idioma;
            }
            catch(BLLException ex) {
                FacadeService.ManageException(ex);
                return null;
            }

        }
    }
}
