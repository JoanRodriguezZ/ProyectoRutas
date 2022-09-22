<%@ Page Title="Ruta" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RutaSeleccionada.aspx.cs" Inherits="ProyectoFinalASP.RutaSeleccionada" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <div id="map" style="height:500px;"></div>
    <asp:HiddenField ID="pAlngHTML" runat="server" />
    <asp:HiddenField ID="pAlatHTML" runat="server" />
    <asp:HiddenField ID="pBlngHTML" runat="server" />
    <asp:HiddenField ID="pBlatHTML" runat="server" />

    <script src="Scripts/rutaseleccionada.js"></script>
</asp:Content>