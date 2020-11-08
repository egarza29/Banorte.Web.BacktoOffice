using Banorte.Web.BacktoOffice.AccesoEdificios.DDD.Domain.Entities.Options;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Banorte.Web.BacktoOffice.AccesoEdificios.DDD.Domain.Entities
{
    [Description("Edificio")]
    [DisplayName("BAR_Building")]
    public class Building
    {

        [Display(Name = "Direccion", Description = "Address")]
        public string Address { set; get; } // Una línea de texto
        [Display(Name = "Pais", Description = "Country")]
        public string Country { set; get; } // Una línea de texto
        [Display(Name = "Número de asientos", Description = "Seats")]
        public int Seats { set; get; } // Número
        [Display(Name = "Cantidad umbral de ocupación", Description = "Occupancy Threshold")]
        public int Occupancy_Threshold { set; get; } // Número
        [Display(Name = "Cantidad maxima de ocupación", Description = "MaxOccupancy")]
        public int MaxOccupancy { set; get; } // Número
        [Display(Name = "Instrucciones de acceso al sitio", Description = "OnsiteAccessInstructions")]
        public string OnsiteAccessInstructions { set; get; } //  Varias líneas de texto
        [Display(Name = "Criterios clave de eligibilidad", Description = "KeyEligibilityCriteria")]
        public string KeyEligibilityCriteria { set; get; } // Varias líneas de texto
        [Display(Name = "Estatus", Description = "Status")]
        public List<BuildingStatus> Status { set; get; } // Elección
        [Display(Name = "Tipo de edificio", Description = "Building Type")]
        public List<BuildingBuildingType> Building_Type { set; get; } // Elección
    }
}

