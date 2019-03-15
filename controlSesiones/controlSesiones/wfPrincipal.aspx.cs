using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace controlSesiones
{
    public partial class wfPrincipal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] == null)
            {
                Response.Redirect("wfLogin.aspx");
            }
            else
            {
                lblUser.Text = Convert.ToString(Session["usuario"]);
            }
        }

        protected void btnSalir_Click(object sender, EventArgs e)
        {
            Session.Remove("usuario");
            Session["intentos"] = 0;
            Response.Redirect("wfLogin.aspx");
        }
    }
}