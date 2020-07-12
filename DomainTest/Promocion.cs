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
        int nroPromocion { get; set; }
        int vigencia { get; set; } // nro de dias de vigencia
    }
}
