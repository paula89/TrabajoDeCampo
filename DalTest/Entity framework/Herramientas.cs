//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DalTest.Entity_framework
{
    using System;
    using System.Collections.Generic;
    
    public partial class Herramientas
    {
        public string IdHerramienta { get; set; }
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public string Marca { get; set; }
        public string Proveedor { get; set; }
        public string Comentario { get; set; }
        public System.DateTime FechaAlta { get; set; }
        public double TiempoDeUso { get; set; }
        public bool Habilitado { get; set; }
    }
}
