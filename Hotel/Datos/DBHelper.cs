using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Datos
{
    class DBHelper
    {
        private SqlConnection conexion = new SqlConnection();
        private SqlCommand comando = new SqlCommand();

        //private string cadenaConexion = @"Data Source=sql5103.site4now.net;Initial Catalog = db_a78fa0_hotel; Persist Security Info=True;User ID = db_a78fa0_hotel_admin";
        private string cadenaConexion = @"Data Source=sql5103.site4now.net;Initial Catalog=db_a78fa0_hotel;User ID=db_a78fa0_hotel_admin;Password=alexlufabri3k1";


        public DataTable consultar(string consultaSQL)
        {
            DataTable tabla = new DataTable();
            conexion.ConnectionString = cadenaConexion;
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
            comando.CommandText = consultaSQL;
            tabla.Load(comando.ExecuteReader());
            conexion.Close();
            return tabla;
        }
    }
 }
