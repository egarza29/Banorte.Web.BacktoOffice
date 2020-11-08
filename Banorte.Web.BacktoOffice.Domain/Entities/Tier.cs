using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Banorte.Web.BacktoOffice.Domain.Entities
{
    [Description("Nivel")]
    [DisplayName("BAR_Tier")]
    public class Tier : SharepointBase
    {
        [Display(Name = "Identificador Edificio", Description = "BuildingID")]
        public int BuildingID { set; get; }// Número
        [Display(Name = "Capacidad", Description = "Capacity")]
        public int Capacity { set; get; }//Número
        [Display(Name = "¿Ha sido aprobado?", Description = "HasApprover")]
        public bool HasApprover { set; get; }//Sí o No
        [Display(Name = "Descripción General", Description = "General_Description")]
        public string General_Description { set; get; }//Varias líneas de texto
        [Display(Name = "Habilitado", Description = "Enabled")]
        public bool Enabled { set; get; }//Sí o No
        [Display(Name = "Fecha de Habilitación", Description = "Enabled_Start_Date")]
        public DateTime? Enabled_Start_Date { set; get; }//Fecha y hora
        [Display(Name = "Fecha de Deshabilitación", Description = "Enabled_End_Date")]
        public DateTime? Enabled_End_Date { set; get; }//Fecha y hora
        [Display(Name = "Aprobador", Description = "Approver")]
        public SharepointUser Approver { set; get; }//Persona o grupo
    }
}
