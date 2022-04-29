using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProgII_VideoClub.Models
{
    [MetadataType(typeof(GeneroMetaData))]
    public partial class Genero
    {
        public class GeneroMetaData
        {
            [DisplayName("Descripción")]
            public string Descripcion { get; set; }

        }
    }
}