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
        int fkIDUsuario;

        public Ruta()
        {

        }
        public Ruta(int idRuta, string nombre, float longitudKm, int nivelAccesibilidad, string localizacion, float? valoracionMedia, int fkIDUsuario)
        {
            this.idRuta = idRuta;
            this.nombre = nombre;
            this.longitudKm = longitudKm;
            this.nivelAccesibilidad = nivelAccesibilidad;
            this.localizacion = localizacion;
            this.valoracionMedia = valoracionMedia;
            this.fkIDUsuario = fkIDUsuario;
        }

        public int IdRuta { get => idRuta; set => idRuta = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public float LongitudKm { get => longitudKm; set => longitudKm = value; }
        public int NivelAccesibilidad { get => nivelAccesibilidad; set => nivelAccesibilidad = value; }
        public string Localizacion { get => localizacion; set => localizacion = value; }
        public float? ValoracionMedia { get => valoracionMedia; set => valoracionMedia = value; }
        public int FkIDUsuario { get => fkIDUsuario; set => fkIDUsuario = value; }
    }
}