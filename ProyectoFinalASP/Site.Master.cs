using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinalASP
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie reqCookies = Request.Cookies["userInfo"];
            if (reqCookies != null)
            {
                string username = reqCookies["username"];
                string surname = reqCookies["surname"];
                textoUserLogin.Text = "Bienvenido, " + username + " " + surname;
            }

            
        }
    }
}