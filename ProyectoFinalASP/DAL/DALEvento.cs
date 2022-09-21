using ProyectoFinalASP.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoFinalASP.DAL
{
    public class DALEvento
    {
        
        DbConnect cnx;
        public DALEvento()
        {
            cnx = new DbConnect();
        }
        public void InsertEvento(Evento evento)
        {
            try
            {
                string sql = @"INSERT INTO Evento 
                    (FKRutaID, esPublico, FechaDeRealizacion, 
                    VoluntariosNecesarios, FKIDEstado)
                    VALUES (@pFKRutaID,
                        @pesPublico,
                        @pFechaDeRealizacion,
                        @pVoluntariosNecesarios,
                        @pFKIDEstado)";
                SqlCommand cmd = new SqlCommand(sql, cnx.MiCnx);

                SqlParameter pFKRutaID = new SqlParameter("@pFKRutaID", System.Data.SqlDbType.Int);
                pFKRutaID.Value = evento.FkIDRuta;
                SqlParameter pesPublico = new SqlParameter("@pesPublico", System.Data.SqlDbType.Bit);
                pesPublico.Value = evento.EsPublico;
                SqlParameter pFechaDeRealizacion = new SqlParameter("@pFechaDeRealizacion", System.Data.SqlDbType.DateTime);
                pFechaDeRealizacion.Value = evento.FechaDeRealizacion;
                SqlParameter pVoluntariosNecesarios = new SqlParameter("@pVoluntariosNecesarios", System.Data.SqlDbType.Int);
                pVoluntariosNecesarios.Value = evento.VoluntariosNecesarios;
                SqlParameter pFKIDEstado = new SqlParameter("@pFKIDEstado", System.Data.SqlDbType.Int);
                pFKIDEstado.Value = evento.FkIDEstado;

                cmd.Parameters.Add(pFKRutaID);
                cmd.Parameters.Add(pesPublico);
                cmd.Parameters.Add(pFechaDeRealizacion);
                cmd.Parameters.Add(pVoluntariosNecesarios);
                cmd.Parameters.Add(pFKIDEstado);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error en Insert: " + ex.Message);
                Console.WriteLine(ex.Message);
            }
        }
        public List<Evento> SelectEventosOrderByFecha()
        {
            List<Evento> eventos = new List<Evento>();
            Evento evento;

            try
            {
                string sql = "SELECT * FROM Evento ORDER BY FechaDeRealizacion";
                SqlCommand cmd = new SqlCommand(sql, cnx.MiCnx);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    evento = new Ruta();
                    evento.IdEvento = (int)dr["IDEvento"];
                    evento.FkIDRuta = (int)(dr["FKRutaID"]);
                    evento.EsPublico = (bool)(dr["esPublico"]);
                    evento.FechaDeRealizacion = (DateTime)GestionarNulos(dr["FechaDeRealizacion"]);
                    evento.VoluntariosNecesarios = (int)GestionarNulos(dr["VoluntariosNecesarios"]);
                    evento.FkIDEstado = (int)(dr["FKIDEstado"]);

                    eventos.Add(evento);
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error en Insert: " + ex.Message);
                Console.WriteLine(ex.Message);
            }

            return eventos;
        }
        public Evento SelectEventosByLocalizacion(string localizacion)
        {
            Evento evento = null;

            try
            {
                string sql = "SELECT * FROM Ruta WHERE Localizacion=@pLocalizacion";
                SqlCommand cmd = new SqlCommand(sql, cnx.MiCnx);
                SqlParameter pLocalizacion = new SqlParameter("@pLocalizacion", localizacion);
                cmd.Parameters.Add(pLocalizacion);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    evento = new Ruta();
                    evento.IdRuta = (int)dr["RutaID"];
                    evento.Nombre = (string)(dr["Nombre"]);
                    evento.LongitudKm = (float)GestionarNulos(dr["LongitudKm"]);
                    evento.NivelAccesibilidad = (int)GestionarNulos(dr["NivelAccesibilidad"]);
                    evento.Localizacion = (string)(dr["Localizacion"]);
                    evento.ValoracionMedia = (float)GestionarNulos(dr["ValoracionMedia"]);
                    evento.FkIDUsuario = (int)GestionarNulos(dr["FKIDUsuario"]);
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error en Insert: " + ex.Message);
                Console.WriteLine(ex.Message);
            }

            return evento;
        }
        public object GestionarNulos(object valOriginal)
        {
            if (valOriginal == System.DBNull.Value)
                return null;
            else
                return valOriginal;
        }        
    }
}