using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Entidades
{
    public static class Validaciones
    {
        #region Methods
        /// <summary>
        /// Valida que el string ingresado sea un entero válido.
        /// </summary>
        /// <param name="strInt"></param>
        /// <returns>Retorna el numero entero ó -1 en caso de no ser un entero.</returns>
        static public int ValidarInt(string strValue)
        {
            int returnValue;

            if (int.TryParse(strValue, out returnValue))
            {
                return returnValue;
            }
            else
            {
                return -1;
            }
        }
        
        /// <summary>
        /// Valida que el string ingresado sea un double válido.
        /// </summary>
        /// <param name="strValue"></param>
        /// <returns>Retorna el numero double ó -1 en caso de no ser un double.</returns>
        static public double ValidarDouble(string strValue)
        {
            double returnValue;

            if (double.TryParse(strValue, out returnValue))
            {
                return returnValue;
            }
            else
            {
                return -1;
            }
        }

        /// <summary>
        /// Valida que el string ingresado sea un long válido.
        /// </summary>
        /// <param name="strValue"></param>
        /// <returns>Retorna el numero long ó -1 en caso de no ser un long.</returns>
        static public long ValidarLong(string strValue)
        {
            long returnValue;

            if (long.TryParse(strValue, out returnValue))
            {
                return returnValue;
            }
            else
            {
                return -1;
            }
        }

        /// <summary>
        /// Valida que el string ingresado posea 2 ó mas caracteres.
        /// </summary>
        /// <param name="strValue"></param>
        /// <returns>Retorna true si el string posee 2 ó mas caracteres, caso contrario retorna false.</returns>
        static public bool ValidarString(string strValue)
        {
            bool returnValue = false;

            if(strValue.Length > 1)
            {
                returnValue = true;
            }

            return returnValue;
        }

        /// <summary>
        /// Valida una dirección de email.
        /// </summary>
        /// <param name="strValue"></param>
        /// <returns>Retorna true si el email es válido, caso contrario retorna false.</returns>
        static public bool ValidarEmail(string strValue)
        {
            bool returnValue = false;
            string regex = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";

            if (Regex.IsMatch(strValue, regex))
            {
                returnValue = true;
            }

            return returnValue;
        }
        #endregion
    }
}
