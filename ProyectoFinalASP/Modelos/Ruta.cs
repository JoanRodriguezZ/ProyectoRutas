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
        decimal longitudKm;
        int nivelAccesibilidad;
        string localizacion;
        decimal? valoracionMedia;
        int fkIDUsuario;
        string descripcion;

        public Ruta()
        {

        }
        public Ruta(int idRuta, string nombre, decimal longitudKm, int nivelAccesibilidad, string localizacion, decimal? valoracionMedia, int fkIDUsuario, string descripcion)
        {
            this.idRuta = idRuta;
            this.nombre = nombre;
            this.longitudKm = longitudKm;
            this.nivelAccesibilidad = nivelAccesibilidad;
            this.localizacion = localizacion;
            this.valoracionMedia = valoracionMedia;
            this.fkIDUsuario = fkIDUsuario;
            this.descripcion = descripcion;
        }

        public int IdRuta { get => idRuta; set => idRuta = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public decimal LongitudKm { get => longitudKm; set => longitudKm = value; }
        public int NivelAccesibilidad { get => nivelAccesibilidad; set => nivelAccesibilidad = value; }
        public string Localizacion { get => localizacion; set => localizacion = value; }
        public decimal? ValoracionMedia { get => valoracionMedia; set => valoracionMedia = value; }
        public int FkIDUsuario { get => fkIDUsuario; set => fkIDUsuario = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}