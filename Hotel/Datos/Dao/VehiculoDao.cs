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
            string consulta = "SELECT v.patente, v.marca, v.modelo, v.pasaporte_huesped as pasaporte, h.nombre, h.apellido" +
                " FROM VEHICULOS v" +
                " JOIN HUESPEDES h ON (v.pasaporte_huesped = h.numero_pasaporte)" +
                " WHERE v.borrado_logico = 0";

            return DBHelper.ObtenerInstancia().Ejecutar(consulta);
        }

        public DataTable RecuperarFiltrados(string patente, string marca, string pasaporte)
        {
            string consulta = "SELECT v.patente, v.marca, v.modelo, v.pasaporte_huesped as pasaporte, h.nombre, h.apellido" +
                            " FROM VEHICULOS v" +
                            " JOIN HUESPEDES h ON (v.pasaporte_huesped = h.numero_pasaporte)" +
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

        public DataTable RecuperarPorPatente(string patente)
        {
            string consulta = "SELECT v.patente, v.marca, v.modelo, v.pasaporte_huesped as pasaporte, h.nombre, h.apellido" +
                " FROM VEHICULOS v" +
                " JOIN HUESPEDES h ON (v.pasaporte_huesped = h.numero_pasaporte)" +
                " WHERE v.borrado_logico = 0" +
                " AND v.patente = '" + patente + "'";

            return DBHelper.ObtenerInstancia().Ejecutar(consulta);
        }

        public bool Crear(Vehiculo oVehiculo)
        {
            string consulta = "INSERT INTO VEHICULOS (patente, marca, modelo, pasaporte_huesped, borrado_logico)" +
                " VALUES (" +
                 " '" + oVehiculo.Patente + "'," +
                 " '" + oVehiculo.Marca + "'," +
                 " '" + oVehiculo.Modelo + "'," +
                 " '" + oVehiculo.PasaporteHuesped + "', 0)";

            DBHelper.ObtenerInstancia().Actualizar(consulta);
            return true;
        }


        public bool Modificar(Vehiculo oVehiculo)
        {
            string consulta = "UPDATE VEHICULOS SET " +
                " marca = '" + oVehiculo.Marca + "'," +
                " modelo = '" + oVehiculo.Modelo + "'" +
                " WHERE patente = '" + oVehiculo.Patente + "'";

            DBHelper.ObtenerInstancia().Actualizar(consulta);
            return true;
        }

        public bool Eliminar(Vehiculo oVehiculo)
        {
            string consulta = "UPDATE VEHICULOS SET borrado_logico = 1" +
                " WHERE patente = '" + oVehiculo.Patente + "'";


            DBHelper.ObtenerInstancia().Actualizar(consulta);
            return true;
        }

    }
}
