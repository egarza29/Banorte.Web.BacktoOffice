using Banorte.Web.BacktoOffice.AccesoEdificios.DDD.Domain.Entities.Options;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Banorte.Web.BacktoOffice.AccesoEdificios.DDD.Domain.Entities
{
    [Description("Registro y Desregistro")]
    [DisplayName("BAR_CheckIn_CheckOut")]
    public class CheckInCheckOut
    {
        [Display(Name = "Identificador de solicitud de colección", Description = "Request Collection ID")]
        public string Request_Collection_ID { set; get; } // Una línea de texto
        [Display(Name = "Nombre de espacio", Description = "SpaceName")]
        public string SpaceName { set; get; } // Una línea de texto
        [Display(Name = "Clave de acceso", Description = "AccessKey")]
        public string AccessKey { set; get; } // Una línea de texto
        [Display(Name = "Nombre del solicitante", Description = "RequestorNameText")]
        public string RequestorNameText { set; get; } // Una línea de texto
        [Display(Name = "Nombre del aprobador", Description = "ApproverNameText")]
        public string ApproverNameText { set; get; } // Una línea de texto
        [Display(Name = "Guid Solicitante", Description = "RequestorGuid")]
        public string RequestorGuid { set; get; } // Una línea de texto
        [Display(Name = "Guid Aproador", Description = "ApproverGuid")]
        public string ApproverGuid { set; get; } // Una línea de texto
        [Display(Name = "Guid aprobador de seguridad", Description = "SecurityApproverGuid")]
        public string SecurityApproverGuid { set; get; } // Una línea de texto
        [Display(Name = "Identificador de edificio", Description = "BuildingID")]
        public int BuildingID { set; get; } // Número
        [Display(Name = "Identificador de piso", Description = "FloorID")]
        public int FloorID { set; get; } // Número
        [Display(Name = "Razon del Solicitante", Description = "RequestReason")]
        public string RequestReason { set; get; } // Varias líneas de texto
        [Display(Name = "Razón de rechazo", Description = "RejectionReason")]
        public string RejectionReason { set; get; } // Varias líneas de texto
        [Display(Name = "Estatus", Description = "Status")]
        public List<CheckInCheckOutStatus> Status { set; get; } // Elección
        [Display(Name = "Estatus de Registro", Description = "CheckIn Status")]
        public List<CheckInCheckOutCheckInStatus> CheckIn_Status { set; get; } // Elección
        [Display(Name = "Solicitante", Description = "Requestor")]
        public SharepointUser Requestor { set; get; } // Persona o grupo
        [Display(Name = "Aprobador", Description = "Approver")]
        public SharepointUser Approver { set; get; } // Persona o grupo
        [Display(Name = "Aprobador de seguridad", Description = "SecurityApprover")]
        public SharepointUser SecurityApprover { set; get; } // Persona o grupo
        [Display(Name = "Tiempo de registro", Description = "CheckInTime")]
        public string CheckInTime { set; get; } // Una línea de texto
    }
}
