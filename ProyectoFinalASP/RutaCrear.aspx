﻿<%@ Page Title="Ruta" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RutaCrear.aspx.cs" Inherits="ProyectoFinalASP.RutaCrear" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <div class="row">

        <div class="col-9" id="map" style="height:500px;"></div> 

        <div class="col-3">
            <asp:Button class="btn btn-outline-primary" Text="Crear Ruta" runat="server" /> <br />

            <asp:Label class="label" Text="Nombre de la ruta:" runat="server" /> <br />
            <asp:TextBox class="w-100" runat="server" /> <br />   
            
            <asp:Label class="label" Text="Descripcion:" runat="server" /> <br />
            <asp:TextBox class="w-100" TextMode="multiline" runat="server" /> <br />  
            
            <asp:Label class="label" Text="Cuanto de accesible es la ruta?" runat="server" /> <br />  

            <input class="slider" type="range" name="numAccesibilidad" value="3" placeholder="Valor del 1 al 5" max="5" min="1"/><br />
            <asp:Label class="label" Text="" runat="server" /> <br />  

            <asp:Label class="label" ID="kmTotales" Text="0 Km" runat="server" value="0" />
        </div>
    </div>

    <label Text="" id="pBlngHTML1" runat="server" hidden/>
    <asp:HiddenField ID="pAlngHTML" runat="server"/>
    <asp:HiddenField ID="pAlatHTML" runat="server" value=""/>
    <asp:HiddenField ID="pBlngHTML" runat="server" value="" OnValueChanged="pBlngHTML_ValueChanged" />
    <asp:HiddenField ID="pBlatHTML" runat="server" value=""/>
    <script>

        //Inicializa el mapa en las coordenadas indicadas.
        var map = L.map('map').setView([41.3945, 2.169594], 13);

        L.tileLayer('https://tile.openstreetmap.org/{z}/{x}/{y}.png', {
            maxZoom: 19,
            attribution: '© OpenStreetMap'
        }).addTo(map);

        //Funcion para abrir un popup que indique las coordenadas exactas de donde se clica
        var popup = L.popup();

        map.on('click', onMapClick);

        var trazado = L.geoJSON().addTo(map);

        var puntoA = null;
        var puntoB = null;
        var lineaTotal = null;

        var pAlat = null;
        var pAlng = null;
        var pBlat = null;
        var pBlng = null;

        var coordenadaA = null;
        var coordenadaB = null;


        var coordAlng = document.getElementById('<%=pAlngHTML.ClientID%>');
        var coordAlat = document.getElementById('<%=pAlatHTML.ClientID%>');


        var coordBlng = document.getElementById('<%=pBlngHTML.ClientID%>');
        var coordBlat = document.getElementById('<%=pBlatHTML.ClientID%>');

        alert(coordBlng);

        var puntoSalida = null;

        var marker = null;

        function onMapClick(e) {

            puntoB = puntoA;
            puntoA = e.latlng;

            if (puntoA == null || puntoB == null) {
                pAlat = puntoA.lat;
                pAlng = puntoA.lng;
                marker = L.marker([pAlat, pAlng]).addTo(map)
                    .bindPopup('Punto de salida')
                    .openPopup();

                trazado.addData(marker);


            } else {
                pAlat = puntoA.lat;
                pAlng = puntoA.lng;
                pBlat = puntoB.lat;
                pBlng = puntoB.lng;

                lineaTotal = [{
                    "type": "LineString",
                    "coordinates": [[pAlng, pAlat], [pBlng, pBlat]]
                }];


                trazado.addData(lineaTotal);

                //L.geoJSON(lineaTotal).addTo(map);

            }

            alert("CoordBlng: " + coordBlng.Value + ". pBlng: " + pBlng);

            coordAlng.Value = pAlng;
            coordAlat.Value = pAlat;
            coordBlng.Value = pBlng;
            coordBlat.Value = pBlat;

            alert("CoordBlng: " + coordBlng.Value + ". pBlng: " + pBlng);


            //L.geoJSON(myLines).addTo(map);
        }


//var patientString = JSON.stringify(trazado);
//var mapInfoHTML = document.getElementById('mapInfo');
//mapInfoHTML.value = patientString;


//$.ajax({
//    url: '/Home/GetBranch',
//    success: function (data) {
//        console.log(data)
//        $(data).each(function (index, item) {
//            var lat = item.branchGeoLocationLat;
//            var long = item.branchGeoLocationLong;
//            L.marker([lat, long], { icon: greenIcon }).bindPopup("I am the " + item.branchName + " leaf.").addTo(map);
//        });
//    },
//});
    </script>

<%--    <script src="Scripts/rutaseleccionada.js"></script>--%>
</asp:Content>