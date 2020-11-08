using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Banorte.Web.BacktoOffice.Domain.Entities
{
    [Description("Configuracion")]
    [DisplayName("BAR_AppSettings")]
    public class AppSetting
    {
        [Display(Name = "¿Requiere Acceso a Edificio?", Description = "RequestBuildingAccess")]
        public bool RequestBuildingAccess { set; get; } // Sí o No
        [Display(Name = "¿Precauciones de Seguridad?", Description = "SafetyPrecautions")]
        public bool SafetyPrecautions { set; get; } // Sí o No
        [Display(Name = "¿Preguntas Clave?", Description = "KeyQuestions")]
        public bool KeyQuestions { set; get; } // Sí o No
        [Display(Name = "Descripcion de Pregunta Clave", Description = "KeyQuestionDescription")]
        public string KeyQuestionDescription { set; get; } // Varias líneas de texto
        [Display(Name = "¿Habilitar aprobacion en linea?", Description = "EnableInlineApprovals")]
        public bool EnableInlineApprovals { set; get; } // Sí o No
        [Display(Name = "¿Anticipar reserva?", Description = "BookingAdvance")]
        public int BookingAdvance { set; get; } // Número
        [Display(Name = "Mensaje de error de pregunta clave", Description = "KeyQuestionsFailMessage")]
        public string KeyQuestionsFailMessage { set; get; } // Varias líneas de texto
        [Display(Name = "Mensaje de error de reserva anticipada", Description = "BookingAdvanceErrorMessage")]
        public string BookingAdvanceErrorMessage { set; get; } // Una línea de texto
        [Display(Name = "Identificador Administrador de Microsoft Teams", Description = "AdminTeamsID")]
        public string AdminTeamsID { set; get; } // Una línea de texto
        [Display(Name = "Identificador Administrador de Canal de Microsoft Teams", Description = "AdminTeamChannelID")]
        public string AdminTeamChannelID { set; get; } // Una línea de texto

    }
}
