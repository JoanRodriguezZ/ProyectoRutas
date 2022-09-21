<%@ Page Title="Ruta" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RutaSeleccionada.aspx.cs" Inherits="ProyectoFinalASP.RutaSeleccionada" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <div id="map" style="height:500px;"></div>

    <div id="mapInfo" runat="server" hidden></div>

    <script src="Scripts/rutaseleccionada.js"></script>
</asp:Content>