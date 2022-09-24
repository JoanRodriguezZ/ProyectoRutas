using ProyectoFinalASP.DAL;
using ProyectoFinalASP.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;

namespace ProyectoFinalASP
{
    public partial class RutasDisponibles : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            DALRuta rutaDal = new DALRuta();
            List<Ruta> rutas = new List<Ruta>();
            int countElement = 0;

            rutas = rutaDal.SelectRutasOrderByLocalizacion();
            foreach (var ruta in rutas)
            {
                sb.Append(" <div id='base' class='row border'>");
                sb.Append("     <div class='col-3'>");
                sb.Append("         <label class='form-label' id='lblRuta'>" + ruta.Nombre + "</label><br />");
                sb.Append("         <label class='form-label' id='lblCreador'>" + ruta.Localizacion + "</label>");
                sb.Append("     </div>");
                sb.Append(" </div>");

                countElement++;
                ltRutasDisponibles.Text = sb.ToString();
            }
        }
    }
}