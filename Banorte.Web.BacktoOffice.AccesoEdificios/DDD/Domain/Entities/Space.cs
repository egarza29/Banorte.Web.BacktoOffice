using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Banorte.Web.BacktoOffice.AccesoEdificios.DDD.Domain.Entities
{
    [Description("Espacios")]
    [DisplayName("BAR_Space")]
    public class Space : SharepointBase
    {

        [Display(Name = "Identificador Edificio", Description = "BuildingID")]
        public int BuildingID { set; get; }// Número
        [Display(Name = "Capacidad", Description = "Capacity")]
        public int Capacity { set; get; }// Número
        [Display(Name = "¿Ha sido aprobado?", Description = "HasApprover")]
        public bool HasApprover { set; get; }// Sí o No
        [Display(Name = "Usuario Asignado", Description = "AssignedUser")]
        public SharepointUser AssignedUser { set; get; }// Persona o grupo
        [Display(Name = "Habilitado", Description = "Enabled")]
        public bool Enabled { set; get; }// Sí o No
        [Display(Name = "Fecha de Inicial de Inhabilitación", Description = "InitialDisabledDate")]
        public DateTime? InitialDisabledDate { set; get; }// Fecha y hora
        [Display(Name = "Fecha de Final de Inhabilitación", Description = "FinalDisabledDate")]
        public DateTime? FinalDisabledDate { set; get; }// Fecha y hora
        [Display(Name = "Espacio de Estacionamiento", Description = "IsParkingSlot")]
        public bool IsParkingSlot { set; get; }// Sí o No
        [Display(Name = "¿Es Critico?", Description = "IsCritical")]
        public bool IsCritical { set; get; }// Sí o No
        [Display(Name = "Identificador de Lugar", Description = "TierID")]
        public int TierID { set; get; }// Número
        [Display(Name = "Aprobador", Description = "Approver")]
        public SharepointUser Approver { set; get; }// Persona o grupo
    }
}
