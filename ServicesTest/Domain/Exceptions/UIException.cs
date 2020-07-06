using ServicesTest.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesTest.Domain.Exceptions
{
    public class UIException: Exception
    {
        public UIException(Exception ex): base("UI Exception", ex) {
      
        }
    }
}
