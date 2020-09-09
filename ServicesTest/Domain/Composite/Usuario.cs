using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesTest.Domain.Composite
{
    public class Usuario
    {
		public Usuario()
		{
			Permisos = new List<FamiliaComponent>();
		}

		public String Cod_Usuario { get; set; }
		public String Nombre { get; set; }
		public String Apellido { get; set; }
		public String Email { get; set; }
		public String Telefono { get; set; }
		public String Direccion { get; set; }
		public String Password { get; set; }
		public List<FamiliaComponent> Permisos { get; set; }
		public DateTime FechaAlta { get; set; }
	}
}
