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
        private SqlTransaction dbTransaction;

        //private string cadenaConexion = @"Data Source=sql5108.site4now.net;Initial Catalog = db_a78fa0_hotel; Persist Security Info=True;User ID = db_a78fa0_hotel_admin";
        private string cadenaConexion;
        public DBHelper()
        {
            conexion = new SqlConnection();
            comando = new SqlCommand();
            cadenaConexion = @"Data Source=SQL5104.site4now.net;Initial Catalog=db_a7b7c9_hotel;User Id=db_a7b7c9_hotel_admin;Password=alexlufabri3k1";
           
            //cadenaConexion = @"Data Source=sql5108.site4now.net;Initial Catalog=db_a78fa0_hotel;User ID=db_a78fa0_hotel_admin;Password=alexlufabri3k1";

            conexion.ConnectionString = cadenaConexion;

        }
        public void BeginTransaction()
        {
            if (conexion.State == ConnectionState.Open)
                 dbTransaction = conexion.BeginTransaction();
        }

        public void Commit()
        {
            if (dbTransaction != null)
                dbTransaction.Commit();
        }

        public void Rollback()
        {
            if (dbTransaction != null)
                dbTransaction.Rollback();
        }
        public void Open()
        {
            if (conexion.State != ConnectionState.Open)
                conexion.Open();
        }

        public void Close()
        {
            if (conexion.State != ConnectionState.Closed)
                conexion.Close();
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

        public void Actualizar(string consultaSQL)
        {
            DataTable tabla = new DataTable();
            conexion.ConnectionString = cadenaConexion;
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
            comando.CommandText = consultaSQL;
            tabla.Load(comando.ExecuteReader());
            conexion.Close();
        }

        public int Transaccion(string consultaSQL)
        {
            int resultado = 0;

            try
            {
                comando.Connection = conexion;
                comando.Transaction = dbTransaction;
                comando.CommandType = CommandType.Text;
                
                // Instrucción a Ejecutar
                comando.CommandText = consultaSQL;

                resultado = comando.ExecuteNonQuery();

            }
            catch(Exception ex)
            {
                throw ex;
            }
            return resultado;
        }
 
    }
 }
