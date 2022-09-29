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
        StringBuilder sb = new StringBuilder();
        DALEvento eventoDal = new DALEvento();
        DALRuta rutaDal = new DALRuta();
        DALParticipante participanteDal = new DALParticipante();
        DALUsuario usuarioDal = new DALUsuario();
        DALChat chatDal = new DALChat();
        Evento evento = new Evento();
        Ruta ruta = new Ruta();
        List<Participante> participantes = new List<Participante>();
        List<Participante> voluntarios = new List<Participante>();
        List<Chat> chat = new List<Chat>();

        static int id = -1;
        int idEventoSeleccionado;
        int idRutaSeleccionada;
        DateTime fechaEvento;
        DateTime horaEvento;
        DateTime timeEvento;
        bool needVol;

        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {
                if (Request.QueryString["idEvento"] != null)
                {
                    idEventoSeleccionado = Int32.Parse(Request.QueryString["idEvento"]);
                }
                else
                {
                    idRutaSeleccionada = Int32.Parse(Request.QueryString["idRuta"]);
                    fechaEvento = DateTime.Parse(Request.QueryString["fechaEvento"]);
                    horaEvento = DateTime.Parse(Request.QueryString["horaEvento"]);
                    needVol = Boolean.Parse(Request.QueryString["volEvento"]);
                    timeEvento = new DateTime(Int32.Parse(fechaEvento.ToString("yyyy")), Int32.Parse(fechaEvento.ToString("MM")), Int32.Parse(fechaEvento.ToString("dd"))
                        , Int32.Parse(horaEvento.ToString("HH")), Int32.Parse(horaEvento.ToString("mm")), Int32.Parse(horaEvento.ToString("ss")));
                    evento = new Evento(idRutaSeleccionada, true, timeEvento, 0, 1);
                    idEventoSeleccionado = eventoDal.InsertEvento(evento);
                    evento.IdEvento = idEventoSeleccionado;
                }
            }
            catch (ArgumentNullException ex)
            {
                Response.Redirect("EventosDisponibles");
            }

            try
            {
                HttpCookie reqCookies = Request.Cookies["userInfo"];
                id = int.Parse(reqCookies["id"]);
            }
            catch (NullReferenceException ex)
            {
                Response.Redirect("PaginaPrincipal");
            }

            //Se le pasa un valor al evento hasta que se lo enviemos desde otro lado
            evento = eventoDal.SelectEventoByIdEvento(idEventoSeleccionado);
            ruta = rutaDal.SelectRutaByIdRuta(evento.FkIDRuta);

            sb.Append(" <h3>" + ruta.Nombre + "</h3><br/>");
            sb.Append(" <div id='base1' class='row'>");
            sb.Append("     <div class='col-8'>");
            sb.Append("         <label class='form-label' id='lblKm'>Longitud: " + ((int)ruta.LongitudKm) + " km | </label>");
            sb.Append("         <label class='form-label' id='lblValoracion'>Valoracion: " + ruta.ValoracionMedia + " | </label>");
            sb.Append("         <label class='form-label' id='lblAccesibilidad'>Nivel Accesibilidad: " + ruta.NivelAccesibilidad + " </label>");
            sb.Append("     </div>");
            //sb.Append("     <div class='col-4'>");
            //sb.Append("         <button class='btn btn-success' onClick='unirseEvento(" + evento.IdEvento +")' id='btnUnirseEvento'>¡Únete al evento!</button>");
            //sb.Append("     </div>");
            sb.Append(" </div>");
            sb.Append(" <div id='base2' class='row'>");
            sb.Append("     <label style='' id='lblChat'>Chat del evento</label>");
            sb.Append("     <div class='col-8 align-self-end'>");

            chat = chatDal.SelectChatsByIdEvento(evento.IdEvento);
            foreach (var mensaje in chat)
            {
                sb.Append("         <div style='font-size:13px; class='' id='lblChat'>" + usuarioDal.SelectUsuarioByIDUsuario(mensaje.FkIDUsuario).Nombre + ": " + mensaje.Mensaje + "</div>");
            }

            sb.Append("     </div>");
            sb.Append("     <div class='col-4'>");
            sb.Append("         <div class='row border'>");
            sb.Append("             <label class='form-label col-6' id='lblFecha'>Fecha: " + evento.FechaDeRealizacion.Value.ToString("dd/MM/yyyy") + "</label>");
            sb.Append("             <label class='form-label col-4' id='lblHora'>Hora: " + evento.FechaDeRealizacion.Value.TimeOfDay + "</label>");
            sb.Append("         </div>");
            sb.Append("         <div class='row border'>");
            sb.Append("             <ul class='list-group list-group-flush'>");
            sb.Append("                 <li class='list-group-item'><b>Usuarios: " + participanteDal.SelectCountParticipantesByIdEvento(evento.IdEvento) + "</b></li>");

            participantes = participanteDal.SelectParticipantesByIdEvento(evento.IdEvento);
            foreach (var participante in participantes)
            {
                sb.Append("                 <li class='list-group-item'>" + usuarioDal.SelectUsuarioByIDUsuario(participante.FkIDUsuario).ToString() + "</li>");
            }
            sb.Append("             </ul>");
            sb.Append("         </div>");
            sb.Append("         <div class='row border'>");
            sb.Append("             <ul class='list-group list-group-flush'>");
            sb.Append("                 <li class='list-group-item'><b>Voluntarios: " + participanteDal.SelectCountParticipantesVoluntariosByIdEvento(evento.IdEvento) + "</b></li>");

            voluntarios = participanteDal.SelectParticipantesVoluntariosByIdEvento(evento.IdEvento);
            foreach (var voluntario in voluntarios)
            {
                sb.Append("                 <li class='list-group-item'>" + usuarioDal.SelectUsuarioByIDUsuario(voluntario.FkIDUsuario).ToString() + "</li>");
            }
            sb.Append("             </ul>");
            sb.Append("         </div>");
            sb.Append("         <div class='row'>");
            sb.Append("             <label class='form-label' id='lblComentarios'>" + ruta.Descripcion + "</label>");
            sb.Append("         </div>");
            sb.Append("     </div>");
            sb.Append(" </div>");

            ltEventoSeleccionado.Text = sb.ToString();

            Participante p = participanteDal.SelectParticipanteByIdEvento(id, evento.IdEvento);
            if (p != null)
            {
                btnUnirseAlEvento.Visible = false;
                btnBorrarseDelEvento.Visible = true;
                textoMensaje.Enabled = true;
            }

        }

        protected void enviarMensaje_Click(object sender, EventArgs e)
        {
            string mensajeText = textoMensaje.Text;

            Chat mensajeEnviado = new Chat();
            mensajeEnviado.FkIDEvento = evento.IdEvento;
            mensajeEnviado.FkIDUsuario = id; //Aqui iria el ID del usuario recogido de la cookie del usuario logeado.
            mensajeEnviado.Mensaje = mensajeText;

            if (textoMensaje.Text != "")
            {
                chatDal.InsertChat(mensajeEnviado);
                Response.Redirect(Request.RawUrl);
                textoMensaje.Text = "";
                mensajeText = "";
            }
            else
            {
                //no
            }

        }

        protected void btnUnirseAlEvento_Click(object sender, EventArgs e)
        {
            Participante part = new Participante(evento.IdEvento, id);
            participanteDal.InsertParticipante(part);
            //Response.Write("<script>alert('Te has unido al evento.')</script>");
            textoMensaje.Enabled = true;
            btnUnirseAlEvento.Visible = false;
            btnBorrarseDelEvento.Visible = true;
            Response.Redirect(Request.RawUrl);
        }

        protected void btnBorrarseDelEvento_Click(object sender, EventArgs e)
        {
            participanteDal.DeleteParticipanteByIdEvento(evento.IdEvento, id);
            //Response.Write("<script>alert('Te has borrado del evento.')</script>");
            textoMensaje.Enabled = false;
            btnUnirseAlEvento.Visible = true;
            btnBorrarseDelEvento.Visible = false;
            Response.Redirect(Request.RawUrl);
        }
    }
}