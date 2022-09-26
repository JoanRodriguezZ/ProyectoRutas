<%@ Page Title="EventoSeleccionado" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EventoSeleccionado.aspx.cs" Inherits="ProyectoFinalASP.EventoSeleccionado" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <asp:Literal ID = "ltEventoSeleccionado" runat = "server" />

    <div class="row">
        <div class="col-8">
            <div class="row">
                <div class="col-10">
                    <asp:TextBox ID="textoMensaje" class="w-100" placeholder="Escribe aqui tu mensaje" runat="server"></asp:TextBox>
                </div>
                <div class="col-2">
                    <asp:Button Text="Enviar" class="btn btn-outline-dark w-100" runat="server" ID="enviarMensaje" OnClick="enviarMensaje_Click"/>
                </div>
            </div>
        </div>
        <div class='col-4'>
        </div>
    </div>
</asp:Content>
