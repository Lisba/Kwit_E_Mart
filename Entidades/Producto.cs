using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        #region Fields
        static int idGlobal;
        int id;
        string nombre;
        int cantidad;
        double precioUnidad;
        #endregion

        #region Properties
        public int Id
        {
            get 
            {
                return id;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
        }

        public int Cantidad
        {
            get
            {
                return cantidad;
            }
        }

        public double PrecioUnidad
        {
            get
            {
                return precioUnidad;
            }
        }

        #endregion

        #region Constructors
        static Producto()
        {
            idGlobal = 1;
        }

        public Producto(string nombre, int cantidad, double precioUnidad)
        {
            id = idGlobal++;
            this.nombre = nombre;
            this.cantidad = cantidad;
            this.precioUnidad = precioUnidad;
        }
        #endregion
    }
}
