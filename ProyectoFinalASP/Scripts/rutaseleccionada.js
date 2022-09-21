
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

var lineaA = null;
var lineaB = null;
var lineaTotal = null;

var lAlat = null;
var lAlng = null;
var lBlat = null;
var lBlng = null;

var puntoSalida = null;

function onMapClick(e) {

    lineaB = lineaA;
    lineaA = e.latlng;

    if (lineaA == null || lineaB == null) {
        lAlat = lineaA.lat;
        lAlng = lineaA.lng;
        L.marker([lAlat, lAlng]).addTo(map)
            .bindPopup('Punto de salida')
            .openPopup();

    } else {
        lAlat = lineaA.lat;
        lAlng = lineaA.lng;
        lBlat = lineaB.lat;
        lBlng = lineaB.lng;

        lineaTotal = [{
            "type": "LineString",
            "coordinates": [[lAlng, lAlat], [lBlng, lBlat]]
        }];

        trazado.addData(lineaTotal);
        
        //L.geoJSON(lineaTotal).addTo(map);

    }

    //L.geoJSON(myLines).addTo(map);
}

var patientString = JSON.stringify(trazado);
$('#mapInfo').val(patientString);