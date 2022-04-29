using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProgII_VideoClub.Models
{
    [MetadataType(typeof(EmpleadoMetaData))]
    public partial class Empleado
    {
        public class EmpleadoMetaData
        {
            [DisplayName("Nombre Empleado")]
            public string Nombre { get; set; }

            [DisplayName("Cédula")]
            public string Cedula { get; set; }

            [DisplayName("Tanda")]
            public string Tanda_labor { get; set; }

            [DisplayName("% Comisión")]
            public string Porciento_comision { get; set; }

            [DisplayName("Fecha de ingreso")]

            public Nullable<System.DateTime> Fecha_ingreso { get; set; }

            [DisplayName("Estado")]
            public string Estado { get; set; }
        }
    }
}