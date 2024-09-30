using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relacion1E01_FranGV.Clases
{
    public class Persona
    {
        // CONSTANTES
        #region CONSTANTES
        private int MAX_NAME = 20;
        private int MIN_NAME = 3;

        private int MAX_SURNAMES = 40;
        private int MIN_SURNAMES = 4;

        private int MAX_AGE = 70;
        private int MIN_AGE = 5;

        // RECURSOS
        private string _nombre;
        private string _apellidos;
        private int _edad;
        #endregion

        // CONSTRUCTORES
        public Persona(string nombre, string apellidos, int edad)
        {
            Nombre = nombre;
            Apellidos = apellidos;
            Edad = edad;
        }

        // PROPIEDADES

        public string Nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                _nombre = ValidarCadena(value, MAX_NAME, MIN_NAME);
            }
        }

        public string Apellidos
        {
            get
            {
                return _apellidos;
            }
            set
            {
                value = ValidarCadena(value, MAX_SURNAMES, MIN_SURNAMES);
            }
        }

        public int Edad
        {
            get
            {
                return _edad;
            }
            set
            {
                ValidarEdad(value);
                _edad = value;
            }
        }

        // MÉTODOS
        /// <summary>
        /// Validación de las cadenas
        /// </summary>
        /// <param name="cadena">Cadena a validar</param>
        /// <param name="max">Máximo de la cadena</param>
        /// <param name="min">Mínimo de la cadena</param>
        /// <returns>Cadena formateada</returns>
        /// <exception cref="CadenaVaciaException">En el caso de que haya cadena vacía</exception>
        /// <exception cref="Exception">Excepciones generales</exception>
        public static string ValidarCadena(string cadena, int max, int min)
        {
            cadena = cadena.Trim();

            if (string.IsNullOrEmpty(cadena)) throw new CadenaVaciaException();


            if (cadena.Length > max) throw new Exception("Cadena superior al máximo establecido");
            if (cadena.Length < min) throw new Exception("Cadena inferior al mínimo establecido");


            return cadena;
        }

        /// <summary>
        /// Validacion de la edad
        /// </summary>
        /// <param name="num">Edad a validar</param>
        /// <exception cref="Exception"></exception>
        public  void ValidarEdad(int num)
        {
            if (num > MAX_AGE) throw new Exception("Número superior al máximo permitido");
            if (num < MIN_AGE) throw new Exception("Número inferior al máximo permitido");
        }
    }


}


// EXCEPCIONES PERSONALIZADAS
public class CadenaVaciaException : Exception
    {
        public CadenaVaciaException() : base("Cadena Vacía") { }
        public CadenaVaciaException(string message) : base(message) { }
    }


