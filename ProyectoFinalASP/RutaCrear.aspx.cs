using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinalASP
{
    public partial class RutaCrear : Page
    {
        List<float[,]> coordsList = new List<float[,]>();

        float coord1X;
        float coord1Y;
        float coord2X;
        float coord2Y;


        protected void Page_Load(object sender, EventArgs e)
        {

            string pAlngCS = pAlngHTML.Value;
            string pAlatCS = pAlatHTML.Value;

            string pBlngCS = pBlngHTML.Value;
            string pBlatCS = pBlatHTML.Value;

            if (coord1X != 0)
            {

                coord1X = float.Parse(pAlngCS);
                coord1Y = float.Parse(pAlatCS);
                coord2X = float.Parse(pBlatCS);
                coord2Y = float.Parse(pBlatCS);


                float[,] coordLinea = { { coord1X, coord1Y }, { coord2X, coord2Y } };

                coordsList.Add(coordLinea);
            }
            

        }


    }
}

//Layer layer = Json.Convert.DeserializeObject<Layer>(jsonString);
//public class Layer {
//public string a { get; set; }