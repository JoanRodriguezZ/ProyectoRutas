using ProyectoFinalASP.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoFinalASP.DAL
{
    public class DALEvento
    {
        /*
        DbConnect cnx;
        public DALEvento()
        {
            cnx = new DbConnect();
        }
        public void InsertEvento(Evento evento)
        {
            try
            {
                string sql = @"INSERT INTO Ruta 
                    (Nombre, LongitudKm, NivelAccesibilidad, 
                    Localizacion, ValoracionMedia, FKIDUsuario)
                    VALUES (@pNombre,
                        @pLongitudKm,
                        @pNivelAccesibilidad,
                        @pLocalizacion,
                        @pValoracionMedia,
                        @pFKIDUsuario)";
                SqlCommand cmd = new SqlCommand(sql, cnx.MiCnx);

                SqlParameter pNombre = new SqlParameter("@pNombre", System.Data.SqlDbType.NVarChar, 50);
                pNombre.Value = evento.Nombre;
                SqlParameter pLongitudKm = new SqlParameter("@pLongitudKm", System.Data.SqlDbType.Float);
                pLongitudKm.Value = evento.LongitudKm;
                SqlParameter pNivelAccesibilidad = new SqlParameter("@pNivelAccesibilidad", System.Data.SqlDbType.Int);
                pNivelAccesibilidad.Value = evento.NivelAccesibilidad;
                SqlParameter pLocalizacion = new SqlParameter("@pLocalizacion", System.Data.SqlDbType.NVarChar, 200);
                pLocalizacion.Value = evento.Localizacion;
                SqlParameter pValoracionMedia = new SqlParameter("@pValoracionMedia", System.Data.SqlDbType.Float);
                pValoracionMedia.Value = evento.ValoracionMedia;
                SqlParameter pFKIDUsuario = new SqlParameter("@pFKIDUsuario", System.Data.SqlDbType.Int);
                pFKIDUsuario.Value = evento.FkIDUsuario;

                cmd.Parameters.Add(pNombre);
                cmd.Parameters.Add(pLongitudKm);
                cmd.Parameters.Add(pNivelAccesibilidad);
                cmd.Parameters.Add(pLocalizacion);
                cmd.Parameters.Add(pValoracionMedia);
                cmd.Parameters.Add(pFKIDUsuario);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error en Insert: " + ex.Message);
                Console.WriteLine(ex.Message);
            }
        }
        public List<Evento> SelectEventos()
        {
            List<Evento> eventos = new List<Evento>();
            Evento evento;

            try
            {
                string sql = "SELECT * FROM Ruta ORDER BY Localizacion";
                SqlCommand cmd = new SqlCommand(sql, cnx.MiCnx);
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
        public Evento SelectRutaByLocalizacion(string localizacion)
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
        */
    }
}