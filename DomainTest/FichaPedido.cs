using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainTest
{
    public class FichaPedido
    {
        int nroFichaPedido { get; set; }
        string estado { get; set; }
        DateTime fecha { get; set; }
        string descripcion { get; set; }
        List<Producto> productos { get; set; }
    }
}
