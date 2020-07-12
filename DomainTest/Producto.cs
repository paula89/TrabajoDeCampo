using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainTest
{
    public class Producto
    {
        int cantidad { get; set; }
        string comentario { get; set; }
        bool estado { get; set; }
        List<Herramientas> herramientas { get; set; }
        List<MateriaPrima> materiasPrimas { get; set; }
        string nombre { get; set; }
        int nroProducto { get; set; }


    }
}
