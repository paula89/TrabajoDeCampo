using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
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
