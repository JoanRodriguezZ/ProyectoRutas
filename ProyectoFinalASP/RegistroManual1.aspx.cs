using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinalASP
{
    public partial class RegistroManual1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnContinuarRegistro_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegisterManual2");
        }
    }
}