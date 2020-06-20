using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesTest.BLL
{
    public sealed class TraceManager
    {
        #region Singleton
        private readonly static TraceManager _instance = new TraceManager();

        public static TraceManager Current
        {
            get
            {
                return _instance;
            }
        }

        private TraceManager()
        {
            //Implement here the initialization code
        }
        #endregion

        public void Write(string message)
        {

        }
    }
}
