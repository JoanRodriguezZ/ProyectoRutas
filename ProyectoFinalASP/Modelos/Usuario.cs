﻿namespace ProyectoFinalASP.Modelos
{
    public class Usuario
    {
        int idUsuario;
        string password;
        string nombre;
        string apellidos;
        string email;
        string telefono;
        string localidad;
        int porcentajeMinusvalia;
        string tipoMinusvalia;
        string dependencias;
        bool esMinusvalido;
        bool esVoluntario;
        bool esAdmin;

        public Usuario(int idUsuario, string password, string nombre, string apellidos, string email, string telefono, string localidad, int porcentajeMinusvalia, string tipoMinusvalia, string dependencias, bool esMinusvalido, bool esVoluntario, bool esAdmin)
        {
            this.idUsuario = idUsuario;
            this.password = password;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.email = email;
            this.telefono = telefono;
            this.localidad = localidad;
            this.porcentajeMinusvalia = porcentajeMinusvalia;
            this.tipoMinusvalia = tipoMinusvalia;
            this.dependencias = dependencias;
            this.esMinusvalido = esMinusvalido;
            this.esVoluntario = esVoluntario;
            this.esAdmin = esAdmin;
        }

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string Password { get => password; set => password = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Email { get => email; set => email = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Localidad { get => localidad; set => localidad = value; }
        public int PorcentajeMinusvalia { get => porcentajeMinusvalia; set => porcentajeMinusvalia = value; }
        public string TipoMinusvalia { get => tipoMinusvalia; set => tipoMinusvalia = value; }
        public string Dependencias { get => dependencias; set => dependencias = value; }
        public bool EsMinusvalido { get => esMinusvalido; set => esMinusvalido = value; }
        public bool EsVoluntario { get => esVoluntario; set => esVoluntario = value; }
        public bool EsAdmin { get => esAdmin; set => esAdmin = value; }
    }
}