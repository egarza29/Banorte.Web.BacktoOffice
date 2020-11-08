using Banorte.Web.BacktoOffice.AccesoEdificios.DDD.Domain.Entities.Options;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Banorte.Web.BacktoOffice.AccesoEdificios.DDD.Domain.Entities
{
    [Description("Solicitud")]
    [DisplayName("BAR_Requests")]
    public class Request : SharepointBase
    {
        [Display(Name = "Identificador de colección del solicitante", Description = "RequestCollection ID")]
        public string Request_Collection_ID { set; get; } // Una línea de texto
        [Display(Name = "Nombre del espacio", Description = "SpaceName")]
        public string SpaceName { set; get; } // Una línea de texto
        [Display(Name = "Clave de acceso", Description = "AccessKey")]
        public string AccessKey { set; get; } // Una línea de texto
        [Display(Name = "Nombre del solicitante", Description = "RequestorNameText")]
        public string RequestorNameText { set; get; } // Una línea de texto
        [Display(Name = "Nombre del aprobador", Description = "ApproverNameText")]
        public string ApproverNameText { set; get; } // Una línea de texto
        [Display(Name = "Guid solicitante", Description = "RequestorGuid")]
        public string RequestorGuid { set; get; } // Una línea de texto
        [Display(Name = "Guid aprobador", Description = "ApproverGuid")]
        public string ApproverGuid { set; get; } // Una línea de texto
        [Display(Name = "Guid aprobador de seguridad", Description = "SecurityApproverGuid")]
        public string SecurityApproverGuid { set; get; } // Una línea de texto
        [Display(Name = "Identificador de edificio", Description = "BuildingID")]
        public int BuildingID { set; get; } // Número
        [Display(Name = "Identificador de piso", Description = "FloorID")]
        public int FloorID { set; get; } // Número
        [Display(Name = "Valor de fecha", Description = "DateValue")]
        public int DateValue { set; get; } // Número
        [Display(Name = "Activo", Description = "Active")]
        public int Active { set; get; } // Número
        [Display(Name = "Razon de solicitud", Description = "RequestReason")]
        public string RequestReason { set; get; } // Varias líneas de texto
        [Display(Name = "Razon de rechazo", Description = "RejectionReason")]
        public string RejectionReason { set; get; } // Varias líneas de texto
        [Display(Name = "Estatus", Description = "Status")]
        public List<RequestStatus> Status { set; get; } // Elección
        [Display(Name = "Estatus de registro", Description = "CheckIn Status")]
        public List<RequestCheckInStatus> CheckIn_Status { set; get; } // Elección
        [Display(Name = "Notificacion del solicitante enviada", Description = "RequestorNotificationSent")]
        public bool RequestorNotificationSent { set; get; } // Sí o No
        [Display(Name = "Auto aprobado", Description = "AutoApproved")]
        public bool AutoApproved { set; get; } // Sí o No
        [Display(Name = "Fecha de solicitud", Description = "RequestDate")]
        public DateTimeKind? RequestDate { set; get; } // Fecha y hora
        [Display(Name = "Hora de registro", Description = "CheckInTime")]
        public DateTime? CheckInTime { set; get; } // Fecha y hora
        [Display(Name = "Hora de final de registro", Description = "CheckOutTime")]
        public DateTime? CheckOutTime { set; get; } // Fecha y hora
        [Display(Name = "Requestor", Description = "Solicitante")]
        public SharepointUser Requestor { set; get; } // Persona o grupo
        [Display(Name = "Aprobador", Description = "Approver")]
        public SharepointUser Approver { set; get; } // Persona o grupo
        [Display(Name = "Aprobador de seguridad", Description = "SecurityApprover")]
        public SharepointUser SecurityApprover { set; get; } // Persona o grupo
        [Display(Name = "¿Tiene lugar de estacionamiento?", Description = "IsParkingSlot")]
        public bool IsParkingSlot { set; get; } // Sí o No
        [Display(Name = "Identificador de lugar de estacionamiento", Description = "ParkingSpaceID")]
        public int ParkingSpaceID { set; get; } // Número
        [Display(Name = "Solicitado por el administrador", Description = "RequestedByAdmin")]
        public bool RequestedByAdmin { set; get; } // Sí o No
        [Display(Name = "Identificador de usuario externo", Description = "ExternalUserID")]
        public int ExternalUserID { set; get; } // Número
        [Display(Name = "Nombre de usuario externo", Description = "ExternalUserName")]
        public string ExternalUserName { set; get; } // Una línea de texto
        [Display(Name = "¿Es usuario externo?", Description = "Is_ExternalUser")]
        public bool Is_ExternalUser { set; get; } // Sí o No
    }
}
