using ProyectoFinalASP.DAL;
using ProyectoFinalASP.Modelos;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinalASP
{
    public partial class EventoSeleccionado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            DALEvento eventoDal = new DALEvento();
            DALRuta rutaDal = new DALRuta();
            DALParticipante participanteDal = new DALParticipante();
            DALUsuario usuarioDal = new DALUsuario();
            Evento evento = new Evento();
            Ruta ruta = new Ruta();
            List<Participante> participantes = new List<Participante>();
            List<Participante> voluntarios = new List<Participante>();
            int countElement = 0;
            
            //Se le pasa un valor al evento hasta que se lo enviemos desde otro lado
            evento = eventoDal.SelectEventoByIdEvento(1);
            ruta = rutaDal.SelectRutaByIdRuta(evento.FkIDRuta);

            sb.Append(" <h3>"+ ruta.Nombre +"</h3><br/>");
            sb.Append(" <div id='base1' class='row'>");
            sb.Append("     <div class='col-8'>");
            sb.Append("         <label class='form-label' id='lblKm'>Longitud: "+ ((int)ruta.LongitudKm) + " km | </label>");
            sb.Append("         <label class='form-label' id='lblValoracion'>Valoracion: "+ ruta.ValoracionMedia +" | </label>");
            sb.Append("         <label class='form-label' id='lblAccesibilidad'>Nivel Accesibilidad: "+ ruta.NivelAccesibilidad +" </label>");
            sb.Append("     </div>");
            sb.Append(" </div>");
            sb.Append(" <div id='base2' class='row'>");
            sb.Append("     <div class='col-8 border'>");
            sb.Append("         <label style='height:500px' id='lblChat'>Chat</label>");
            sb.Append("     </div>");
            sb.Append("     <div class='col-4'>");
            sb.Append("         <div class='row border'>");
            sb.Append("             <label class='form-label col-6' id='lblFecha'>Fecha: "+ evento.FechaDeRealizacion.Value.ToString("dd/MM/yyyy") +"</label>");
            sb.Append("             <label class='form-label col-4' id='lblHora'>Hora: " + evento.FechaDeRealizacion.Value.TimeOfDay + "</label>");
            sb.Append("         </div>");
            sb.Append("         <div class='row border'>");
            sb.Append("             <ul class='list-group list-group-flush'>");
            sb.Append("                 <li class='list-group-item'><b>Usuarios: "+ participanteDal.SelectCountParticipantesByIdEvento(evento.IdEvento) +"</b></li>");
            
            participantes = participanteDal.SelectParticipantesByIdEvento(evento.IdEvento);
            foreach (var participante in participantes)
            {
                sb.Append("                 <li class='list-group-item'>"+ usuarioDal.SelectUsuarioByIDUsuario(participante.FkIDUsuario).ToString() +"</li>");
            }            
            sb.Append("             </ul>");
            sb.Append("         </div>");
            sb.Append("         <div class='row border'>");
            sb.Append("             <ul class='list-group list-group-flush'>");
            sb.Append("                 <li class='list-group-item'><b>Voluntarios: "+ participanteDal.SelectCountParticipantesVoluntariosByIdEvento(evento.IdEvento) +"</b></li>");           
            
            voluntarios = participanteDal.SelectParticipantesVoluntariosByIdEvento(evento.IdEvento);
            foreach (var voluntario in voluntarios)
            {
                sb.Append("                 <li class='list-group-item'>" + usuarioDal.SelectUsuarioByIDUsuario(voluntario.FkIDUsuario).ToString() + "</li>");
            }
            sb.Append("             </ul>");
            sb.Append("         </div>");
            sb.Append("         <div class='row'>");
            sb.Append("             <label class='form-label' id='lblComentarios'>"+ ruta.Descripcion +"</label>");
            sb.Append("         </div>");
            sb.Append("     </div>");
            sb.Append(" </div>");

            countElement++;
            ltEventoSeleccionado.Text = sb.ToString();
        }
    }
}