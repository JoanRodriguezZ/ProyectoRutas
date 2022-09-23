using ProyectoFinalASP.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
            finally
            {
                cnx.MiCnx.Close();
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
                    evento = new Evento();
                    evento.IdEvento = (int)dr["IDEvento"];
                    evento.FkIDRuta = (int)(dr["FKRutaID"]);
                    evento.EsPublico = (bool)(dr["esPublico"]);
                    evento.FechaDeRealizacion = (DateTime?)GestionarNulos(dr["FechaDeRealizacion"]);
                    evento.VoluntariosNecesarios = (int?)GestionarNulos(dr["VoluntariosNecesarios"]);
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
            finally
            {
                cnx.MiCnx.Close();
            }

            return eventos;
        }
        public List<Evento> SelectEventosOrderByEstado()
        {
            List<Evento> eventos = new List<Evento>();
            Evento evento;

            try
            {
                string sql = "SELECT * FROM Evento ORDER BY FKIDEstado";
                SqlCommand cmd = new SqlCommand(sql, cnx.MiCnx);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    evento = new Evento();
                    evento.IdEvento = (int)dr["IDEvento"];
                    evento.FkIDRuta = (int)(dr["FKRutaID"]);
                    evento.EsPublico = (bool)(dr["esPublico"]);
                    evento.FechaDeRealizacion = (DateTime?)GestionarNulos(dr["FechaDeRealizacion"]);
                    evento.VoluntariosNecesarios = (int?)GestionarNulos(dr["VoluntariosNecesarios"]);
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
            finally
            {
                cnx.MiCnx.Close();
            }

            return eventos;
        }
        public List<Evento> SelectEventosByRuta(int fkIDRuta)
        {
            List<Evento> eventos = new List<Evento>();
            Evento evento = null;

            try
            {
                string sql = "SELECT * FROM Evento WHERE FKRutaID=@pfkIDRuta";
                SqlCommand cmd = new SqlCommand(sql, cnx.MiCnx);
                SqlParameter pfkIDRuta = new SqlParameter("@pfkIDRuta", fkIDRuta);
                cmd.Parameters.Add(pfkIDRuta);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    evento = new Evento();
                    evento.IdEvento = (int)dr["IDEvento"];
                    evento.FkIDRuta = (int)(dr["FKRutaID"]);
                    evento.EsPublico = (bool)(dr["esPublico"]);
                    evento.FechaDeRealizacion = (DateTime?)GestionarNulos(dr["FechaDeRealizacion"]);
                    evento.VoluntariosNecesarios = (int?)GestionarNulos(dr["VoluntariosNecesarios"]);
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
            finally
            {
                cnx.MiCnx.Close();
            }

            return eventos;
        }

        //Select event by user, quizas se haga desde participante mas bien

        public object GestionarNulos(object valOriginal)
        {
            if (valOriginal == System.DBNull.Value)
                return null;
            else
                return valOriginal;
        }        
    }
}