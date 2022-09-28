using Microsoft.Ajax.Utilities;
using ProyectoFinalASP.DAL;
using ProyectoFinalASP.Modelos;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Shapes;
using System.Xml.Linq;

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
                sb.Append("         <label class='form-label' id='lblLongitud'>" + ((int)ruta.LongitudKm) + " km |</label>");
                sb.Append("         <label class='form-label' id='lblValoracion'> Valoracion " + ruta.ValoracionMedia + "</label><br />");
                sb.Append("     </div>");
                sb.Append("     <div class='col-3'>");
                sb.Append("         <label class='form-label' id='lblDescripcion'>" + ruta.Descripcion + "</label>");
                sb.Append("     </div>");
                sb.Append("     <div class='col-3'>");
                sb.Append("         <label class='form-label' id='lblLocalizacion'>" + ruta.Localizacion + "</label>");
                sb.Append("         <asp:Button class='btn btn-outline-dark' OnClick='btnVerRuta_Click' runat='server' ID='btnVerRuta' Text='Ver Ruta'/><br />");
                sb.Append("         <asp:HiddenField ID='idRuta"+ ruta.IdRuta  +"' runat='server' Value='"+ ruta.IdRuta +"'>");
                sb.Append("     </div>");
                sb.Append("     <div class='col-3'>");
                sb.Append("         <img src='/Media/"+ ruta.ImageZone + "' class='img-thumbnail' alt='" + ruta.Descripcion +"'>");
                sb.Append("     </div>");
                sb.Append(" </div>");

                countElement++;
                ltRutasDisponibles.Text = sb.ToString();
            }
        }
        protected void btnVerRuta_Click(object sender, EventArgs e)
        {
            
        }

    }
}