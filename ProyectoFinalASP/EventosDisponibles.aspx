<%@ Page Title="EventosDisponibles" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EventosDisponibles.aspx.cs" Inherits="ProyectoFinalASP.EventosDisponibles" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <label id="lblLoad" onclick="fill();">Load</label>
    <div id="allDivsEvents">
        <div id="base" class="row border">
            <div class="col-3">
                <label class="form-label" id="lblRuta">Ruta</label><br />
                <button class="btn btn-outline-dark" id="verRuta">Ver</button><br />
                <label runat="server" class="form-label" id="lblCreador">Usuario Creador</label>
            </div>
            <div class="col-3">
                <label class="form-label" id="lblKm">Km: </label><br />
                <label class="form-label" id="lblDesnivel">Desnivel: </label><br />
                <label class="form-label" id="lblAccesibilidad">Accesibilidad: </label><br />
                <label class="form-label" id="lblValoracion">Valoracion: </label>
            </div>
            <div class="col-3">
                <label class="form-label" id="numUsuarios">Numero Usuarios</label><br />
                <label class="form-label" id="numVoluntarios">Numero Voluntarios</label><br />
            </div>
            <div class="col-3">
                <label class="form-label" id="lblFecha">Fecha</label><br />
                <label class="form-label" id="lblHora">Hora</label><br />
                <button class="btn btn-outline-dark" id="btnJoin">JOIN</button>
            </div>
        </div>
    </div>
    <asp:Literal ID = "ltTry" runat = "server" />
    <script>
        //Funcion para copiar el div formato basico y generarlo 4 veces mas
        //Pero como no sabemos cuantas veces lo vamos a necesitar tendremos que hacerlo desde otro lado que tengamos datos de SQL
        /*
        function fill() {
            var doc = document.getElementById("allDivsEvents");
            for (var i = 0; i < 4; i++) {
                var newD = document.createElement("div");
                newD.id = "div" + i;
                newD.className = "row border";
                doc.appendChild(newD);
                document.getElementById("div" + i).innerHTML = document.getElementById("base").innerHTML
            }            
        }
        */
        
    </script>
</asp:Content>

