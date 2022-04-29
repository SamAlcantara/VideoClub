using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProgII_VideoClub.Models
{
    [MetadataType(typeof(ElencoMetaData))]
    public partial class Elenco
    {
        public class ElencoMetaData
        {
            [DisplayName("Nombre Elenco")]
            public string Nombre { get; set; }

            [DisplayName("Estado")]
            public string Estado { get; set; }


        }
    }
}