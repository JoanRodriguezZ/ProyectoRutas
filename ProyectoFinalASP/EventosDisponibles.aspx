<%@ Page Title="Eventos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EventosDisponibles.aspx.cs" Inherits="ProyectoFinalASP.EventosDisponibles" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <asp:Literal ID = "ltEventosDisponibles" runat = "server" />
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

