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
    
    public partial class Tipo_de_artículo
    {
        public Tipo_de_artículo()
        {
            this.Articulos = new HashSet<Articulo>();
        }
    
        public int ID { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
    
        public virtual ICollection<Articulo> Articulos { get; set; }
    }
}
