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
                sb.Append("         <label class='form-label' id='lblRuta'>" + ruta.Nombre + "</label><br />");
                sb.Append("         <label class='form-label' id='lblCreador'>" + ruta.Localizacion + "</label>");
                sb.Append("     </div>");
                sb.Append("     <div class='col-3'>");
                sb.Append(" <div id = 'demo' class='carousel slide' data-bs-ride='carousel'>");
                //Indicators/dots;
                sb.Append(" <div class='carousel -indicators'>");
                sb.Append("     <button type = 'button' data-bs-target='#demo' data-bs-slide-to='0' class='active'></button>");
                sb.Append("     <button type = 'button' data-bs-target='#demo' data-bs-slide-to='1'></button>");
                sb.Append("     <button type = 'button' data-bs-target='#demo' data-bs-slide-to='2'></button>");
                sb.Append(" </div>");
                //The slideshow/carousel
                sb.Append(" <div class='carousel -inner'>");
                sb.Append("     <div class='carousel -item active'>");
                sb.Append("         <img src = 'https://www.collinsdictionary.com/images/full/mountain_221506423.jpg' alt='Los Angeles' class='d-block w-100'>");
                sb.Append("         <div class='carousel -caption''>");
                sb.Append("             <h3>Los Angeles</h3>");
                sb.Append("             <p>We had such a great time in LA!</p>");
                sb.Append("         </div>");
                sb.Append("     </div>");
                sb.Append("     <div class='carousel -item'>");
                sb.Append("         <img src = 'https://upload.wikimedia.org/wikipedia/commons/9/96/Barbados_beach.jpg' alt='Chicago' class='d-block w-100'>");
                sb.Append("         <div class='carousel -caption'>");
                sb.Append("             <h3>Los Angeles</h3>");
                sb.Append("             <p>We had such a great time in LA!</p>");
                sb.Append("         </div>");
                sb.Append("     </div>");
                sb.Append("     <div class='carousel -item'>");
                sb.Append("         <img src = 'https://piscinascano.com/wp-content/uploads/2022/07/Piscinas-Cano-PIscina-OLIMPIA-5-Modelo-nuevo-2022-scaled.jpg' alt='New York' class='d-block w-100'>");
                sb.Append("         <div class='carousel -caption'>");
                sb.Append("             <h3>Los Angeles</h3>");
                sb.Append("             <p>We had such a great time in LA!</p>");
                sb.Append("         </div>");
                sb.Append("     </div>");
                sb.Append(" </div>");
                //Left and right controls/icons
                sb.Append(" <button class='carousel -control-prev' type='button' data-bs-target='#demo' data-bs-slide='prev'>");
                sb.Append("     <span class='carousel -control-prev-icon'></span>");
                sb.Append(" </button>");
                sb.Append(" <button class='carousel -control-next' type='button' data-bs-target='#demo' data-bs-slide='next'>");
                sb.Append("     <span class='carousel -control-next-icon'></span>");
                sb.Append(" </button>");
                sb.Append(" </div>");
                sb.Append("     </div>");
                sb.Append(" </div>");

                image1.Src = "https://www.gourmetkebab.es/wp-content/uploads/2021/04/kebab-que-es.jpg";

                /*
                //Carousel
                sb.Append(" <div id = 'demo' class='carousel slide' data-bs-ride='carousel'>");
                //Indicators/dots;
                sb.Append(" <div class='carousel -indicators'>");
                sb.Append("     <button type = 'button' data-bs-target='#demo' data-bs-slide-to='0' class='active'></button>");
                sb.Append("     <button type = 'button' data-bs-target='#demo' data-bs-slide-to='1'></button>");
                sb.Append("     <button type = 'button' data-bs-target='#demo' data-bs-slide-to='2'></button>");
                sb.Append(" </div>");
                //The slideshow/carousel
                sb.Append(" <div class='carousel -inner'>");
                sb.Append("     <div class='carousel -item active'>");
                sb.Append("         <img src = 'https://www.collinsdictionary.com/images/full/mountain_221506423.jpg' alt='Los Angeles' class='d-block w-100'>");
                sb.Append("         <div class='carousel -caption''>");
                sb.Append("             <h3>Los Angeles</h3>");
                sb.Append("             <p>We had such a great time in LA!</p>");
                sb.Append("         </div>");
                sb.Append("     </div>");
                sb.Append("     <div class='carousel -item'>");
                sb.Append("         <img src = 'https://upload.wikimedia.org/wikipedia/commons/9/96/Barbados_beach.jpg' alt='Chicago' class='d-block w-100'>");
                sb.Append("         <div class='carousel -caption'>");
                sb.Append("             <h3>Los Angeles</h3>");
                sb.Append("             <p>We had such a great time in LA!</p>");
                sb.Append("         </div>");
                sb.Append("     </div>");
                sb.Append("     <div class='carousel -item'>");
                sb.Append("         <img src = 'https://piscinascano.com/wp-content/uploads/2022/07/Piscinas-Cano-PIscina-OLIMPIA-5-Modelo-nuevo-2022-scaled.jpg' alt='New York' class='d-block w-100'>");
                sb.Append("         <div class='carousel -caption'>");
                sb.Append("             <h3>Los Angeles</h3>");
                sb.Append("             <p>We had such a great time in LA!</p>");
                sb.Append("         </div>");
                sb.Append("     </div>");
                sb.Append(" </div>");
                //Left and right controls/icons
                sb.Append(" <button class='carousel -control-prev' type='button' data-bs-target='#demo' data-bs-slide='prev'>");
                sb.Append("     <span class='carousel -control-prev-icon'></span>");
                sb.Append(" </button>");
                sb.Append(" <button class='carousel -control-next' type='button' data-bs-target='#demo' data-bs-slide='next'>");
                sb.Append("     <span class='carousel -control-next-icon'></span>");
                sb.Append(" </button>");
                sb.Append(" </div>");
                */

                countElement++;
                ltRutasDisponibles.Text = sb.ToString();
            }
        }
    }
}