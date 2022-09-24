using ProyectoFinalASP.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ProyectoFinalASP.DAL
{
    public class DALParticipante
    {
        DbConnect cnx;
        public DALParticipante()
        {
            cnx = new DbConnect();
        }
        public void InsertParticipante(Participante participante)
        {
            try
            {
                string sql = @"INSERT INTO Participante 
                    (ValoracionRuta, ComentarioRuta)
                    VALUES (@pValoracionRuta,
                        @pComentarioRuta)";
                SqlCommand cmd = new SqlCommand(sql, cnx.MiCnx);

                SqlParameter pValoracionRuta = new SqlParameter("@pValoracionRuta", System.Data.SqlDbType.Int);
                pValoracionRuta.Value = participante.FkIDRuta;
                SqlParameter pComentarioRuta = new SqlParameter("@pComentarioRuta", System.Data.SqlDbType.NVarchar, 400);
                pComentarioRuta.Value = participante.Point;

                cmd.Parameters.Add(pValoracionRuta);
                cmd.Parameters.Add(pComentarioRuta);

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
        //Alguna mas?
        public List<Participante> SelectParticipantesByIdEvento(int idEvento)
        {
            List<Participante> participantes = new List<Participante>();
            Participante participante = null;

            try
            {
                string sql = "SELECT * FROM Participante WHERE FKEventoID=@pfkIDEvento ORDER BY FKUsuarioID";
                SqlCommand cmd = new SqlCommand(sql, cnx.MiCnx);
                SqlParameter pfkIDEvento = new SqlParameter("@pfkIDEvento", idEvento);
                cmd.Parameters.Add(pfkIDEvento);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    participante = new Participante();
                    participante.FkIDEvento = (int)dr["FKEventoID"];
                    participante.FkIDUsuario = (int)(dr["FKUsuarioID"]);
                    participante.ValoracionRuta = (int?)GestionarNulos(dr["ValoracionRuta"]);
                    participante.ComentarioRuta = (string)GestionarNulos(dr["ComentarioRuta"]);

                    participantes.Add(participante);
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

            return participantes;
        }
        public int SelectCountParticipantesByIdEvento(int idEvento)
        {
            int participantes = 0;

            try
            {
                string sql = "SELECT COUNT(*) FROM Participante WHERE FKEventoID=@pfkIDEvento";
                SqlCommand cmd = new SqlCommand(sql, cnx.MiCnx);
                SqlParameter pfkIDEvento = new SqlParameter("@pfkIDEvento", idEvento);
                cmd.Parameters.Add(pfkIDEvento);

                SqlDataReader dr = cmd.ExecuteReader();

                /* No se si hay que hacer un read e ir sumando cuantos hay,:
                 * while (dr.Read())
                 *{
                 *    participantes += 1;
                 *}
                 *
                 * o el dr devuelve directamente el valor de el count y habria que hacer algo tipo este parse:
                 * participantes = ParseToInt32(dr)                
                 */
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

            return participantes;
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