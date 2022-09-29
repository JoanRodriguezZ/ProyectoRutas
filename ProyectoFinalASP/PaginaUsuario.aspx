<%@ Page Title="Mi Perfil" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PaginaUsuario.aspx.cs" Inherits="ProyectoFinalASP.PaginaUsuario" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">

        <asp:Literal ID="ltPaginaUsuario" runat="server" />

        <script>
            //Ir Evento concreto
            function irEvento(idEvento)
            {
                window.location.href = '/EventoSeleccionado.aspx?id=' + idEvento;
            }
            
        </script>
    </div>
</asp:Content>
