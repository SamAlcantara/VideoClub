using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProgII_VideoClub.Models
{
    [MetadataType(typeof(IdiomaMetaData))]
    public partial class Idioma
    {
        public class IdiomaMetaData
        {
            [DisplayName("Idioma")]
            public string Descripcion { get; set; }

          
        }
    }
}