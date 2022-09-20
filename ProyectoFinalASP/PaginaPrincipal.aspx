<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PaginaPrincipal.aspx.cs" Inherits="ProyectoFinalASP.PaginaPrincipal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <!-- Required meta tags -->
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>WHEELBRO</title>

    <!-- JQuery -->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js"></script>

    <!-- Bootstrap CSS -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.1/dist/css/bootstrap.min.css"
        rel="stylesheet" integrity="sha384-iYQeCzEYFbKjA/T2uDLTpkwGzCiq6soy8tYaI1GyVh/UjpbCx/TYkiZhlZB6+fzT"
        crossorigin="anonymous">

    <!-- CSS -->
    <link rel="stylesheet" href="./Content/styles.css" />

    <!--Animate  -->
    <link href="https://unpkg.com/aos@2.3.1/dist/aos.css" rel="stylesheet">

    <!-- font-awesome -->
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.1.1/css/all.min.css" />

    <!-- Alerts -->
    <script src="https://unpkg.com/sweetalert/dist/sweetalert.min.js"></script>

</head>
<body>
    <form id="form1" runat="server">

        <!-- NAV -->
        <nav class="navbar navbar-light bg-light menuPrincipal">
            <h1 class="navbar-brand pt-4" id="tituloPagina">WheelBro</h1>
        </nav>

        <div class="sticky-top">
            <ul class="nav justify-content-center  menuPrincipal pb-4" id="listadoPaginas">

                <li class="nav-item">
                    <a class="nav-link" href="./PaginaPrincipal.aspx">Página Principal</a>
                </li>

                <li class="nav-item">
                    <a class="nav-link" href="./Register.aspx">Registrarse</a>
                </li>

                <li class="nav-item">
                    <a class="nav-link" href="./Login.aspx">Iniciar Sesión</a>
                </li>
            </ul>

        </div>

        <!-- Dinamic Content -->
        <div class="row" style="max-width: 100%">

            <div class="col-sm-10 mt-3 mb-3">

                <div id="carouselExampleCaptions" class="carousel slide" data-bs-ride="carousel">
                    <div class="carousel-indicators">
                        <button type="button" data-bs-target="#carouselExampleCaptions" data-bs-slide-to="0" class="active" aria-current="true" aria-label="Slide 1"></button>
                        <button type="button" data-bs-target="#carouselExampleCaptions" data-bs-slide-to="1" aria-label="Slide 2"></button>
                        <button type="button" data-bs-target="#carouselExampleCaptions" data-bs-slide-to="2" aria-label="Slide 3"></button>
                    </div>
                    <div class="carousel-inner">
                        <div class="carousel-item active">
                            <img src="https://sc.wklcdn.com/homemap/332681.jpg" class="d-block w-100" alt="...">
                            <div class="carousel-caption d-none d-md-block">
                                <h5>First slide label</h5>
                                <p>Some representative placeholder content for the first slide.</p>
                            </div>
                        </div>
                        <div class="carousel-item">
                            <img src="https://sc.wklcdn.com/homemap/1921553.jpg" class="d-block w-100" alt="...">
                            <div class="carousel-caption d-none d-md-block">
                                <h5>Second slide label</h5>
                                <p>Some representative placeholder content for the second slide.</p>
                            </div>
                        </div>
                        <div class="carousel-item">
                            <img src="https://sc.wklcdn.com/homemap/1923871.jpg" class="d-block w-100" alt="...">
                            <div class="carousel-caption d-none d-md-block">
                                <h5>Third slide label</h5>
                                <p>Some representative placeholder content for the third slide.</p>
                            </div>
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

            <div class="col-sm-2 mt-3 mb-3">
                <p style="text-align: center">Chat</p>
            </div>
        </div>

        <div class="row" style="max-width: 100%">
            <div class="container">
                <div class="col-sm-12" style="text-align:center">
                    <img src="https://www.mexicodesconocido.com.mx/sites/default/files/styles/adaptive/public/fichas-destino/ciudad-mexico-recorrido-silla-ruedas-roma-condesa-entrada.jpg"/>
                    <p style="text-align: center">¡Regístrate y disfruta de nuestra comunidad! :)</p>
                </div>
            </div>
        </div>

        <!-- Botones para testear
    <div class="p-4 m-4">
        <button onclick="crearSesion()">Crear</button>
        <button onclick="mostrar()">Mostrar</button>
        <button onclick="modificar()">Modificar</button>
        <button onclick="cerrarSesion()">Elminar</button>
    </div>
    -->

        <!-- Floor content -->
        <div class=" fixed-bottom" id="footer">
            <p id="textoFooter" style="color: rgb(231, 231, 231);" class="text-center p-1">
                Todos los derechos reservados
            2022
            @ Copyright
            </p>
        </div>

        <script src="./js/register.js"></script>
        <script src="./js/login.js"></script>

        <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.1/dist/js/bootstrap.bundle.min.js"
            integrity="sha384-u1OknCvxWvY5kfmNBILK2hRnQC3Pr17a+RTT6rIHI7NnikvbZlHgTPOOmMi466C8"
            crossorigin="anonymous"></script>

    </form>
</body>
</html>
