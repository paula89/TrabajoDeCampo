using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainTest
{
    public class Promocion
    {
        string comentario { get; set; }
        int descuento { get; set; }
        bool estado { get; set; }
        string nombre { get; set; }
        int IdPromocion { get; set; }
        DateTime vigencia { get; set; } // fecha de vencimiento
        string usuario { get; set; }
        DateTime FechaAlta { get; set; }

    }
}
