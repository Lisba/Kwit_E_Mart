using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    static class Validaciones
    {
        #region Methods
        /// <summary>
        /// Valida que el string ingresado sea un entero válido.
        /// </summary>
        /// <param name="strInt"></param>
        /// <returns>Retorna el numero entero ó -1 en caso de no ser un entero.</returns>
        static public int ValidarInt(string strInt)
        {
            bool isInt;
            int intReturned;

            isInt = int.TryParse(strInt, out intReturned);

            if (isInt)
            {
                return intReturned;
            }
            else
            {
                return -1;
            }
        }

        static public double ValidarDouble(string strDouble)
        {
            bool isDouble = true;
            double doubleReturned = -1;
            int comaCounter = 0;

            foreach (char character in strDouble)
            {
                if ((character < '0' || character > '9') && (character != ',' && character != '.'))
                {
                    isDouble = false;
                    break;
                }

                if (character == ',' || character == '.')
                {
                    comaCounter++;
                }
            }

            if (comaCounter > 1)
            {
                isDouble = false;
            }

            if (isDouble)
            {
                double.TryParse(strDouble, out doubleReturned);
            }

            return doubleReturned;
        }
        #endregion
    }
}
