using Hotel.Datos.Interfaces;
using Hotel.Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Datos.Dao
{
    class VehiculoDao : IVehiculo
    {
        public DataTable RecuperarTodos()
        {
            string consulta = "SELECT v.patente, v.marca, v.modelo, h.numero_pasaporte as pasaporte, h.nombre, h.apellido, v.id" +
                " FROM VEHICULOS v" +
                " JOIN HUESPEDES h ON (v.id_huesped = h.id)" +
                " WHERE v.borrado_logico = 0";

            return DBHelper.ObtenerInstancia().Ejecutar(consulta);
        }

        public DataTable RecuperarFiltrados(string patente, string marca, string pasaporte)
        {
            string consulta = "SELECT v.patente, v.marca, v.modelo, h.numero_pasaporte as pasaporte, h.nombre, h.apellido, v.id" +
                            " FROM VEHICULOS v" +
                            " JOIN HUESPEDES h ON (v.id_huesped = h.id)" +
                            " WHERE v.borrado_logico = 0";

            if (!string.IsNullOrEmpty(patente))
            {
                consulta += " AND v.patente LIKE '%" + patente + "%'";
            }
            if (!string.IsNullOrEmpty(marca))
            {
                consulta += " AND v.marca LIKE '%" + marca + "%'";
            }
            if (!string.IsNullOrEmpty(pasaporte))
            {
                consulta += " AND v.pasaporte_huesped LIKE '" + pasaporte + "%'";
            }

            return DBHelper.ObtenerInstancia().Ejecutar(consulta);
        }

        public DataTable RecuperarPorId(int id)
        {
            string consulta = "SELECT v.patente, v.marca, v.modelo, h.numero_pasaporte as pasaporte, h.nombre, h.apellido" +
                " FROM VEHICULOS v" +
                " JOIN HUESPEDES h ON (v.id_huesped = h.id)" +
                " WHERE v.borrado_logico = 0" +
                " AND v.id = " + id + "";

            return DBHelper.ObtenerInstancia().Ejecutar(consulta);
        }

        public DataTable RecuperarIds()
        {
            string consulta = "SELECT id FROM VEHICULOS";

            return DBHelper.ObtenerInstancia().Ejecutar(consulta);
        }

        private int CrearId()
        {
            DataTable tabla = RecuperarIds();

            return tabla.Rows.Count + 1;
        }

        public bool Crear(Vehiculo oVehiculo)
        {
            int id = CrearId();

            string consulta = "INSERT INTO VEHICULOS (patente, marca, modelo, id_huesped, borrado_logico, id)" +
                " VALUES (" +
                 " '" + oVehiculo.Patente + "'," +
                 " '" + oVehiculo.Marca + "'," +
                 " '" + oVehiculo.Modelo + "'," +
                 " '" + oVehiculo.IdHuesped + "', 0," +
                 "" + id + ")";

            DBHelper.ObtenerInstancia().Actualizar(consulta);
            return true;
        }


        public bool Modificar(Vehiculo oVehiculo)
        {
            string consulta = "UPDATE VEHICULOS SET " +
                " marca = '" + oVehiculo.Marca + "'," +
                " modelo = '" + oVehiculo.Modelo + "'" +
                " WHERE id = " + oVehiculo.Id + "";

            DBHelper.ObtenerInstancia().Actualizar(consulta);
            return true;
        }

        public bool Eliminar(Vehiculo oVehiculo)
        {
            string consulta = "UPDATE VEHICULOS SET borrado_logico = 1" +
                " WHERE id = " + oVehiculo.Id + "";


            DBHelper.ObtenerInstancia().Actualizar(consulta);
            return true;
        }

    }
}
