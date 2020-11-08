using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Banorte.Web.BacktoOffice.AccesoEdificios.DDD.Domain.Entities
{
    public class Base
    {
        [Display(Name = "Id", Description = "Id")]
        public int Id { set; get; }
        [Display(Name = "Titulo", Description = "Title")]
        public string Title { set; get; }
    }
}
