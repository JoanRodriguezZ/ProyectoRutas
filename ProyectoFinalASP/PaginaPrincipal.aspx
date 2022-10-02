<%@ Page Title="MoviRutas" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PaginaPrincipal.aspx.cs" Inherits="ProyectoFinalASP.PaginaPrincipal" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <!-- Dinamic Content -->
    <div class="row mt-3" style="max-width: 100%">

        <div class="col-sm-1"></div>
        <div class="col-sm-10">

            <h4>Disfruta creando y explorando nuevas rutas</h4>

            <div id="carouselExampleCaptions" class="carousel slide border border-4 rounded" data-bs-ride="carousel">
                <div class="carousel-indicators">
                    <button type="button" data-bs-target="#carouselExampleCaptions" data-bs-slide-to="0" class="active" aria-current="true" aria-label="Slide 1"></button>
                    <button type="button" data-bs-target="#carouselExampleCaptions" data-bs-slide-to="1" aria-label="Slide 2"></button>
                    <button type="button" data-bs-target="#carouselExampleCaptions" data-bs-slide-to="2" aria-label="Slide 3"></button>
                </div>
                <div class="carousel-inner">
                    <div class="carousel-item active">
                        <img src="https://sc.wklcdn.com/homemap/332681.jpg" class="d-block w-100" alt="...">
                    </div>
                    <div class="carousel-item">
                        <img src="https://sc.wklcdn.com/homemap/1921553.jpg" class="d-block w-100" alt="...">
                    </div>
                    <div class="carousel-item">
                        <img src="https://sc.wklcdn.com/homemap/1923871.jpg" class="d-block w-100" alt="...">
                    </div>
                </div>
                <button class="carousel-control-prev" type="button" data-bs-target="#carouselExampleCaptions" data-bs-slide="prev">
                    <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                    <span class="visually-hidden">Previous</span>
                </button>
                <button class="carousel-control-next" type="button" data-bs-target="#carouselExampleCaptions" data-bs-slide="next">
                    <span class="carousel-control-next-icon" aria-hidden="true"></span>
                    <span class="visually-hidden">Next</span>
                </button>
            </div>
        </div>
        <div class="col-sm-1"></div>

    </div>

    <div class="row mt-3" style="max-width: 100%">
        <div class="col-md-1"></div>
        <div class="col-md-7 ">
            <h4>¡<asp:HyperLink class="justify-content-center" href="./Register.aspx" runat="server">Regístrate</asp:HyperLink>
                ahora y disfruta de nuestra comunidad! :)</h4>
            <div class="border border-4 rounded" style="width: 85%" onclick="window.location.href = 'Register.aspx'">
                <img src="./Content/gente_silla_ruedas.png" style="width: 100%; height: auto; cursor:pointer" />
            </div>
            <br />
        </div>
        <div class="col-md-3">
            <h4 class="ms-5">Chatea y queda con otros usuarios</h4>
            <div class="border border-4 rounded" style="width: 90%; float:right;" onclick="window.location.href = 'EventosDisponibles.aspx'">
                <img src="./Content/imagen_chat.png" style="width: 100%; height: auto; cursor:pointer"; />
            </div>
        </div>
    </div>
    <div class="col-md-1"></div>
</asp:Content>
