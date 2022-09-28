<%@ Page Title="Eventos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EventosDisponibles.aspx.cs" Inherits="ProyectoFinalASP.EventosDisponibles" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">

        <asp:Literal ID="ltEventosDisponibles" runat="server" />

        <div class="modal fade" id="modalMapaRuta" tabindex="-1" role="dialog" aria-labelledby="modalMapaRutaLabel" aria-hidden="true">
            <div class="modal-dialog" role="document">
                <div class="modal-content">
                    <div class="modal-header">
                        <h5 class="modal-title">Mapa de la ruta</h5>
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span>
                    </button>
                    </div>
                        <div class="modal-body">
                        <p>Modal body text goes here.</p>
                    </div>
                        <div class="modal-footer">
                        <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
                    </div>
                </div>
            </div>
        </div>
        <button type='button' class='btn btn-outline-dark' data-toggle='modal' data-target='#modalMapaRuta' id='btnVerRuta'>Modal</button>

        <script>
            /*
            var span = document.getElementsByClassName('close')[0];
            var modal = document.getElementById('myModal');
            var image = document.getElementById('modalImage');
            //Ir Evento concreto
            function irEvento(idEvento)
            {
                window.location.href = '/EventoSeleccionado.aspx?id=' + idEvento;
            }
            //Ver modal
            function verMapaRuta() {
                modal.style.display = 'block';
            } 
            */
        </script>
    </div>
</asp:Content>

