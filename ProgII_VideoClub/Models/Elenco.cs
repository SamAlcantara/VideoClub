//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProgII_VideoClub.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Elenco
    {
        public Elenco()
        {
            this.Elenco_articulo = new HashSet<Elenco_articulo>();
        }
    
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Estado { get; set; }
    
        public virtual ICollection<Elenco_articulo> Elenco_articulo { get; set; }
    }
}
