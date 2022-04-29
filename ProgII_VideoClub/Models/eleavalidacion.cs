using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProgII_VideoClub.Models
{
    [MetadataType(typeof(Elenco_articuloMetaData))]
    public partial class Elenco_articulo
    {
        public class Elenco_articuloMetaData
        {
            [DisplayName("Artículo")]
            public int Articulo { get; set; }

            [DisplayName("Elenco")]
            public Nullable<int> Elenco { get; set; }

            [DisplayName("Rol")]
            public string Rol { get; set; }
        }
    }
}