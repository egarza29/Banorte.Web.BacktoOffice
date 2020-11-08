using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Banorte.Web.BacktoOffice.Domain.Entities
{
    [Description("Respuesta de pregunta clave")]
    [DisplayName("BAR_KeyQuestionAnswer")]
    public class KeyQuestionAnswer
    {
        [Display(Name = "Identificador de pregunta", Description = "QuestionID")]
        public int QuestionID { set; get; } // Número
        [Display(Name = "Usuario", Description = "User")]
        public SharepointUser User { set; get; } // Persona o grupo
    }
}
