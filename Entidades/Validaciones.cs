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
        static public double ValidarDouble(string strDouble)
        {
            bool isDouble = true;
            double doubleReturned = 0;
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
                Double.TryParse(strDouble, out doubleReturned);
            }

            return doubleReturned;
        }
        #endregion
    }
}
