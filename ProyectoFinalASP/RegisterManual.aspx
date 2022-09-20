<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterManual.aspx.cs" Inherits="ProyectoFinalASP.RegisterManual" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <!-- Required meta tags -->
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Registro</title>

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
            <h1 class="navbar-brand pt-4" id="tituloPagina">Registro</h1>
        </nav>

        <div class="sticky-top">
            <ul class="nav justify-content-center  menuPrincipal pb-4 " id="listadoPaginas">

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
        <div class="container">
            <div class="row justify-content-center">
                <div class="col-7   mt-4 mb-5">
                    <h4 id="textoTitle" class="text-center pb-4">Información Adicional</h4>


                    <form>
                        <div class="row">
                            <div class="col">

                                <label class="form-label">Nombre</label>
                                <input type="text" class="form-control" id="userName">
                                <br>
                                <br>

                                <label class="form-label">Fecha de nacimiento</label>
                                <input type="date" class="form-control" id="fechaNacimiento">
                                <br>
                                <br>

                                <label class="form-label">Móvil</label>
                                <input type="text" class="form-control" id="telf">
                                <span class="form-text" id="errorTelf"></span>
                                <br>
                                <br>

                                <label class="form-label">Tipo Minusvalía</label>
                                <input type="text" class="form-control" id="tipoMinusvalia">
                                <br>
                                <br>
                                <asp:CheckBox ID="CheckBox2" runat="server" Text="&nbsp;Minusválido" />
                            </div>

                            <div class="col">

                                <label class="form-label">Apellidos</label>
                                <input type="text" class="form-control" id="surname">
                                <br>
                                <br>

                                <label class="form-label">Localidad</label>
                                <input type="text" class="form-control" id="localidad">
                                <br>
                                <br>

                                <label class="form-label">Dependencia</label>
                                <input type="text" class="form-control" id="Dependencia">
                                <br>
                                <br>

                                <label class="form-label">Porcentaje Minusvalía</label>
                                <input type="number" class="form-control" id="porcentajeMinusvalia">
                                <br>
                                <br>
                                <asp:CheckBox ID="CheckBox1" runat="server" Text="&nbsp;Inscribirse como voluntario" />
                            </div>
                        </div>
                    </form>
                    <br />

                    <asp:Button class="btn btn-primary d-block m-auto" runat="server" Text="Enviar datos" ID="btnRegistrar" OnClick="btnRegistrar_Click" />
                    <br />
                </div>
            </div>
        </div>

        <!-- Floor content -->
        <div class=" fixed-bottom" id="footer">
            <p id="textoFooter" style="color: rgb(231, 231, 231);" class="text-center p-1">
                Todos los derechos reservados
            2022
            @ Copyright
            </p>
        </div>


        <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.1/dist/js/bootstrap.bundle.min.js"
            integrity="sha384-u1OknCvxWvY5kfmNBILK2hRnQC3Pr17a+RTT6rIHI7NnikvbZlHgTPOOmMi466C8"
            crossorigin="anonymous"></script>

    </form>
</body>
</html>
