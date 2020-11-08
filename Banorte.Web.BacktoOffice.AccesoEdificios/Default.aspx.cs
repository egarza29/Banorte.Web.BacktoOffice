using Banorte.Web.BacktoOffice.AccesoEdificios.DDD.App.Applications;
using Banorte.Web.BacktoOffice.AccesoEdificios.DDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Banorte.Web.BacktoOffice.AccesoEdificios
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private ExternalUser ValidatedUser(string user, string password)
        {
            ExternalUser result = null;
            using (DDD.Infraestructure.Repositories.ExternalUserRepository myrepository = new DDD.Infraestructure.Repositories.ExternalUserRepository())
            {
                AppExternalUser myapp = new AppExternalUser(myrepository);
                result = myapp.FindByUser(user);
            }
            if (result != null)
            {
                if (password != result.Clave)
                    result = null;
            }
            return result;
        }
        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            lblMsg.Text = string.Empty;

            var result = ValidatedUser(txtUserName.Value, txtUserPass.Value);
            if (result!=null) 
            {
                FormsAuthentication.RedirectFromLoginPage(txtUserName.Value, chkPersistCookie.Checked);
                Session.Add("MyInfo", result);
                Response.Redirect("~/Presentation/Default.aspx");
            }

            lblMsg.Text = "Not Autenticated";
        }
    }
}