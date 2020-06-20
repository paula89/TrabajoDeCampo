using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainTest
{
    public class Bitacora
    {
        public enum CriticidadEnum
        {
            Menor,
            Medio,
            Mayor
        }

        public DateTime Fecha { get; set; }
        public String Descripcion { get; set; }
        public CriticidadEnum Criticidad { get; set; }

        public String Usuaro { get; set; }


    }
}
