using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
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
        #endregion

        public HomeForm()
        {
            InitializeComponent();
            listaEmpleados = new List<Empleado>();
            listaClientes = new List<Cliente>();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            listaEmpleados = Comercio.GetListaDeEmpleados();
            listaClientes = Comercio.GetListaDeClientes();
            //ConfiguracionDataGridView(this.dataGridViewProductos);
            //ConfiguracionDataGridView(this.dataGridViewCarrito);
            this.dataGridViewProductos.DataSource = null;
            this.dataGridViewCarrito.DataSource = null;
            CargaDataGridProductos();
        }

        private void CargaDataGridProductos()
        {
            cargaInicialProductos();
            this.dataGridViewProductos.DataSource = Comercio.ListaProductos;
        }

        private void ConfiguracionDataGridView(DataGridView dataGridView)
        {
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

        private void cargaInicialClientes()
        {
            Comercio.AddNewClient("Luis", "Garcia", 23456789, "luisgarcia10@gmail.com");
            Comercio.AddNewClient("Homero", "Simpson", 23425584, "homerosimpson@hotmail.com");
            Comercio.AddNewClient("Bart", "Simpson", 23425584, "homerosimpson@hotmail.com");
        }

        private void cargaInicialProductos()
        {
            Comercio.AddNewProduct("Martillo", 20, 500.50);
            Comercio.AddNewProduct("Clavos pequeños", 300, 30.50);
            Comercio.AddNewProduct("Clavos grandes", 200, 50.20);
            Comercio.AddNewProduct("Taladro", 30, 1000.80);
            Comercio.AddNewProduct("Destornillador Estría", 70, 200.10);
            Comercio.AddNewProduct("Destornillador Plano", 70, 200.10);
            Comercio.AddNewProduct("Llave inglesa 3/4", 100, 150.00);
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
            CargarProductoACarritoCompras();
        }

        private void CargarProductoACarritoCompras()
        {
            foreach (Producto producto in Comercio.ListaProductos)
            {
                if(producto.Id.ToString() == idDoubleClickedRow)
                {
                    CarritoCompras.AddNewItemToShopCar(producto);
                    CargarDataGridViewCarritoCompras();
                    break;
                }
            }
        }

        private void CargarDataGridViewCarritoCompras()
        {
            this.dataGridViewCarrito.DataSource = null;
            this.dataGridViewCarrito.DataSource = CarritoCompras.ListaProductosCarrito;
            this.lblSubTotalCifraHome.Text = CarritoCompras.GetPrecioSubTotal().ToString();
        }

        private void dataGridViewProductos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            idDoubleClickedRow = ObtenerIdFilaSeleccionadaProductos(e);
        }

        private void btbAgregarAlCarro_Click(object sender, EventArgs e)
        {
            foreach (Producto producto in Comercio.ListaProductos)
            {
                if (producto.Id.ToString() == idDoubleClickedRow)
                {
                    for(int i=0; i < int.Parse(txtCantidadHome.Text); i++)
                    {
                        CarritoCompras.AddNewItemToShopCar(producto);
                    }

                    CargarDataGridViewCarritoCompras();
                    break;
                }
            }
        }

        private void btnResetCar_Click(object sender, EventArgs e)
        {
            if(CarritoCompras.ListaProductosCarrito.Count > 0)
            {
                CarritoCompras.RemoveAllItemsFromShopCar();
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
            return this.dataGridViewProductos.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private string ObtenerIdFilaSeleccionadaCarrito(DataGridViewCellMouseEventArgs e)
        {
            //return this.dataGridViewCarrito.CurrentRow.Cells[0].Value.ToString(); Another way using CurrentRow property.
            return this.dataGridViewCarrito.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void agregarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaProductoForm altaProductoForm = new AltaProductoForm();
            altaProductoForm.ShowDialog();
        }
    }
}
