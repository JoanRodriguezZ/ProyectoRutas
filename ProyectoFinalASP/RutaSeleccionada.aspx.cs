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
        //public Double[] checkpoints = new Double[] { 2.2932991, 43.3482921, 2.4943912, 43.4943912, 2.5943912, 43.8943912 };

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

        //[HttpPost]
        //public JsonResult RecogerPuntosdeControl(string inputData)//JSON should contain key, action, otherThing
        //{
        //    JsonResult RetVal = new JsonResult();  //We will use this to pass data back to the client

        //    try
        //    {
        //        var JSONObj = new JavaScriptSerializer().Deserialize<Dictionary<string, string>>(inputData);
        //        string RequestKey = JSONObj["rutaCheckpoints"];
        //        string RequestAction = JSONObj["show"];
        //        string RequestOtherThing = JSONObj["blank"];

        //        //Use your request information to build your array
        //        //You didn't specify what kind of array, but it works the same regardless.
        //        Double[] ResponseArray = checkpoints;

        //        //populate array here

        //        //Write out the response
        //        RetVal = Json(new
        //        {
        //            Status = "OK",
        //            Message = "Response Added",
        //            MyArray = ResponseArray
        //        });
        //    }
        //    catch (Exception ex)
        //    {
        //        //Response if there was an error
        //        RetVal = Json(new
        //        {
        //            Status = "ERROR",
        //            Message = ex.ToString(),
        //            MyArray = new int[0]
        //        });
        //    }
        //    return RetVal;
        //}
    }
}