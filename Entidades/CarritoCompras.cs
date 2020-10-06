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

        public static double GetPrecioSubTotal(List<Producto> listaProductosCarrito)
        {
            double subTotal = 0;

            foreach (Producto producto in listaProductosCarrito)
            {
                subTotal += producto.PrecioUnidad;
            }

            return subTotal;
        }

        public static double GetDescuento(double subTotal, Cliente cliente)
        {
            double returnValue = 0;

            if (Validaciones.ValidarClienteSimpson(cliente))
            {
                returnValue = subTotal / 100 * 13;
            }

            return returnValue;
        }

        public static double GetPrecioTotalAPagar(double subTotal, Cliente cliente)
        {
            subTotal -= GetDescuento(subTotal, cliente);
            return subTotal;
        }
        #endregion
    }
}
