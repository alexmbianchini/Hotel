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
    class EmpleadoDao : IEmpleado
    {
        public DataTable RecuperarTodos()
        {
            /*
            string consulta = "SELECT e.id_empleado, e.nro_doc, e.apellido, e.nombre, t.tipo_doc," +
                " t.descripcion as tpo_doc, p.cod_puesto, p.descripcion as puesto" +
                " FROM EMPLEADOS e" +
                " JOIN TIPO_DOCUMENTO t ON (e.tipo_doc = t.tipo_doc)" +
                " JOIN PUESTOS p on (e.puesto = p.cod_puesto)" +
                " WHERE e.borrado_logico = 0 " +
                " ORDER BY e.id_empleado";
            */

            string consulta = "SELECT * FROM EMPLEADOS WHERE borrado_logico = 0 ORDER BY 3";

            return DBHelper.ObtenerInstancia().Ejecutar(consulta);
        }

        public DataTable RecuperarIds()
        {
            string consulta = "SELECT id_empleado FROM EMPLEADOS";

            return DBHelper.ObtenerInstancia().Ejecutar(consulta);
        }

        public DataTable RecuperarPorId(int id)
        {
            string consulta = "SELECT id_empleado, tipo_doc, nro_doc, apellido, nombre, puesto" +
                " FROM EMPLEADOS" +
                " WHERE id_empleado =" + id;

            return DBHelper.ObtenerInstancia().Ejecutar(consulta);
        }

        public string ValidarEmpleadoExistente(string nroDoc, string tipoDoc)
        {

            string consulta = "SELECT * FROM EMPLEADOS WHERE nro_doc ='" + nroDoc + "'" +
                " AND tipo_doc= '" + tipoDoc + "'" +
                " AND borrado_logico = 0";

            DataTable tabla = DBHelper.ObtenerInstancia().Ejecutar(consulta);
            if (tabla.Rows.Count > 0)
            {
                return string.Empty;
            }
            else
            {
                return nroDoc;
            }
        }

        public bool Crear(Empleado oEmpleado)
        {
            string consulta = "INSERT INTO EMPLEADOS (id_empleado, tipo_doc, nro_doc, apellido, nombre, fecha_ingreso_trabajo, fecha_salida_trabajo, puesto, borrado_logico)" +
                " VALUES (" +
                " '" + oEmpleado.IdEmpleado + "'," +
                " '" + oEmpleado.TipoDoc + "'," +
                " '" + oEmpleado.NroDoc + "'," +
                " '" + oEmpleado.Apellido + "'," +
                " '" + oEmpleado.Nombre + "'," +
                " CONVERT(DATETIME, '" + oEmpleado.FechaIngresoTrabajo + "', 103)," +
                " Null," +
                " '" + oEmpleado.Puesto + "', 0)";

            DBHelper.ObtenerInstancia().Actualizar(consulta);
            return true;
        }

        public bool Eliminar(Empleado oEmpleado)
        {
            string consulta = "UPDATE EMPLEADOS SET borrado_logico = 1," +
                " fecha_salida_trabajo = CONVERT(DATETIME,'" + oEmpleado.FechaSalidaTrabajo + "', 103)" +
                " WHERE id_empleado =" + oEmpleado.IdEmpleado;

            DBHelper.ObtenerInstancia().Actualizar(consulta);
            return true;
        }

        public bool Modificar(Empleado oEmpleado)
        {
            string consulta = "UPDATE EMPLEADOS SET " +
                " tipo_doc = '" + oEmpleado.TipoDoc + "'," +
                " nro_doc = '" + oEmpleado.NroDoc + "'," +
                " apellido = '" + oEmpleado.Apellido + "'," +
                " nombre = '" + oEmpleado.Nombre + "', " +
                " puesto = '" + oEmpleado.Puesto + "'" +
                " WHERE id_empleado = " + oEmpleado.IdEmpleado;

            DBHelper.ObtenerInstancia().Actualizar(consulta);
            return true;
        }
    }
}
