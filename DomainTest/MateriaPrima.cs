using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainTest
{
    public class MateriaPrima
    {
        public Guid IdMateriaPrima { get; set; }
        public string nombre { get; set; }
        public string proveedor { get; set; }
        public float cantidad { get; set; }
        public string marca { get; set; }
        public string usuario { get; set; }
        public string comentario { get; set; }
        public DateTime fechaAlta { get; set; }
        public DateTime vencimiento { get; set; }
        public bool habilitada { get; set; }
    }
}
