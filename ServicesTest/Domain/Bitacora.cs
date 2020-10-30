using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ServicesTest.Domain
{   [Serializable()]
    public class Bitacora//: ISerializable
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
