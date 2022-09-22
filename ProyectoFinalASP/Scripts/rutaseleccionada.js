
//Inicializa el mapa en las coordenadas indicadas.
var map = L.map('map').setView([41.3945, 2.169594], 13);

L.tileLayer('https://tile.openstreetmap.org/{z}/{x}/{y}.png', {
    maxZoom: 19,
    attribution: '© OpenStreetMap'
}).addTo(map);

//Funcion para abrir un popup que indique las coordenadas exactas de donde se clica
var popup = L.popup();

map.on('click', onMapClick);

var trazado = L.geoJSON().addTo(map);

var puntoA = null;
var puntoB = null;
var lineaTotal = null;

var pAlat = null;
var pAlng = null;
var pBlat = null;
var pBlng = null;

var coordenadaA = null;
var coordenadaB = null;

var coordAHTML = document.getElementById('coordenadaA');
var coordBHTML = document.getElementById('coordenadaB');

var puntoSalida = null;

var marker = null;

function onMapClick(e) {

    puntoB = puntoA;
    puntoA = e.latlng;

    if (puntoA == null || puntoB == null) {
        pAlat = puntoA.lat;
        pAlng = puntoA.lng;
        marker = L.marker([pAlat, pAlng]).addTo(map)
            .bindPopup('Punto de salida')
            .openPopup();

        trazado.addData(marker);


    } else {
        pAlat = puntoA.lat;
        pAlng = puntoA.lng;
        pBlat = puntoB.lat;
        pBlng = puntoB.lng;

        lineaTotal = [{
            "type": "LineString",
            "coordinates": [[pAlng, pAlat], [pBlng, pBlat]]
        }];

        //document.getElementById(pAlngHTML).value = pAlng;
        //document.getElementById(pAlatHTML).value = pAlat;
        //document.getElementById(pBlngHTML).value = pBlng;
        //document.getElementById(pBlatHTML).value = pBlat;

        trazado.addData(lineaTotal);
        
        //L.geoJSON(lineaTotal).addTo(map);

    }

    //L.geoJSON(myLines).addTo(map);
}


//var patientString = JSON.stringify(trazado);
//var mapInfoHTML = document.getElementById('mapInfo');
//mapInfoHTML.value = patientString;


//$.ajax({
//    url: '/Home/GetBranch',
//    success: function (data) {
//        console.log(data)
//        $(data).each(function (index, item) {
//            var lat = item.branchGeoLocationLat;
//            var long = item.branchGeoLocationLong;
//            L.marker([lat, long], { icon: greenIcon }).bindPopup("I am the " + item.branchName + " leaf.").addTo(map);
//        });
//    },
//});