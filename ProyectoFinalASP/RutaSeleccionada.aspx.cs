using System;
using System.Collections.Generic;
using System.Web.Script.Serialization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyectoFinalASP.Modelos;
using System.Text;
using ProyectoFinalASP.DAL;

namespace ProyectoFinalASP
{
    public partial class RutaSeleccionada : System.Web.UI.Page
    {
        StringBuilder sbDatosRuta = new StringBuilder();
        StringBuilder sbEventos = new StringBuilder();
        StringBuilder sbDescripcion = new StringBuilder();
        DALEvento eventoDal = new DALEvento();
        DALRuta rutaDal = new DALRuta();
        Ruta ruta = new Ruta();
        List<Evento> eventos = new List<Evento>();
        DALPuntoDeControl puntoDeControlDal = new DALPuntoDeControl();
        
        
        List<decimal> coordenadasList = new List<decimal>();

        int idRutaSeleccionada;

        protected void Page_Load(object sender, EventArgs e)
        {
            idRutaSeleccionada = Int32.Parse(Request.QueryString["id"]);
            

            List<PuntoDeControl> puntosDeControl = puntoDeControlDal.SelectPuntosDeControlByIdRuta(idRutaSeleccionada);
            foreach (var checkpoint in puntosDeControl)
            {
                coordenadasList.Add(checkpoint.Point);
            }

            JavaScriptSerializer ser = new JavaScriptSerializer();
            coordenadas.Value = ser.Serialize(coordenadasList);

            //DATOS RUTA

            ruta = rutaDal.SelectRutaByIdRuta(idRutaSeleccionada);
            sbDatosRuta.Append("        <label class='form-label' id='lblRuta'>" + ruta.Nombre + " |</label>");
            sbDatosRuta.Append("        <label class='form-label' id='lblLongitud'> " + ((int)ruta.LongitudKm) + " km |</label>");
            sbDatosRuta.Append("        <label class='form-label' id='lblValoracion'> Valoracion " + ruta.ValoracionMedia + " |</label>");
            sbDatosRuta.Append("        <label class='form-label' id='lblAccesibilidad'> Accesibilidad: " + ruta.NivelAccesibilidad + "</label>");
            ltDatosRuta.Text = sbDatosRuta.ToString();

            //EVENTOS RUTA
            sbEventos.Append(" <ul class='list-group list-group-flush'>");
            sbEventos.Append("     <li class='list-group-item'><b>Eventos</b></li>");
            eventos = eventoDal.SelectEventosByRuta(idRutaSeleccionada);
            foreach (var evento in eventos)
            {
                sbEventos.Append("     <li class='list-group-item'>" + evento.FechaDeRealizacion.Value.ToString("dd/MM/yyyy HH:mm") + "</li>");
            }
            sbEventos.Append(" </ul>");
            ltEventosRuta.Text = sbEventos.ToString();

            //DATOS2 RUTA
            sbDescripcion.Append(" <div id='base' class='row'>");
            sbDescripcion.Append("      <label class='form-label' id='lblDescripcion'>" + ruta.Descripcion + "</label><br />");
            sbDescripcion.Append(" </div>");
            ltDescripcion.Text = sbDescripcion.ToString();
        }

    }
}