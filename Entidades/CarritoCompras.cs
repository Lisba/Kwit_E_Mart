using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class CarritoCompras
    {
        #region Fields
        static List<Producto> listaProductosCarrito;
        #endregion

        public static List<Producto> ListaProductosCarrito
        {
            get
            {
                return listaProductosCarrito;
            }
        }

        #region Constructor
        static CarritoCompras()
        {
            listaProductosCarrito = new List<Producto>();
        }
        #endregion

        #region Methods
        public static void AddNewItemToShopCar(string nombre, int cantidad, double precioUnidad)
        {
            listaProductosCarrito.Add(new Producto(nombre, cantidad, precioUnidad));
        }

        public static void RemoveItemFromShopCar(Producto producto)
        {
            listaProductosCarrito.Remove(producto);
        }

        public static double GetPrecioTotal()
        {
            double total = 0;

            foreach(Producto producto in listaProductosCarrito)
            {
                total += producto.PrecioUnidad;
            }

            return total;
        }
        #endregion
    }
}
