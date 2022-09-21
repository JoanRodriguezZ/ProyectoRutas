
//Inicializa el mapa en las coordenadas indicadas.
var map = L.map('map').setView([41.3945, 2.169594], 13);

L.tileLayer('https://tile.openstreetmap.org/{z}/{x}/{y}.png', {
    maxZoom: 19,
    attribution: '© OpenStreetMap'
}).addTo(map);

//Funcion para abrir un popup que indique las coordenadas exactas de donde se clica
var popup = L.popup();

function onMapClick(e) {
    popup
        .setLatLng(e.latlng)
        .setContent("You clicked the map at " + e.latlng.toString())
        .openOn(map);
}

map.on('click', onMapClick);

//Añade las funcionalidades de geoJSON para poder dibujar en el mapa.
//L.geoJSON(geojsonFeature).addTo(map);

//Creo el objeto geoJSON de tipo LineString con las coordenadas especificas en un array por lo que puedo concatenar los puntos como me cunda
var myLines = [{
    "type": "LineString",
    "coordinates": [[-100, 40], [-105, 45]]
}, {
    "type": "LineString",
    "coordinates": [[-105, 40], [-110, 45]]
    }];

//var myLayer = L.geoJSON().addTo(map);
//myLayer.addData(myLines);

var lineaA = null;
var lineaB = null;

lineaA = e.latlng;
lineaB = null;

lineaB = lineaA;
lineaA = e.latlng;

L.geoJSON(myLines).addTo(map);