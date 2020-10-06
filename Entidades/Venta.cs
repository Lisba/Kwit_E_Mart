using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Venta
    {
        #region Fields
        static int idGlobal;
        int id;
        List<Producto> listaProductosVenta;
        double precioTotal;
        Cliente cliente;
        Empleado empleado;
        DateTime date;
        #endregion

        #region Properties
        public int Id
        {
            get
            {
                return id;
            }
        }

        public List<Producto> ListaProductosVenta
        {
            get
            {
                return listaProductosVenta;
            }
        }
        
        public double PrecioTotal
        {
            get
            {
                return precioTotal;
            }
        }
        
        public Cliente Cliente
        {
            get
            {
                return cliente;
            }
        }
        
        public Empleado Empleado
        {
            get 
            {
                return empleado; 
            }
        }

        public DateTime Date
        {
            get
            {
                return date;
            }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Constructor static para inicializar el id global en 1 la primera vez que se utilice la clase Venta.
        /// </summary>
        static Venta()
        {
            idGlobal = 1;
        }

        /// <summary>
        /// Instancia una venta.
        /// </summary>
        /// <param name="listaProductosVenta"></param>
        /// <param name="precioTotal"></param>
        /// <param name="cliente"></param>
        /// <param name="empleado"></param>
        public Venta(List<Producto> listaProductosVenta, double precioTotal, Cliente cliente, Empleado empleado)
        {
            id = idGlobal++;
            this.listaProductosVenta = listaProductosVenta;
            this.precioTotal = precioTotal;
            this.cliente = cliente;
            this.empleado = empleado;
            this.date = DateTime.Now;
        }
        #endregion
    }
}
