using System;
using System.Collections.Generic;
using System.Text;

namespace Services.BLL
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
