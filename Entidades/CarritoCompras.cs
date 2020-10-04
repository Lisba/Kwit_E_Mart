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
        public static void AddNewItemToShopCar(Producto producto)
        {
            listaProductosCarrito.Add(producto);
        }

        public static void RemoveItemFromShopCar(Producto producto)
        {
            listaProductosCarrito.Remove(producto);
        }

        public static void RemoveAllItemsFromShopCar()
        {
            listaProductosCarrito.Clear();
        }

        public static double GetPrecioSubTotal()
        {
            double subTotal = 0;

            foreach(Producto producto in listaProductosCarrito)
            {
                subTotal += producto.PrecioUnidad;
            }

            return subTotal;
        }
        #endregion
    }
}
