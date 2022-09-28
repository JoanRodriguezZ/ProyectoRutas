<%@ Page Title="Ruta Seleccionada" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RutaSeleccionada.aspx.cs" Inherits="ProyectoFinalASP.RutaSeleccionada" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">

        <div class="row">

            <div class="col-9" id="map" style="height: 500px;"></div>

            <div class="col-3">
                <asp:Button class="btn btn-outline-primary" Text="Crear Ruta" runat="server" OnClick="Unnamed1_Click" />
                <br />

                <asp:Label class="label" Text="Nombre de la ruta:" runat="server" />
                <br />
                <asp:TextBox class="w-100" runat="server" />
                <br />

                <asp:Label class="label" Text="Descripcion:" runat="server" />
                <br />
                <asp:TextBox class="w-100" TextMode="multiline" runat="server" />
                <br />

                <asp:Label class="label" Text="Cuanto de accesible es la ruta?" runat="server" />
                <br />

                <input class="slider" type="range" name="numAccesibilidad" value="3" placeholder="Valor del 1 al 5" max="5" min="1" /><br />
                <asp:Label class="label" Text="" runat="server" />
                <br />

                <asp:Label class="label" ID="kmTotales" Text="0 Km" runat="server" value="0" />

                <asp:HiddenField ID="coordenadas" runat="server" />
            </div>
        </div>
        <script>

            var HiddenValue = document.getElementById("<%=coordenadas.ClientID%>").value;

            var myObject = eval('(' + document.getElementById("<%=coordenadas.ClientID%>").value + ')');

            var coordInicial1 = myObject[0];
            var coordInicial2 = myObject[1];
            alert(coordInicial1 + " = " + myObject[0]);
            alert(coordInicial2 + " = " + myObject[1]);

            var map = L.map('map').setView([coordInicial2, coordInicial1], 15);

            L.tileLayer('https://tile.openstreetmap.org/{z}/{x}/{y}.png', {
                maxZoom: 19,
                attribution: '© OpenStreetMap'
            }).addTo(map);

            var popup = L.popup();


            var trazado = L.geoJSON().addTo(map);
            var lineaTotal = null;



            var i = 0;
            do {
                var i1 = i + 1;
                var i2 = i + 2;
                var i3 = i + 3;

                lineaTotal = [{
                    "type": "LineString",
                    "coordinates": [[myObject[i], myObject[i1]], [myObject[i2], myObject[i3]]]
                }];

                trazado.addData(lineaTotal);

                i = i + 2;
            } while (i < myObject.length);


        //var myRequest = {
        //    key: 'rutaCheckpoints',  //Pack myRequest with whatever you need
        //    action: 'show',
        //    otherThing: 'blank'
        //};

        ////To send it, you will need to serialize myRequest.  JSON.strigify will do the trick
        //var requestData = JSON.stringify(myRequest);

        //$.ajax({
        //    type: "POST",
        //    url: "RutaSeleccionada.aspx.cs",
        //    data: { inputData: double[] }, //Change inputData to match the argument in your controller method

        //    success: function (response) {
        //        if (response.Status !== "OK") {
        //            alert("Exception: " + response.Status + " |  " + response.Message);
        //        }
        //        else {
        //            //Add code for successful thing here.
        //            //response will contain whatever you put in it on the server side.  
        //            //In this example I'm expecting Status, Message, and MyArray

        //        }
        //    },
        //    failure: function (response) {
        //        alert("Failure: " + response.Status + " |  " + response.Message);
        //    },
        //    error: function (response) {
        //        alert("Error: " + response.Status + " |  " + response.Message);
        //    }
        //});
        </script>
    </div>
</asp:Content>
