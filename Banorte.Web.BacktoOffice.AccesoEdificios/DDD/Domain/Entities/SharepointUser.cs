using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Banorte.Web.BacktoOffice.AccesoEdificios.DDD.Domain.Entities
{
    public class SharepointUser:Base
    {
        [Display(Name = "Correo Electronico")]
        public string Email { set; get; }
    }
}
