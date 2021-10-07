using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Hotel.Componentes
{
    class Validaciones
    {
        public bool PasaporteCorrecto(string pasaporte)
        {

            Regex formato = new Regex(@"[A-Z]{3}[0-9]{6}");

            if (pasaporte.Length == 9)
            {
                if (formato.IsMatch(pasaporte))
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            else
            {
                return false;
            }

        }
    }
}
