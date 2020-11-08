using Banorte.Web.BacktoOffice.AccesoEdificios.DDD.Domain.Entities.Options;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Banorte.Web.BacktoOffice.AccesoEdificios.DDD.Domain.Entities
{
    [Description("Preguntas clave")]
    [DisplayName("BAR_KeyQuestion")]
    public class KeyQuestion
    {
        [Display(Name = "Estado", Description = "State")]
        public List<KeyQuestionAnswerState> State { set; get; }  //Elección
    }
}
