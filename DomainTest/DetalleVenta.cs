using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainTest
{
    public class DetalleVenta
    {
        int cantidad { get; set; }
        int comentario { get; set; }
        string estado { get; set; }
        DateTime fecha { get; set; }
        float monto { get; set; }
        int nroFactura { get; set; }
    }
}
