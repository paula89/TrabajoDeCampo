using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesTest.Domain
{
    /// <summary>
    /// backup class 
    /// </summary>
    public class Backup
    {
        public DateTime Fecha { get; set; }
        public String Descripcion { get; set; }
        public String Path { get; set; }
    }
}
