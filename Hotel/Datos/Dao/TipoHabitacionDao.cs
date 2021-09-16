﻿using Hotel.Datos.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Datos.Dao
{
    class TipoHabitacionDao : ITipoHabitacion
    {
        public DataTable RecuperarTodos()
        {
            string consulta = "SELECT * FROM TIPO_HABITACION WHERE borrado_logico = 0 ORDER BY 1";

            return DBHelper.ObtenerInstancia().Ejecutar(consulta);
        }
    }
}
