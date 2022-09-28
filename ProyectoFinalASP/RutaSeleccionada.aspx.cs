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

        Uri uri;

        int idRutaSeleccionada;

        //int idRutaSeleccionada = (int)Session['idRutaSeleccionada'].ToString();

        protected void Page_Load(object sender, EventArgs e)
        {
            idRutaSeleccionada = Int32.Parse(Request["id"]);
            

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