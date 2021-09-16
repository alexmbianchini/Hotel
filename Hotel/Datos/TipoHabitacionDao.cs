﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Datos
{
    class TipoHabitacionDao
    {
        public DataTable RecuperarTodos()
        {
            string consulta = "SELECT * FROM TIPO_HABITACION WHERE borrado_logico = 0 ORDER BY 1";

            DBHelper oDatos = new DBHelper();
            return oDatos.consultar(consulta);
        }
    }
}
