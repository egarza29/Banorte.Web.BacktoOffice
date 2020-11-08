using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Banorte.Web.BacktoOffice.AccesoEdificios.DDD.Domain.Entities
{
    public class SharepointBase : Base
    {

        [Display(Name = "Fecha de Creación")]
        public DateTime? Created { set; get; }
        [Display(Name = "Fecha de Modificación")]
        public DateTime? Modified { set; get; }
        [Display(Name = "Usuario Creador")]
        public SharepointUser Author { set; get; }
        [Display(Name = "Usuario Editor")]
        public SharepointUser Editor { set; get; }
    }
}
