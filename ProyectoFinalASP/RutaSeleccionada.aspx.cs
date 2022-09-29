using System;
using System.Collections.Generic;
using System.Web.Script.Serialization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyectoFinalASP.Modelos;

namespace ProyectoFinalASP
{
    public partial class RutaSeleccionada : System.Web.UI.Page
    {
        DAL.DALPuntoDeControl puntoDeControlDal = new DAL.DALPuntoDeControl();
        
        
        List<decimal> coordenadasList = new List<decimal>();

        int idRutaSeleccionada;

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                idRutaSeleccionada = Int32.Parse(Request["id"]);
            }
            catch (ArgumentNullException ex)
            {
                Response.Redirect("RutasDisponibles");
            }
            
            List<PuntoDeControl> puntosDeControl = puntoDeControlDal.SelectPuntosDeControlByIdRuta(idRutaSeleccionada);
            foreach (var checkpoint in puntosDeControl)
            {
                coordenadasList.Add(checkpoint.Point);
            }

            JavaScriptSerializer ser = new JavaScriptSerializer();
            coordenadas.Value = ser.Serialize(coordenadasList);

        }

    }
}