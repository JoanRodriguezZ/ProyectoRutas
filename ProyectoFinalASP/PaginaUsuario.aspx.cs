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
    public partial class PaginaUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = -1;

            try
            {
                HttpCookie reqCookies = Request.Cookies["userInfo"];
                id = int.Parse(reqCookies["id"]);
            }
            catch (NullReferenceException ex)
            {
                Response.Redirect("PaginaPrincipal");
            }

            StringBuilder sb = new StringBuilder();
            DALEvento eventoDal = new DALEvento();
            DALRuta rutaDal = new DALRuta();
            DALParticipante participanteDal = new DALParticipante();
            DALUsuario usuarioDal = new DALUsuario();
            DALEstado estadoDal = new DALEstado();
            List<Evento> eventos = new List<Evento>();
            Usuario user = new Usuario();
            Ruta ruta = new Ruta();
            Estado estado = new Estado();
            int countElement = 0;

            //Se le pasa un valor al evento hasta que se lo enviemos desde otro lado
            user = usuarioDal.SelectUsuarioByIDUsuario(id);
            Debug.WriteLine(id);

            sb.Append(" <h3>Pagina Usuario </h3><br/>");
            sb.Append(" <div id ='base1' class='row border'>");
            sb.Append("     <div class='col-4'>");
            sb.Append("         <label class='form-label' id='lblNombre'>" + user.ToString() + "</label><br/>");
            sb.Append("         <label class='form-label' id='lblTipo'>" + user.Tipo() + "</label><br/>");
            sb.Append("     </div>");
            sb.Append("     <div class='col-4'>");
            sb.Append("         <label class='form-label' id='lblLocalidad'>Localidad: " + user.Localidad + "</label><br/>");
            sb.Append("         <label class='form-label' id='lblEmail'>Email: " + user.Email + "</label><br/>");
            sb.Append("         <label class='form-label' id='lblTelefono'>Telefono: " + user.Telefono + "</label>");
            sb.Append("     </div>");
            if (user.EsMinusvalido)
            {
                sb.Append("     <div class='col-4'>");
                sb.Append("         <label class='form-label' id='lblTipoMinusvalia'>Tipo M: " + user.TipoMinusvalia + "</label><br/>");
                sb.Append("         <label class='form-label' id='lblPorcentajeMinusvalia'>Porcentaje M: " + user.PorcentajeMinusvalia + "%</label><br/>");
                sb.Append("         <label class='form-label' id='lblDependencia'>Dependencia: " + user.Dependencias + "</label>");
                sb.Append("     </div>");
            }
            sb.Append(" </div>");

            eventos = eventoDal.SelectEventosByIdUsuarioOrderEstado(user.IdUsuario);
            if(eventos.Count > 0)
            {
                foreach (var evento in eventos)
                {
                    ruta = rutaDal.SelectRutaByIdRuta(evento.FkIDRuta);
                    user = usuarioDal.SelectUsuarioByIDUsuario(ruta.FkIDUsuario);
                    estado = estadoDal.SelectEstadoByIdEstado(evento.FkIDEstado);
                    switch (estado.IdEstado)
                    {
                        case 1:
                            sb.Append("         <label class='form-label' id='lblEstado'>" + estado.EstadoDescripcion + "</label><br />");
                            sb.Append("         <div class='row border border-primary'>");
                            break;
                        case 2:
                            sb.Append("         <label class='form-label' id='lblEstado'>" + estado.EstadoDescripcion + "</label><br />");
                            sb.Append("         <div class='row border border-success'>");
                            break;
                        case 3:
                            sb.Append("         <label class='form-label' id='lblEstado'>" + estado.EstadoDescripcion + "</label><br />");
                            sb.Append("         <div class='row border border-danger'>");
                            break;
                        case 4:
                            sb.Append("         <label class='form-label' id='lblEstado'>" + estado.EstadoDescripcion + "</label><br />");
                            sb.Append("         <div class='row border border-dark'>");
                            break;
                        default:
                            sb.Append("         <div class='row border border-info'>");
                            break;
                    }

                    sb.Append("     <div class='col-3'>");
                    sb.Append("         <label class='form-label' id='lblRuta'>" + ruta.Nombre + "</label><br />");
                    sb.Append("         <button class='btn btn-outline-dark' id='btnVerRuta'>Ver Ruta</button><br />");
                    sb.Append("         <label class='form-label' id='lblCreador'>" + user.ToString() + "</label>");
                    sb.Append("     </div>");
                    sb.Append("     <div class='col-3'>");
                    sb.Append("         <label class='form-label' id='lblKm'>Km: " + ((int)ruta.LongitudKm) + "</label><br />");
                    sb.Append("         <label class='form-label' id='lblAccesibilidad'>Accesibilidad: " + ruta.NivelAccesibilidad + "</label><br />");
                    sb.Append("         <label class='form-label' id='lblValoracion'>Valoracion: " + ruta.ValoracionMedia + "</label>");
                    sb.Append("     </div>");
                    sb.Append("     <div class='col-3'>");
                    sb.Append("         <label class='form-label' id='numUsuarios'>Participantes: " + participanteDal.SelectCountParticipantesByIdEvento(evento.IdEvento).ToString() + "</label><br />");
                    sb.Append("         <label class='form-label' id='numVoluntarios'>Voluntarios: " + participanteDal.SelectCountParticipantesVoluntariosByIdEvento(evento.IdEvento).ToString() + "</label><br />");
                    sb.Append("     </div>");
                    sb.Append("     <div class='col-3'>");
                    sb.Append("         <label class='form-label' id='lblFecha'>" + evento.FechaDeRealizacion.Value.ToString("dd/MM/yyyy") + "</label><br />");
                    sb.Append("         <label class='form-label' id='lblHora'>" + evento.FechaDeRealizacion.Value.TimeOfDay + "</label><br />");
                    sb.Append("         <button class='btn btn-outline-dark' id='btnJoin'>Ver Evento</button>");
                    sb.Append("     </div>");
                    sb.Append(" </div>");
                    countElement++;
                }
            }
            ltPaginaUsuario.Text = sb.ToString();
        }
    }
}