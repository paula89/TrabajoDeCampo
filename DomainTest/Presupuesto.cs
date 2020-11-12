using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainTest
{
    public class Presupuesto
    {
        int nroDetalle { get; set; }
        int nroFichaPedido { get; set; }
        int IdPresupuesto { get; set; }
        DateTime vigencia { get; set; } // nro de dias de vigencia

    }
}
