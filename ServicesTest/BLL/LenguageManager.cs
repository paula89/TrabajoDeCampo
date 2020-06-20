using DalTest.i18n;
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
        //public string cultureInfo;

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





        public ResourceManager Translate(string cultureInfo)
        {
            Idioma.Culture = new CultureInfo(cultureInfo);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(cultureInfo);

            return Idioma.ResourceManager;

        }
    }
}
