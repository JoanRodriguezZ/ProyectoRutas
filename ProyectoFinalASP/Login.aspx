<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ProyectoFinalASP.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <!-- Required meta tags -->
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title id="titleRPage">Registro</title>

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
            <h1 class="navbar-brand pt-4" id="tituloPagina">Ui Proyect</h1>
        </nav>

        <div class="sticky-top">
            <ul class="nav justify-content-center  menuPrincipal pb-4 " id="listadoPaginas">

                <li class="nav-item">
                    <a id="textoRegister" class="nav-link" href="./Register.aspx">REGISTRARSE</a>
                </li>

                <li class="nav-item">
                    <a id="textoLogin" class="nav-link" href="./Login.aspx">INICIAR SESION</a>
                </li>

                <img onclick="localStorage.setItem('idioma', 'es'); idioma();" src="./img/spain.png" height="40px"
                    style="cursor: pointer;" class="imgIdioma">

                <img onclick="localStorage.setItem('idioma', 'en'); idioma();" src="./img/united-kingdom.png" height="40px"
                    style="cursor: pointer; margin-left: 10px;" class="imgIdioma">
            </ul>

        </div>

        <!-- Dinamic Content -->
        <div class="container">
            <div class="row justify-content-center">
                <div class="col-sm-4 mt-5 mb-5">
                    <h4 id="textoLTitle" class="center">Iniciar sesión</h4>

                    <form>

                        <div class="pt-1 pb-3">
                            <label id="textoLEmail" for="email" class="form-label">Email</label>
                            <input type="email" class="form-control" id="email" required>
                        </div>

                        <div class="pt-1 pb-3">
                            <label id="textoLPass" for="password" class="form-label">Password</label>
                            <input type="password" class="form-control" id="password" required>
                        </div>

                    </form>

                    <button id="textoLBtnSubmit" onclick="validarLogin()" class="btn btn-primary d-block m-auto">
                        Iniciar
                    sesión</button>

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
            @Copyright
            </p>
        </div>

        <script src="./js/register.js"></script>
        <script src="./js/login.js"></script>

        <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.1/dist/js/bootstrap.bundle.min.js"
            integrity="sha384-u1OknCvxWvY5kfmNBILK2hRnQC3Pr17a+RTT6rIHI7NnikvbZlHgTPOOmMi466C8"
            crossorigin="anonymous"></script>

        <script src="./js/preferedLanguage.js"></script>
        <script>idioma()</script>
    </form>
</body>
</html>
