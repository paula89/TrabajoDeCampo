﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
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
        }
        #endregion
        /// <summary>
        /// Write by console a new exception
        /// </summary>
        /// <param name="message"></param>
        /// <param name="level"></param>
        public void Write(string message, EventLevel level )
        {
            Console.WriteLine($"[Exception] Fecha: { DateTime.Now.ToString() }, {message}, {level} ");

        }
    }
}
