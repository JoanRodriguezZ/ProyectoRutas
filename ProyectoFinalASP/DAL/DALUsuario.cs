using ProyectoFinalASP.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ProyectoFinalASP.DAL
{
    public class DALUsuario
    {
        DbConnect cnx;
        public DALUsuario()
        {
            cnx = new DbConnect();
        }
        public void InsertUsuario(Usuario user)
        {
            try
            {
                string sql = @"INSERT INTO Usuario 
                    (Password, Nombre, Apellidos, Email, 
                    Telefono, Localidad, PorcentajeMinusvalia, TipoMinusvalia, 
                    Dependencias, EsMinusvalido, EsVoluntario, EsAdministrador)
                    VALUES (@pPassword,
                        @pNombre,
                        @pApellidos,
                        @pEmail,
                        @pTelefono,
                        @pLocalidad,
                        @pPorcentajeMinusvalia,
                        @pTipoMinusvalia,
                        @pDependencias,
                        @pEsMinusvalido,
                        @pEsVoluntario,
                        @pEsAdmin)";
                SqlCommand cmd = new SqlCommand(sql, cnx.MiCnx);

                SqlParameter pPassword = new SqlParameter("@pPassword", System.Data.SqlDbType.NVarChar, 100);
                pPassword.Value = user.Password;
                SqlParameter pNombre = new SqlParameter("@pNombre", System.Data.SqlDbType.NVarChar, 50);
                pNombre.Value = user.Nombre;
                SqlParameter pApellidos = new SqlParameter("@pApellidos", System.Data.SqlDbType.NVarChar, 200);
                pApellidos.Value = user.Apellidos;
                SqlParameter pEmail = new SqlParameter("@pEmail", System.Data.SqlDbType.NVarChar, 150);
                pEmail.Value = user.Email;
                SqlParameter pTelefono = new SqlParameter("@pTelefono", System.Data.SqlDbType.NVarChar, 15);
                pTelefono.Value = user.Telefono;
                SqlParameter pLocalidad = new SqlParameter("@pLocalidad", System.Data.SqlDbType.NVarChar, 100);
                pLocalidad.Value = user.Localidad;
                SqlParameter pPorcentajeMinusvalia = new SqlParameter("@pPorcentajeMinusvalia", System.Data.SqlDbType.Int);
                pPorcentajeMinusvalia.Value = user.PorcentajeMinusvalia;
                SqlParameter pTipoMinusvalia = new SqlParameter("@pTipoMinusvalia", System.Data.SqlDbType.NVarChar, 100);
                pTipoMinusvalia.Value = user.TipoMinusvalia;
                SqlParameter pDependencias = new SqlParameter("@pDependencias", System.Data.SqlDbType.NVarChar, 200);
                pDependencias.Value = user.Dependencias;
                SqlParameter pEsMinusvalido = new SqlParameter("@pEsMinusvalido", System.Data.SqlDbType.Bit);
                pEsMinusvalido.Value = user.EsMinusvalido;
                SqlParameter pEsVoluntario = new SqlParameter("@pEsVoluntario", System.Data.SqlDbType.Bit);
                pEsVoluntario.Value = user.EsVoluntario;
                SqlParameter pEsAdmin = new SqlParameter("@pEsAdmin", System.Data.SqlDbType.Bit);
                pEsAdmin.Value = user.EsAdmin;

                cmd.Parameters.Add(pPassword);
                cmd.Parameters.Add(pNombre);
                cmd.Parameters.Add(pApellidos);
                cmd.Parameters.Add(pEmail);
                cmd.Parameters.Add(pTelefono);
                cmd.Parameters.Add(pLocalidad);
                cmd.Parameters.Add(pPorcentajeMinusvalia);
                cmd.Parameters.Add(pTipoMinusvalia);
                cmd.Parameters.Add(pDependencias);
                cmd.Parameters.Add(pEsMinusvalido);
                cmd.Parameters.Add(pEsVoluntario);
                cmd.Parameters.Add(pEsAdmin);

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
        public List<Usuario> SelectUsuariosOrderByNombreApellidos()
        {
            List<Usuario> users = new List<Usuario>();
            Usuario user;

            try
            {
                string sql = "SELECT * FROM Usuario ORDER BY Nombre, Apellidos";
                SqlCommand cmd = new SqlCommand(sql, cnx.MiCnx);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    user = new Usuario();
                    user.IdUsuario = (int)dr["IDUsuario"];
                    user.Password = (string)(dr["Password"]);
                    user.Nombre = (string)GestionarNulos(dr["Nombre"]);
                    user.Apellidos = (string)GestionarNulos(dr["Apellidos"]);
                    user.Email = (string)(dr["Email"]);
                    user.Telefono = (string)GestionarNulos(dr["Telefono"]);
                    user.Localidad = (string)GestionarNulos(dr["Localidad"]);
                    user.PorcentajeMinusvalia = (int)GestionarNulos(dr["PorcentajeMinusvalia"]);
                    user.TipoMinusvalia = (string)GestionarNulos(dr["TipoMinusvalia"]);
                    user.Dependencias = (string)GestionarNulos(dr["Dependencias"]);
                    user.EsMinusvalido = (bool)GestionarNulos(dr["EsMinusvalido"]);
                    user.EsVoluntario = (bool)GestionarNulos(dr["EsVoluntario"]);
                    user.EsAdmin = (bool)GestionarNulos(dr["EsAdministrador"]);

                    users.Add(user);
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

            return users;
        }
        public Usuario SelectUsuarioByEmailPassword(string email, string password)
        {
            Usuario user = null;

            try
            {
                string sql = "SELECT * FROM Usuario WHERE Email=@pEmail AND Password=@pPassword";
                SqlCommand cmd = new SqlCommand(sql, cnx.MiCnx);
                SqlParameter pEmail = new SqlParameter("@pEmail", email);
                SqlParameter pPassword = new SqlParameter("@pPassword", password);
                cmd.Parameters.Add(pEmail);
                cmd.Parameters.Add(pPassword);

                SqlDataReader dr = cmd.ExecuteReader();


                while (dr.Read())
                {
                    user = new Usuario();
                    user.IdUsuario = (int)dr["IDUsuario"];
                    user.Password = (string)(dr["Password"]);
                    user.Nombre = (string)GestionarNulos(dr["Nombre"]);
                    user.Apellidos = (string)GestionarNulos(dr["Apellidos"]);
                    user.Email = (string)(dr["Email"]);
                    user.Telefono = (string)GestionarNulos(dr["Telefono"]);
                    user.Localidad = (string)GestionarNulos(dr["Localidad"]);
                    user.PorcentajeMinusvalia = (int?)GestionarNulos(dr["PorcentajeMinusvalia"]);
                    user.TipoMinusvalia = (string)GestionarNulos(dr["TipoMinusvalia"]);
                    user.Dependencias = (string)GestionarNulos(dr["Dependencias"]);
                    user.EsMinusvalido = (bool)GestionarNulos(dr["EsMinusvalido"]);
                    user.EsVoluntario = (bool)GestionarNulos(dr["EsVoluntario"]);
                    user.EsAdmin = (bool)GestionarNulos(dr["EsAdministrador"]);
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

            return user;
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