using Banorte.Web.BacktoOffice.Domain.Entities.Options;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Banorte.Web.BacktoOffice.Domain.Entities
{

    [Description("Precauciones de seguridad")]
    [DisplayName("BAR_SafetyPrecaution")]
    public class SafetyPrecaution
    {
        [Display(Name = "Pais", Description= "Country")]
        public string Country { set; get; } //Una línea de texto
        [Display(Name = "URL del Recurso", Description = "ResourceURL")]
        public string ResourceURL { set; get; } //Una línea de texto
        [Display(Name = "Identificador de Pais", Description = "CountryID")]
        public int CountryID { set; get; } // Número
        [Display(Name = "Descripcion", Description = "Description")]
        public string Description { set; get; } // Varias líneas de texto
        [Display(Name = "Estatus", Description = "Status")]
        public List<SafetyPrecautionStatus> Status { set; get; } // Elección
        [Display(Name = "Severidad", Description = "Severity")]
        public List<SafetyPrecautionSeverity> Severity { set; get; } // Elección
    }
}
