using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinalASP
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnContinuarRegistro_Click(object sender, EventArgs e)
        {
            Session["email"] = emailBox.Text;
            Session["password"] = passwordBox.Text;
            Response.Redirect("RegisterManual");
        }
    }
}