using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace controlSesiones
{
    public partial class wfIndex : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] != null)
            {
                Response.Redirect("wfPrincipal.aspx");
            }
            if (!IsPostBack)
            {
                lblContador.Text = "0";
                Session["intentos"] = 0;
                lblMensaje.Text = "0";
                btnIngresar.Enabled = true;
            }
        }

        protected void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "yo" && txtPass.Text == "123")
            {
                Session["usuario"] = txtUser.Text;
                Response.Redirect("wfPrincipal.aspx");
            }
            else
            {
                if (Session[txtUser.Text] == null)
                {
                    Session[txtUser.Text] = 1;
                    lblMensaje.Visible = true;
                    lblMensaje.Text = "ERROR # 1, Usuario y/o Password incorrectos al 5to error se limpiarán campos";
                }
                else
                {
                    int c = Convert.ToInt32(Session[txtUser.Text]);
                    c++;
                    Session[txtUser.Text] = c;
                    lblMensaje.Visible = true;
                    if (c >= 5)
                    {
                        txtUser.Text = "";
                        txtPass.Text = "";
                        txtUser.Enabled = false;
                        txtPass.Enabled = false;
                        btnIngresar.Enabled = false;
                        lblMensaje.Text = "USUARIO BLOQUEADO, comuniquese con el administrador";
                    }
                    else
                        lblMensaje.Text = "ERROR #" + c + ", Usuario y/o Password incorrectos";
                }
            }
            
        }
    }
}