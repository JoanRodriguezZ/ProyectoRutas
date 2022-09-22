using ProyectoFinalASP.DAL;
using ProyectoFinalASP.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinalASP
{
    public partial class EventosDisponibles : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //List<Evento> eventos = new List<Evento>();
            //DALEvento eventoDal = new DALEvento();
            List<Usuario> usuarios = new List<Usuario>();
            DALUsuario usuarioDal = new DALUsuario();
            StringBuilder sb = new StringBuilder();
            
            usuarios = usuarioDal.SelectUsuariosOrderByNombreApellidos();
            foreach (var usuario in usuarios)
            {
                sb.Append("<div class='row'>"+ usuario.Telefono + "</div>");
                
                lblCreador.InnerText = usuario.Nombre;
            }
            ltTry.Text = sb.ToString();
        }
    }
}