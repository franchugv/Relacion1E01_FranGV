using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relacion1E01_FranGV
{
    public static class Metodos
    {
        public static int ConvertirInt(string cadena)
        {
            // Recursos
            int numero = 0;

            // Proceso
            if (string.IsNullOrEmpty(cadena)) throw new CadenaVaciaException();
            numero = Convert.ToInt32(cadena);

            // Salida
            return numero;
        }
    }
}
