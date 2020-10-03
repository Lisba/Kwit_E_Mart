﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Comercio
    {
        #region Fields
        static List<Producto> listaProductos;
        static List<Venta> listaVentas;
        static List<Persona> listaPersonas;
        #endregion

        #region Properties
        public static List<Producto> ListaProductos
        {
            get
            {
                return listaProductos;
            }
        }

        public static List<Venta> ListaVentas
        {
            get
            {
                return listaVentas;
            }
        }

        public static List<Persona> ListaPersonas
        {
            get
            {
                return listaPersonas;
            }
        }
        #endregion

        #region Constructor
        static Comercio()
        {
            listaProductos = new List<Producto>();
            listaVentas = new List<Venta>();
            listaPersonas = new List<Persona>();
        }
        #endregion

        #region Methods
        static public List<Empleado> GetListaDeEmpleados()
        {
            List<Empleado> listaEmpleados = new List<Empleado>();
            
            foreach (Persona auxPersona in listaPersonas)
            {
                if(auxPersona is Empleado)
                {
                    listaEmpleados.Add((Empleado)auxPersona);
                }
            }

            return listaEmpleados;
        }

        static public List<Cliente> GetListaDeClientes()
        {
            List<Cliente> listaClientes = new List<Cliente>();

            foreach (Persona auxPersona in listaPersonas)
            {
                if (auxPersona is Cliente)
                {
                    listaClientes.Add((Cliente)auxPersona);
                }
            }

            return listaClientes;
        }

        static public List<Venta> GetListaVentasEmpleado(Empleado empleado)
        {
            List<Venta> listaVentasEmpleado = new List<Venta>();

            foreach(Venta auxVenta in listaVentas)
            {
                if(auxVenta.Empleado == empleado)
                {
                    listaVentasEmpleado.Add(auxVenta);
                }
            }

            return listaVentasEmpleado;
        }

        static public List<Producto> GetListaProductosMenorDiez()
        {
            List<Producto> listaProductosMenorDiez = new List<Producto>();

            foreach(Producto auxProducto in listaProductos)
            {
                if(auxProducto.Cantidad < 10)
                {
                    listaProductosMenorDiez.Add(auxProducto);
                }
            }

            return listaProductosMenorDiez;
        }

        static public void AddNewProduct(string nombre, int cantidad, double precioUnidad)
        {
            listaProductos.Add(new Producto(nombre, cantidad, precioUnidad));
        }

        static public void AddNewEmployee(string nombre, string apellido, int dni, ECargos cargo, string user, string constrasenia)
        {
            listaPersonas.Add(new Empleado(nombre, apellido, dni, cargo, user, constrasenia));
        }

        static public void AddNewClient(string nombre, string apellido, int dni, string email)
        {
            listaPersonas.Add(new Cliente(nombre, apellido, dni, email));
        }

        static public void AddnewSale(List<Producto> listaProductos, double precioTotal, Cliente cliente, Empleado empleado)
        {
            listaVentas.Add(new Venta(listaProductos, precioTotal, cliente, empleado));
        }
        #endregion
    }
}
