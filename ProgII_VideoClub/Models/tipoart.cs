using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProgII_VideoClub.Models
{
    [MetadataType(typeof(Tipo_de_artículoMetaData))]
    public partial class Tipo_de_artículo
    {
        public class Tipo_de_artículoMetaData
        {
            [DisplayName("Tipo")]
            public string Descripcion { get; set; }

        }
    }
}