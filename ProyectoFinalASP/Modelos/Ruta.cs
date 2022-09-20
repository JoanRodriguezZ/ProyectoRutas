using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoFinalASP.Modelos
{
    public class Ruta 
    {
        int idRuta;
        string nombre;
        float longitudKm;
        int nivelAccesibilidad;
        string localizacion;
        float valoracionMedia;

        public Ruta(int idRuta, string nombre, float longitudKm, int nivelAccesibilidad, string localizacion, float valoracionMedia)
        {
            this.idRuta = idRuta;
            this.nombre = nombre;
            this.longitudKm = longitudKm;
            this.nivelAccesibilidad = nivelAccesibilidad;
            this.localizacion = localizacion;
            this.valoracionMedia = valoracionMedia;
        }

        public int IdRuta { get => idRuta; set => idRuta = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public float LongitudKm { get => longitudKm; set => longitudKm = value; }
        public int NivelAccesibilidad { get => nivelAccesibilidad; set => nivelAccesibilidad = value; }
        public string Localizacion { get => localizacion; set => localizacion = value; }
        public float ValoracionMedia { get => valoracionMedia; set => valoracionMedia = value; }
    }
}