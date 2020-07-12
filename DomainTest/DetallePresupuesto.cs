using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainTest
{
    public class DetallePresupuesto
    {
        string comentario { get; set; }
        DateTime fecha { get; set; }
        string formaDePago { get; set; }
        float importe { get; set; }
        int nroDetalle { get; set; }
        int nroPresupuesto { get; set; }
        List<Producto> productos { get; set; }
        List<Promocion> promociones { get; set; }

    }
}
