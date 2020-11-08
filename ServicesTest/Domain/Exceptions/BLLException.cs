using ServicesTest.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesTest.Domain.Exceptions
{
    public class BLLException: Exception
    {
        public bool IsBusinessException { get; private set; }
        /// <summary>
        /// BLL exception customized
        /// </summary>
        /// <param name="ex"></param>
        /// <param name="IsBusinessException"></param>
        public BLLException(Exception ex, bool IsBusinessException = false) : base("BLL Exception", ex)
        {
            this.IsBusinessException = IsBusinessException;
        }
        /// <summary>
        /// BLL exception customized
        /// </summary>
        /// <param name="message"></param>
        /// <param name="IsBusinessException"></param>
        public BLLException(string message, bool IsBusinessException = false) : base(message)
        {
            this.IsBusinessException = IsBusinessException;           
        }        
    }
}
