using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kwit_E_Mart
{
    public partial class HomeForm : Form
    {
        #region Fields
        List<Empleado> listaEmpleados;
        List<Cliente> listaClientes;
        string idDoubleClickedRow;
        static Empleado empleadoActual;
        #endregion

        #region Properties
        public static Empleado EmpleadoActual
        {
            get
            {
                return empleadoActual;
            }
        }
        #endregion

        #region Constructor
        public HomeForm()
        {
            InitializeComponent();
            listaEmpleados = new List<Empleado>();
            listaClientes = new List<Cliente>();
        }
        #endregion

        #region Methods
        private void HomeForm_Load(object sender, EventArgs e)
        {
            listaEmpleados = Comercio.GetListaDeEmpleados();
            listaClientes = Comercio.GetListaDeClientes();
        }

        private void CargaDataGridProductos()
        {
            this.dataGridViewProductos.DataSource = null;
            this.dataGridViewProductos.DataSource = Comercio.ListaProductos;
        }

        private void HomeForm_MouseMove(object sender, MouseEventArgs e)
        {
            // Local Coordinates: e.X / e.Y.
            // Global Coordinates: Cursor.Position.X / Cursor.Position.Y.
            if (e.Y < 26)
            {
                this.menuStripHome.Visible = true;
            }
            else
            {
                this.menuStripHome.Visible = false;
            }
        }

        private void CargaInicialClientes()
        {
            Comercio.ListaPersonas.Add(new Cliente("Luis", "Garcia", 23456789, "luisgarcia10@gmail.com"));
            Comercio.ListaPersonas.Add(new Cliente("Homero", "Simpson", 23425584, "homerosimpson@hotmail.com"));
            Comercio.ListaPersonas.Add(new Cliente("Bart", "Simpson", 23425584, "homerosimpson@hotmail.com"));
        }

        private void CargaInicialProductos()
        {
            Comercio.ListaProductos.Add(new Producto("Candado", 9, 70.3));
            Comercio.ListaProductos.Add(new Producto("Martillo", 20, 500.50));
            Comercio.ListaProductos.Add(new Producto("Clavos peq", 300, 30.50));
            Comercio.ListaProductos.Add(new Producto("Clavos grand", 200, 50.20));
            Comercio.ListaProductos.Add(new Producto("Taladro", 30, 1000.80));
            Comercio.ListaProductos.Add(new Producto("Destorn. Estría", 70, 200.10));
            Comercio.ListaProductos.Add(new Producto("Destorn. Plano", 70, 200.10));
            Comercio.ListaProductos.Add(new Producto("Llave inglesa 3/4", 100, 150.00));
        }

        private void cargaInicialVentas()
        {
            //Comercio.AddnewSale(CarritoCompras.ListaProductosCarrito, CarritoCompras.GetPrecioTotal(), listaClientes[0], listaEmpleados[0]);
        }

        private void HomeForm_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dataGridViewProductos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            idDoubleClickedRow = ObtenerIdFilaSeleccionadaProductos(e);
            CargarProductoACarritoCompras(1);
        }

        private void CargarProductoACarritoCompras(int cantidadDeseada)
        {
            foreach (Producto producto in Comercio.ListaProductos)
            {
                if (producto.Id.ToString() == idDoubleClickedRow)
                {
                    if (Validaciones.StockDisponibleDeProducto(producto, cantidadDeseada))
                    {
                        for (int i = 0; i < cantidadDeseada; i++)
                        {
                            CarritoCompras.ListaProductosCarrito.Add(producto);
                        }

                        CargarDataGridViewCarritoCompras();
                    }
                    else
                    {
                        MessageBox.Show("Stock insuficiente!", "Insuficiente");
                    }
                    break;
                }
            }
        }

        private void CargarDataGridViewCarritoCompras()
        {
            this.dataGridViewCarrito.DataSource = null;
            this.dataGridViewCarrito.DataSource = CarritoCompras.ListaProductosCarrito;
            this.dataGridViewCarrito.Columns["Id"].Visible = false;
            this.dataGridViewCarrito.Columns["Cantidad"].Visible = false;
            this.lblSubTotalCifraHome.Text = CarritoCompras.GetPrecioSubTotal().ToString();
        }

        private void dataGridViewProductos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            idDoubleClickedRow = ObtenerIdFilaSeleccionadaProductos(e);
        }

        private void btbAgregarAlCarro_Click(object sender, EventArgs e)
        {
            int cantidadDeseada = Validaciones.ValidarInt(txtCantidadHome.Text);

            if(cantidadDeseada > 0)
            {
                CargarProductoACarritoCompras(cantidadDeseada);
            }
            else
            {
                MessageBox.Show("Ingrese un número válido!", "¡Valor Inválido!");
            }

        }

        private void btnResetCar_Click(object sender, EventArgs e)
        {
            if(CarritoCompras.ListaProductosCarrito.Count > 0)
            {
                CarritoCompras.RemoveAllItemsFromShopCar();
                CargarDataGridViewCarritoCompras();
            }
        }

        private void dataGridViewCarrito_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            idDoubleClickedRow = ObtenerIdFilaSeleccionadaCarrito(e);

            foreach (Producto producto in Comercio.ListaProductos)
            {
                if (producto.Id.ToString() == idDoubleClickedRow)
                {
                    CarritoCompras.RemoveItemFromShopCar(producto);
                    CargarDataGridViewCarritoCompras();
                    break;
                }
            }
        }

        private string ObtenerIdFilaSeleccionadaProductos(DataGridViewCellMouseEventArgs e)
        {
            if(e.RowIndex == -1)
            {
                return "Click incorrecto";
            }
            else
            {
                return this.dataGridViewProductos.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }

        private string ObtenerIdFilaSeleccionadaCarrito(DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return "Click incorrecto";
            }
            else
            {
                return this.dataGridViewCarrito.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }

        private void agregarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaProductoForm altaProductoForm = new AltaProductoForm();
            if(altaProductoForm.ShowDialog() == DialogResult.OK)
            {
                Comercio.ListaProductos.Add(altaProductoForm.Producto);
                CargaDataGridProductos();
            }
            else
            {
                MessageBox.Show("Ocurrio un error durante la carga de datos!");
            }
        }

        private void agregarDatosPruebaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Comercio.ListaProductos.Count == 0 && Comercio.ListaPersonas.Count == 2)
            {
                CargaInicialClientes();
                CargaInicialProductos();
                CargaDataGridProductos();
            }
        }

        private void modificarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarProductoForm buscarProductoForm = new BuscarProductoForm();
            if (buscarProductoForm.ShowDialog() == DialogResult.OK)
            {
                CargaDataGridProductos();
                MessageBox.Show("Modificacion de datos exitosa!");
            }
            else
            {
                MessageBox.Show("Ocurrio un error durante la modificación de datos!");
            }
        }

        private void stockMenorADiezToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockMenosDiezForm stockMenosDiezForm = new StockMenosDiezForm();
            stockMenosDiezForm.ShowDialog();
        }

        private void btnComprarHome_Click(object sender, EventArgs e)
        {
            if(CarritoCompras.ListaProductosCarrito.Count > 0)
            {
                if (Validaciones.StockDisponibleParaComprar())
                {
                    SeleccionarClienteForm seleccionarClienteForm = new SeleccionarClienteForm();

                    if(seleccionarClienteForm.ShowDialog() == DialogResult.OK)
                    {
                        CarritoCompras.RemoveAllItemsFromShopCar();
                        CargarDataGridViewCarritoCompras();
                        CargaDataGridProductos();
                        RepodrucirSonidoDeCompra();
                        MessageBox.Show("Gracias!! Vuelva Prontosss");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo concretar la compra!");
                    }
                }
                else
                {
                    MessageBox.Show("Tu carrito está meando afuera del perol!");
                }
            }
            else
            {
                MessageBox.Show("Tu carrito esta vacío!");
            }
        }

        private void RepodrucirSonidoDeCompra()
        {
            try
            {
                SoundPlayer sellSound = new SoundPlayer(GetSongPath());
                sellSound.Play();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private string GetSongPath()
        {
            return System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "rockGuitar.wav");
        }

        public void SetEmpleadoSesionActual(Empleado empleado)
        {
            empleadoActual = empleado;
        }
        #endregion
    }
}
