﻿using ProyectoFinalASP.DAL;
using ProyectoFinalASP.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinalASP
{
    public partial class EventosDisponibles : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            DALEvento eventoDal = new DALEvento();
            List<Evento> eventos = new List<Evento>();
            DALRuta rutaDal = new DALRuta();
            Ruta ruta = new Ruta();
            DALParticipante participanteDal = new DALParticipante();
            int countElement = 0;

            eventos = eventoDal.SelectEventosOrderByFecha();
            foreach (var evento in eventos)
            {
                ruta = rutaDal.SelectRutaByIdRuta(evento.FkIDRuta);
                sb.Append(" <div id='base' class='row border'>");
                sb.Append("     <div class='col-3'>");
                sb.Append("         <label class='form-label' id='lblRuta'>"+ ruta.Nombre +"</label><br />");
                sb.Append("         <button class='btn btn-outline-dark' id='btnVerRuta'>Ver</button><br />");
                sb.Append("         <label class='form-label' id='lblCreador'>"+ ruta.FkIDUsuario + "</label>");
                sb.Append("     </div>");
                sb.Append("     <div class='col-3'>");
                sb.Append("         <label class='form-label' id='lblKm'>Km: "+ ((int)ruta.LongitudKm) +"</label><br />");
                sb.Append("         <label class='form-label' id='lblAccesibilidad'>Accesibilidad: "+ ruta.NivelAccesibilidad +"</label><br />");
                sb.Append("         <label class='form-label' id='lblValoracion'>Valoracion: "+ ruta.ValoracionMedia +"</label>");
                sb.Append("     </div>");
                sb.Append("     <div class='col-3'>");
                sb.Append("         <label class='form-label' id='numUsuarios'>Participantes: "+ participanteDal.SelectCountParticipantesByIdEvento(evento.IdEvento).ToString() +"</label><br />");
                sb.Append("         <label class='form-label' id='numVoluntarios'>Voluntarios: "+ participanteDal.SelectCountParticipantesVoluntariosByIdEvento(evento.IdEvento).ToString() +"</label><br />");
                sb.Append("     </div>");
                sb.Append("     <div class='col-3'>");
                sb.Append("         <label class='form-label' id='lblFecha'>"+ evento.FechaDeRealizacion.Value.ToString("dd/MM/yyyy") + "</label><br />");
                sb.Append("         <label class='form-label' id='lblHora'>"+ evento.FechaDeRealizacion.Value.TimeOfDay +"</label><br />");
                sb.Append("         <button class='btn btn-outline-dark' id='btnJoin'>JOIN</button>");
                sb.Append("     </div>");
                sb.Append(" </div>");
                
                countElement++;
                ltEventosDisponibles.Text = sb.ToString();
            }
            
        }
    }
}