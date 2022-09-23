using ProyectoFinalASP.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ProyectoFinalASP.DAL
{
    public class DALRuta
    {
        DbConnect cnx;
        public DALRuta()
        {
            cnx = new DbConnect();
        }
        public void InsertRuta(Ruta ruta)
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
                pNombre.Value = ruta.Nombre;
                SqlParameter pLongitudKm = new SqlParameter("@pLongitudKm", System.Data.SqlDbType.Float);
                pLongitudKm.Value = ruta.LongitudKm;
                SqlParameter pNivelAccesibilidad = new SqlParameter("@pNivelAccesibilidad", System.Data.SqlDbType.Int);
                pNivelAccesibilidad.Value = ruta.NivelAccesibilidad;
                SqlParameter pLocalizacion = new SqlParameter("@pLocalizacion", System.Data.SqlDbType.NVarChar, 200);
                pLocalizacion.Value = ruta.Localizacion;
                SqlParameter pValoracionMedia = new SqlParameter("@pValoracionMedia", System.Data.SqlDbType.Float);
                pValoracionMedia.Value = ruta.ValoracionMedia;
                SqlParameter pFKIDUsuario = new SqlParameter("@pFKIDUsuario", System.Data.SqlDbType.Int);
                pFKIDUsuario.Value = ruta.FkIDUsuario;

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
            finally
            {
                cnx.MiCnx.Close();
            }
        }
        public List<Ruta> SelectRutasOrderByLocalizacion()
        {
            List<Ruta> rutas = new List<Ruta>();
            Ruta ruta;

            try
            {
                string sql = "SELECT * FROM Ruta ORDER BY Localizacion";
                SqlCommand cmd = new SqlCommand(sql, cnx.MiCnx);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    ruta = new Ruta();
                    ruta.IdRuta = (int)dr["RutaID"];
                    ruta.Nombre = (string)(dr["Nombre"]);
                    ruta.LongitudKm = (float)GestionarNulos(dr["LongitudKm"]);
                    ruta.NivelAccesibilidad = (int)GestionarNulos(dr["NivelAccesibilidad"]);
                    ruta.Localizacion = (string)(dr["Localizacion"]);
                    ruta.ValoracionMedia = (float?)GestionarNulos(dr["ValoracionMedia"]);
                    ruta.FkIDUsuario = (int)GestionarNulos(dr["FKIDUsuario"]);

                    rutas.Add(ruta);
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

            return rutas;
        }
        public List<Ruta> SelectRutasByLocalizacion(string localizacion)
        {
            List<Ruta> rutas = new List<Ruta>();
            Ruta ruta = null;

            try
            {
                string sql = "SELECT * FROM Ruta WHERE Localizacion=@pLocalizacion";
                SqlCommand cmd = new SqlCommand(sql, cnx.MiCnx);
                SqlParameter pLocalizacion = new SqlParameter("@pLocalizacion", localizacion);
                cmd.Parameters.Add(pLocalizacion);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    ruta = new Ruta();
                    ruta.IdRuta = (int)dr["RutaID"];
                    ruta.Nombre = (string)(dr["Nombre"]);
                    ruta.LongitudKm = (float)GestionarNulos(dr["LongitudKm"]);
                    ruta.NivelAccesibilidad = (int)GestionarNulos(dr["NivelAccesibilidad"]);
                    ruta.Localizacion = (string)(dr["Localizacion"]);
                    ruta.ValoracionMedia = (float?)GestionarNulos(dr["ValoracionMedia"]);
                    ruta.FkIDUsuario = (int)GestionarNulos(dr["FKIDUsuario"]);

                    rutas.Add(ruta);
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

            return rutas;
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