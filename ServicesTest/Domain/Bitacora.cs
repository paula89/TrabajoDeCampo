using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesTest.Domain
{   /// <summary>
    /// Bitacora serializable class
    /// </summary>
    [Serializable()]
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
        public String Usuario { get; set; }
       
    }
}
