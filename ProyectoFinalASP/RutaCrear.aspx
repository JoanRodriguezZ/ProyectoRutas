<%@ Page Title="Ruta" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RutaCrear.aspx.cs" Inherits="ProyectoFinalASP.RutaCrear" %>

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

    <asp:HiddenField ID="pAlngHTML" runat="server" />
    <asp:HiddenField ID="pAlatHTML" runat="server" />
    <asp:HiddenField ID="pBlngHTML" runat="server" OnValueChanged="pBlngHTML_ValueChanged" />
    <asp:HiddenField ID="pBlatHTML" runat="server" />

    <script src="Scripts/rutaseleccionada.js"></script>
</asp:Content>