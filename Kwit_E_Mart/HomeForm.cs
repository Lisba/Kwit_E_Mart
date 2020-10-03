using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        #endregion

        public HomeForm()
        {
            InitializeComponent();
            listaEmpleados = new List<Empleado>();
            listaClientes = new List<Cliente>();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void porProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void stockMenorADiezToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void agregarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            listaEmpleados = Comercio.GetListaDeEmpleados();
            listaClientes = Comercio.GetListaDeClientes();
            CargaDataGridProductos();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void agregarDatosPruebaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void CargaDataGridProductos()
        {
            cargaInicialProductos();
            this.dataGridViewProductos.DataSource = null;
            this.dataGridViewProductos.DataSource = Comercio.ListaProductos;
        }

        private void menuStripHome_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void HomeForm_MouseMove(object sender, MouseEventArgs e)
        {
            //this.lbl1.Text = string.Format("Local Coordinates X: {0} , Y: {1}", e.X, e.Y);
            //this.lbl1.Text = string.Format("Global Coordinates X: {0} , Y: {1}", Cursor.Position.X, Cursor.Position.Y);
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
        }

        private void cargaInicialProductos()
        {
            Comercio.AddNewProduct("Martillo", 2, 500.5);
            Comercio.AddNewProduct("Clavos pequeños", 200, 100.5);
            Comercio.AddNewProduct("Clavos grandes", 200, 150.0);
        }

        private void cargaInicialVentas()
        {
            //Comercio.AddnewSale(CarritoCompras.ListaProductosCarrito, CarritoCompras.GetPrecioTotal(), listaClientes[0], listaEmpleados[0]);

        }
    }
}
