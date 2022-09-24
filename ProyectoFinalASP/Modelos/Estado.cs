using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoFinalASP.Modelos
{
    public class Estado
    {
        int idEstado;
        string estado;

        public Estado()
        {

        }
        public Estado(int idEstado, string estado)
        {
            this.idEstado = idEstado;
            this.estado = estado;
        }

        public int IdEstado { get => idEstado; set => idEstado = value; }
        public string Estado { get => estado; set => estado = value; }
    }
}