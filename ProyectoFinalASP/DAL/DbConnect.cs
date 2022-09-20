using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace ProyectoFinalASP.DAL
{
    public class DbConnect
    {
        SqlConnection miCnx = null;
        public SqlConnection MiCnx { get => miCnx; set => miCnx = value; }

        public DbConnect()
        {
            MiCnx = new SqlConnection(
    "Data Source=46.183.116.173,54321;Initial Catalog=GrupoRutas;User ID=GrupoRutas;Password=4e5r448r5g585op265;");
            MiCnx.Open();
        }
    }
}