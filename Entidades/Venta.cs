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
        public Venta(List<Producto> listaProductosVenta, double precioTotal, Cliente cliente, Empleado empleado)
        {
            this.listaProductosVenta = listaProductosVenta;
            this.precioTotal = precioTotal;
            this.cliente = cliente;
            this.empleado = empleado;
            this.date = new DateTime();
        }
        #endregion

    }
}
