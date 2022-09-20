using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyectoFinalASP.DAL;
using ProyectoFinalASP.Modelos;

namespace ProyectoFinalASP
{
    public partial class Login : System.Web.UI.Page
    {
        DALUsuario dalUsuario = new DALUsuario();

        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            
            string loginEmail;
            string loginPassword;
            loginEmail = emailBox.Text;
            loginPassword = passwordBox.Text;
            Usuario usuario = dalUsuario.SelectUsuarioByEmailPassword(loginEmail, loginPassword);
            
            if (usuario != null)
            {
                labelEmailPassword.Text ="Credenciales correctas";
            }
            else labelEmailPassword.Text = "Credenciales incorrectas";

        }
    }
}