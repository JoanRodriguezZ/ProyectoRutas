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
    public partial class RegisterManual : System.Web.UI.Page
    {
        DALUsuario dalUsuario = new DALUsuario();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Hash
            string hashedPassword = Hash.SecurePasswordHasher.Hash((string)Session["password"]);

            Usuario user = new Usuario(hashedPassword, usernameBox.Text, surnameBox.Text, (string)Session["email"], phoneBox.Text, localidadBox.Text, int.Parse(porcentajeMinusBox.Text), tipoMinusvaliaBox.Text, dependenciaBox.Text, esMinusvalidoCheckBox.Checked, esVoluntarioCheckBox.Checked, false);
            dalUsuario.InsertUsuario(user);
        }
    }
}