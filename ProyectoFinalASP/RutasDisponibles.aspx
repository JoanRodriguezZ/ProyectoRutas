<%@ Page Title="RutasDisponibles" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RutasDisponibles.aspx.cs" Inherits="ProyectoFinalASP.RutasDisponibles" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Literal ID = "ltRutasDisponibles" runat = "server" />
    <!--
        <a id="bannerLink" href="http://www.abc.com" onclick="void window.open(this.href); return false;">
            <img id="bannerImage" src="https://www.collinsdictionary.com/images/full/mountain_221506423.jpg" width="100" height="100" alt="some text">
        </a>
        <label id="lblComment">Ruta Increible</label>
    -->
    <!-- Carousel -->
    <div id="demo" class="carousel slide" style="width:300px;height:300px" data-bs-ride="carousel">
    <!-- Indicators/dots -->
        <div class="carousel-indicators">
            <button type="button" data-bs-target="#demo" data-bs-slide-to="0" class="active"></button>
            <button type="button" data-bs-target="#demo" data-bs-slide-to="1"></button>
            <button type="button" data-bs-target="#demo" data-bs-slide-to="2"></button>
        </div>
    <!-- The slideshow/carousel -->
        <div class="carousel-inner">
            <div class="carousel-item active">
                <img id="image1" runat="server" src="https://www.collinsdictionary.com/images/full/mountain_221506423.jpg" alt="Los Angeles" class="d-block w-100">
                <div class="carousel-caption">
                    <h3>Los Angeles</h3>
                    <p>We had such a great time in LA!</p>
                </div>
            </div>
            <div class="carousel-item">
                <img id="image2" runat="server" src="https://upload.wikimedia.org/wikipedia/commons/9/96/Barbados_beach.jpg" alt="Chicago" class="d-block w-100">
                <div class="carousel-caption">
                    <h3>Los Angeles</h3>
                    <p>We had such a great time in LA!</p>
                </div>
            </div>
            <div class="carousel-item">
                <img id="image3" runat="server" src="https://piscinascano.com/wp-content/uploads/2022/07/Piscinas-Cano-PIscina-OLIMPIA-5-Modelo-nuevo-2022-scaled.jpg" alt="New York" class="d-block w-100">
                <div class="carousel-caption">
                    <h3>Los Angeles</h3>
                    <p>We had such a great time in LA!</p>
                </div>
            </div>
        </div>
    <!-- Left and right controls/icons -->
        <button class="carousel-control-prev" type="button" data-bs-target="#demo" data-bs-slide="prev">
            <span class="carousel-control-prev-icon"></span>
        </button>
        <button class="carousel-control-next" type="button" data-bs-target="#demo" data-bs-slide="next">
            <span class="carousel-control-next-icon"></span>
        </button>
    </div>

    <script>
        var links = ["http://www.abc.com", "http://www.def.com", "http://www.ghi.com"];
        var images = ["https://www.collinsdictionary.com/images/full/mountain_221506423.jpg",
            "https://upload.wikimedia.org/wikipedia/commons/9/96/Barbados_beach.jpg",
            "https://piscinascano.com/wp-content/uploads/2022/07/Piscinas-Cano-PIscina-OLIMPIA-5-Modelo-nuevo-2022-scaled.jpg"];
        var comments = ["Ruta increible", "No me ha gustado", "Muy bien"];
        var i = 0;
        var renew = setInterval(function () {
            if (links.length == i) {
                i = 0;
            }
            else {
                document.getElementById("bannerImage").src = images[i];
                document.getElementById("bannerLink").href = links[i];
                document.getElementById("lblComment").innerText = comments[i];
                i++;
            }
        }, 3000);
    </script>

</asp:Content>