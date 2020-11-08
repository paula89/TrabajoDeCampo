using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesTest.Domain.Exceptions
{
    public class DALException:Exception
    {
        /// <summary>
        /// dal exception customized
        /// </summary>
        /// <param name="ex"></param>
        public DALException(Exception ex) : base("DAL Exception", ex)
        {

        }
    }
}
