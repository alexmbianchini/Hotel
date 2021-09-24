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
    class HuespedDao : IHuesped
    {
        public DataTable RecuperarTodos()
        {
            string consulta= "SELECT h.nombre, h.apellido, h.numero_pasaporte, h.mail, p.nombre as pais" +
                " FROM HUESPEDES h JOIN PAISES p ON (h.pais_residencia = p.id)" +
                " WHERE h.borrado_logico = 0";

            return DBHelper.ObtenerInstancia().Ejecutar(consulta);
        }

        public DataTable RecuperarPorNumero(string id)
        {
            string consulta = "SELECT h.nombre, h.apellido, h.numero_pasaporte, h.mail, h.pais_residencia as pais" +
                " FROM HUESPEDES h " +
                " WHERE borrado_logico = 0" +
                " AND h.numero_pasaporte = '" + id + "'";

            return DBHelper.ObtenerInstancia().Ejecutar(consulta);
        }

        public bool ValidarPasaporte(string pasaporte)
        {
            string consulta = "SELECT numero_pasaporte FROM HUESPEDES" +
                " WHERE numero_pasaporte = '" + pasaporte + "' ";

            DataTable tabla = DBHelper.ObtenerInstancia().Ejecutar(consulta);
            if (tabla.Rows.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
    
        }

       
        
        public bool Crear(Huesped oHuesped)
        {
            string consulta = "INSERT INTO HUESPEDES (nombre, apellido, pais_residencia, numero_pasaporte, borrado_logico, mail)" +
                " VALUES (" +
                 " '" + oHuesped.Nombre + "'," +
                 " '" + oHuesped.Apellido + "'," +
                 "  " + oHuesped.PaisResidencia + "," +
                 " '" + oHuesped.NumeroPasaporte + "', 0," +
                 " '" + oHuesped.Mail + "')";

            DBHelper.ObtenerInstancia().Actualizar(consulta);
            return true;
        }


        public bool Modificar(Huesped oHuesped)
        {
            string consulta = "UPDATE HUESPEDES SET " +
                " nombre = '" + oHuesped.Nombre + "'," +
                " apellido = '" + oHuesped.Apellido + "'," +
                " pais_residencia = " + oHuesped.PaisResidencia + "" +
                " WHERE numero_pasaporte = '" + oHuesped.NumeroPasaporte + "'";

            DBHelper.ObtenerInstancia().Actualizar(consulta);
            return true;
        }

        public bool Eliminar(Huesped oHuesped)
        {
            string consulta = "UPDATE HUESPEDES SET borrado_logico = 1" +
                " WHERE numero_pasaporte = '" + oHuesped.NumeroPasaporte + "'";


            DBHelper.ObtenerInstancia().Actualizar(consulta);
            return true;
        }
    }
}
