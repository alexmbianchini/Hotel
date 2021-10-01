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
            string consulta= "SELECT h.nombre, h.apellido, h.numero_pasaporte, h.mail, p.nombre as pais, h.id" +
                " FROM HUESPEDES h JOIN PAISES p ON (h.pais_residencia = p.id)" +
                " WHERE h.borrado_logico = 0";

            return DBHelper.ObtenerInstancia().Ejecutar(consulta);
        }

        public DataTable RecuperarFiltrados(string nombre, string apellido, string pasaporte , string pais)
        {
            string consulta = "SELECT h.nombre, h.apellido, h.numero_pasaporte, h.mail, p.nombre as pais, h.id" +
                " FROM HUESPEDES h JOIN PAISES p ON (h.pais_residencia = p.id)" +
                " WHERE h.borrado_logico = 0";

            if (!string.IsNullOrEmpty(nombre))
            {
                consulta += " AND h.nombre LIKE '%" + nombre + "%'";
            }
            if (!string.IsNullOrEmpty(apellido))
            {
                consulta += " AND h.apellido LIKE '%" + apellido + "%'";
            }
            if (!string.IsNullOrEmpty(pasaporte))
            {
                consulta += " AND h.numero_pasaporte LIKE '" + pasaporte +  "%'";
            }
            if (!string.IsNullOrEmpty(pais))
            {
                consulta += " AND h.pais_residencia = " + pais;
            }

            return DBHelper.ObtenerInstancia().Ejecutar(consulta);
        }

        public DataTable RecuperarPorNumero(int id)
        {
            string consulta = "SELECT h.nombre, h.apellido, h.numero_pasaporte, h.mail, h.pais_residencia as pais" +
                " FROM HUESPEDES h " +
                " WHERE borrado_logico = 0" +
                " AND h.id = " + id + "";

            return DBHelper.ObtenerInstancia().Ejecutar(consulta);
        }

        public DataTable RecuperarPorPasaporte(string pasaporte)
        {
            string consulta = "SELECT h.nombre, h.apellido, h.id" +
                " FROM HUESPEDES h " +
                " WHERE borrado_logico = 0" +
                " AND h.numero_pasaporte = '" + pasaporte + "'";

            return DBHelper.ObtenerInstancia().Ejecutar(consulta);
        }

        public bool ValidarPasaporte(string pasaporte)
        {
            string consulta = "SELECT numero_pasaporte FROM HUESPEDES" +
                " WHERE borrado_logico = 0" +
                " AND numero_pasaporte = '" + pasaporte + "' ";

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

        public DataTable RecuperarIds()
        {
            string consulta = "SELECT h.id" +
                " FROM HUESPEDES h ";

            return DBHelper.ObtenerInstancia().Ejecutar(consulta);
        }

        private int CrearId()
        {
            DataTable tabla = RecuperarIds();

            return tabla.Rows.Count + 1;

        }
        
        public bool Crear(Huesped oHuesped)
        {

            int id = CrearId();

            oHuesped.Id = id;

            string consulta = "INSERT INTO HUESPEDES (nombre, apellido, pais_residencia, numero_pasaporte, borrado_logico, mail, id)" +
                " VALUES (" +
                 " '" + oHuesped.Nombre + "'," +
                 " '" + oHuesped.Apellido + "'," +
                 "  " + oHuesped.PaisResidencia + "," +
                 " '" + oHuesped.NumeroPasaporte + "', 0," +
                 " '" + oHuesped.Mail + "'," +
                 "" + oHuesped.Id + ")";

            DBHelper.ObtenerInstancia().Actualizar(consulta);
            return true;
        }


        public bool Modificar(Huesped oHuesped)
        {
            string consulta = "UPDATE HUESPEDES SET " +
                " nombre = '" + oHuesped.Nombre + "'," +
                " apellido = '" + oHuesped.Apellido + "'," +
                " pais_residencia = " + oHuesped.PaisResidencia + "," +
                " mail = '" + oHuesped.Mail + "'" +
                " WHERE id = " + oHuesped.Id;

            DBHelper.ObtenerInstancia().Actualizar(consulta);
            return true;
        }

        public bool Eliminar(Huesped oHuesped)
        {
            string consulta = "UPDATE HUESPEDES SET borrado_logico = 1" +
                " WHERE id = " + oHuesped.Id;


            DBHelper.ObtenerInstancia().Actualizar(consulta);
            return true;
        }


    }
}
