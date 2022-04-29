using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProgII_VideoClub.Models
{
    [MetadataType(typeof(ArticuloMetaData))]
    public partial class Articulo
    {
        public class ArticuloMetaData
        {
            [DisplayName("Título")]
            public string Titulo { get; set; }

            public Nullable<int> Tipo_de_articulo_ID { get; set; }

            public Nullable<int> Idioma_ID { get; set; }

            [DisplayName("Renta x Día")]
            public Nullable<double> Renta_por_dia { get; set; }

            [DisplayName("Dias de renta")]
            public string Dias_de_renta { get; set; }

            [DisplayName("Monto entrega tardía")]
            public Nullable<double> Monto_entrega_tardia { get; set; }

            [DisplayName("Estado")]
            public string Estado { get; set; }

  
        }
}
}