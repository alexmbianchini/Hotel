using Hotel.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Negocio
{
    class Habitacion
    {
        public int Numero { get; set; }
        public int Piso { get; set; }
        public int TipoHabitacion { get; set; }
        public float Precio { get; set; }
        public bool BorradoLogico { get; set; }
        public string Descripcion { get; set; }
        public bool EstaOcupada { get; set; }

        public DataTable RecuperarTodos()
        {
            string consulta = "SELECT * FROM HABITACIONES WHERE borrado_logico = 0 ORDER BY 1";

            DBHelper oDatos = new DBHelper();
            return oDatos.consultar(consulta);
        }

        public DataTable RecuperarGrilla()
        {
            string consulta = "SELECT h.numero, h.esta_ocupada as estado, h.piso, h.descripcion as descripcion, h.precio, t.descripcion as tipo" +
                " FROM HABITACIONES h JOIN TIPO_HABITACION t ON(h.tipo_habitacion = t.cod_tipo)" +
                " WHERE h.borrado_logico = 0" +
                " ORDER BY 1";


            DBHelper oDatos = new DBHelper();
            return oDatos.consultar(consulta);
        }
        public DataTable RecuperarFiltrados(string numero, string piso, string tipo)
        {
            string consulta = "SELECT h.numero, h.esta_ocupada as estado, h.piso, h.descripcion as descripcion, h.precio, t.descripcion as tipo" +
                " FROM HABITACIONES h JOIN TIPO_HABITACION t ON(h.tipo_habitacion = t.cod_tipo)" +
                " WHERE h.borrado_logico = 0";

            if (!string.IsNullOrEmpty(numero))
                consulta += " AND h.numero = " + numero;
            if (!string.IsNullOrEmpty(piso))
                consulta += " AND h.piso = " + piso;
            if (!string.IsNullOrEmpty(tipo))
                consulta += " AND t.descripcion = " + tipo;


            consulta += "ORDER BY 1";
            DBHelper oDatos = new DBHelper();
            return oDatos.consultar(consulta);
        }
    }


}


