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
        private static DBHelper instancia;
        private SqlConnection conexion;
        private SqlCommand comando;

        //private string cadenaConexion = @"Data Source=sql5103.site4now.net;Initial Catalog = db_a78fa0_hotel; Persist Security Info=True;User ID = db_a78fa0_hotel_admin";
        private string cadenaConexion;
        private DBHelper()
        {
            conexion = new SqlConnection();
            comando = new SqlCommand();
            string cadenaConexion = @"Data Source=sql5103.site4now.net;Initial Catalog=db_a78fa0_hotel;User ID=db_a78fa0_hotel_admin;Password=alexlufabri3k1";

        }

        public static DBHelper ObtenerInstancia()
        {
            if (instancia == null)
                instancia = new DBHelper();
            
            return instancia;
        }


        public DataTable Ejecutar(string consultaSQL)
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
