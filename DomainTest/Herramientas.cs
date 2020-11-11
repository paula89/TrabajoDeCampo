using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainTest
{
   public class Herramientas
    {
        public int cantidad { get; set; }
        public string comentario { get; set; }
        public bool habilitado { get; set; }
        public string marca { get; set; }
        public string nombre { get; set; }
        public Guid IdHerramienta { get; set; }
        public string proveedor { get; set; }
        public float tiempoDeUso { get; set; }
        public DateTime fechaAlta { get; set; }

    }
}
