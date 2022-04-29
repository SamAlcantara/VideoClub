using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProgII_VideoClub.Models
{
    [MetadataType(typeof(ClienteMetaData))]
    public partial class Cliente
    {
        public class ClienteMetaData
        {
            [DisplayName("Nombre Cliente")]
            public string Nombre { get; set; }

            [DisplayName("Cédula")]
            public string Cedula { get; set; }

            [DisplayName("No.Tarjeta CR")]
            public Nullable<int> Num_tarjeta_CR { get; set; }

            [DisplayName("Límite de Crédito ")]
            public Nullable<double> Limite_de_credito { get; set; }

            [DisplayName("Tipo persona")]
            public string Tipo_persona { get; set; }

            [DisplayName("Estado")]
            public string Estado { get; set; }

        }
    }
}