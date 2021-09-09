using Hotel.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Negocio
{
    class Empleado
    {
        public int IdEmpleado { get; set; }
        public int TipoDoc { get; set; }
        public int NroDoc { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaIngresoTrabajo { get; set; }
        public DateTime FechaSalidaTrabajo { get; set; }
        public int Puesto { get; set; }
        public bool BorradoLogico { get; set; }

        public DataTable RecuperarTodos()
        {
            string consulta = "SELECT * FROM EMPLEADOS WHERE borrado_logico = 0 ORDER BY 4";

            DBHelper oDatos = new DBHelper();
            return oDatos.consultar(consulta);
        }

        public DataTable RecuperarIds()
        {
            string consulta = "SELECT id_empleado FROM EMPLEADOS";

            DBHelper oDatos = new DBHelper();
            return oDatos.consultar(consulta);
        }

        public DataTable RecuperarPorId(int id)
        {
            string consulta = "SELECT id_empleado, tipo_doc, nro_doc, apellido, nombre, puesto" +
                " FROM EMPLEADOS" +
                " WHERE id_empleado =" + id;

            DBHelper oDatos = new DBHelper();
            return oDatos.consultar(consulta);
        }

        public string validarEmpleadoExistente(string nroDoc, string tipoDoc){

            string consulta = "SELECT * FROM EMPLEADOS WHERE nro_doc ='" + nroDoc + "' AND tipo_doc= '"+ tipoDoc +"'";

            DBHelper oDatos = new DBHelper();
            DataTable tabla = oDatos.consultar(consulta);
            if (tabla.Rows.Count > 0)
            {
                return string.Empty;
            }
            else
            {
                return nroDoc;
            }
        }

        internal bool Crear(Empleado oEmpleado)
        {
            string consulta = "INSERT INTO EMPLEADOS (id_empleado, tipo_doc, nro_doc, apellido, nombre, fecha_ingreso_trabajo, fecha_salida_trabajo, puesto, borrado_logico)" +
                " VALUES (" +
                " '" + oEmpleado.IdEmpleado + "'," +
                " '" + oEmpleado.TipoDoc + "'," +
                " '" + oEmpleado.NroDoc + "'," +
                " '" + oEmpleado.Apellido + "'," +
                " '" + oEmpleado.Nombre + "'," +
                " '" + oEmpleado.FechaIngresoTrabajo + "'," +
                " Null," +
                " '" + oEmpleado.Puesto + "', 0)";

            DBHelper oDatos = new DBHelper();
            oDatos.consultar(consulta);
            return true;
        }

        internal bool Eliminar(Empleado oEmpleado)
        {
            string consulta = "UPDATE EMPLEADOS SET borrado_logico = 1," +
                " fecha_salida_trabajo = '" + oEmpleado.FechaSalidaTrabajo +"'"+
                " WHERE id_empleado =" + oEmpleado.IdEmpleado;

            DBHelper oDatos = new DBHelper();
            oDatos.consultar(consulta);
            return true;
        }

        internal bool Modificar(Empleado oEmpleado)
        {
            string consulta = "UPDATE EMPLEADOS SET " +
                " tipo_doc = '" + oEmpleado.TipoDoc + "'," +
                " nro_doc = '" + oEmpleado.NroDoc + "'," +
                " apellido = '" + oEmpleado.Apellido + "'," +
                " nombre = '" + oEmpleado.Nombre + "', " +
                " puesto = '" + oEmpleado.Puesto + "'" +
                " WHERE id_empleado = " + oEmpleado.IdEmpleado;

            DBHelper oDatos = new DBHelper();
            oDatos.consultar(consulta);
            return true;
        }
    }
}