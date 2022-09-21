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
            string loginEmail = emailBox.Text;
            string loginPassword = passwordBox.Text;

            // Hash
            string hashedPassword = Hash.SecurePasswordHasher.Hash(loginPassword);

            //Verify
            bool result = Hash.SecurePasswordHasher.Verify(loginPassword, hashedPassword);

            if (result)
            {
                /*Usuario usuario = dalUsuario.SelectUsuarioByEmailPassword(loginEmail);

                
                if (usuario != null)
                {
                    labelEmailPassword.Text ="Credenciales correctas";
                }
                else labelEmailPassword.Text = "Credenciales incorrectas"; 
                */
            }

        }
    }
}