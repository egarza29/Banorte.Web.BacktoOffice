using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Banorte.Web.BacktoOffice.AccesoEdificios.DDD.Domain.Entities.Options
{
    public  class Base
    {
        [Display(Name = "Opcion")]
        public string Option { set; get; }
    }
}
