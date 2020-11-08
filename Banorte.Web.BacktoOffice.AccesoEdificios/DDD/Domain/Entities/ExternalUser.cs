using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Banorte.Web.BacktoOffice.AccesoEdificios.DDD.Domain.Entities
{
    [Description("Usuarios externos")]
    [DisplayName("BAR_ExternalUsr")]
    public class ExternalUser : SharepointBase
    {
        [Display(Name = "Usuario", Description = "Email")]
        public string Email { set; get; }//Una línea de texto
        [Display(Name = "Foto", Description = "Photo")]
        public string Photo { set; get; }//Hipervínculo o imagen
        [Display(Name = "Aprobador", Description = "Approver")]
        public SharepointUser Approver { set; get; }//Persona o grupo
        [Display(Name = "Departamento", Description = "Department")]
        public string Department { set; get; }//Una línea de texto
        [Display(Name = "Compañia", Description = "Company")]
        public string Company { set; get; }//Una línea de texto
        [Display(Name = "Puesto", Description = "Position")]
        public string Position { set; get; }//Una línea de texto
        [Display(Name = "Password", Description = "Clave")]
        public string Clave { set; get; }//Una línea de texto
    }
}
