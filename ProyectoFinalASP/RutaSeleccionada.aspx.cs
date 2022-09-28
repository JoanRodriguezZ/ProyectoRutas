using System;
using System.Collections.Generic;
using System.Web.Script.Serialization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinalASP
{
    public partial class RutaSeleccionada : System.Web.UI.Page
    {
        List<Double> checkpoints = new List<Double>();

        protected void Page_Load(object sender, EventArgs e)
        {
            checkpoints.Add(2.154876);
            checkpoints.Add(41.441045);
            checkpoints.Add(2.15302);
            checkpoints.Add(41.441709);
            checkpoints.Add(2.152897);
            checkpoints.Add(41.442409);
            checkpoints.Add(2.153605);
            checkpoints.Add(41.443414);
            checkpoints.Add(2.153782);
            checkpoints.Add(41.445115);
            checkpoints.Add(2.152328);
            checkpoints.Add(41.446116);
            checkpoints.Add(2.15214);
            checkpoints.Add(41.44719);
            checkpoints.Add(2.153417);
            checkpoints.Add(41.448513);

            JavaScriptSerializer ser = new JavaScriptSerializer();
            coordenadas.Value = ser.Serialize(checkpoints);

        }

    }
}