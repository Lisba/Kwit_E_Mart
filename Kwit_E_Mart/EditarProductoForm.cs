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
    public partial class EditarProductoForm : Form
    {
        #region Fields
        Producto producto;
        #endregion

        public Producto Producto
        {
            get
            {
                return producto;
            }
        }

        public EditarProductoForm()
        {
            InitializeComponent();
        }

        private void btnEditarProducto_Click(object sender, EventArgs e)
        {
            if (Validaciones.ValidarString(txtEditarNombreProducto.Text) && Validaciones.ValidarInt(txtEditarCantidadProducto.Text) != -1 && Validaciones.ValidarDouble(txtEditarPrecioProducto.Text) != -1)
            {
                producto = new Producto(txtEditarNombreProducto.Text, Validaciones.ValidarInt(txtEditarCantidadProducto.Text), Validaciones.ValidarDouble(txtEditarPrecioProducto.Text));
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.No;
            }
        }

        private void EditarProductoForm_Load(object sender, EventArgs e)
        {
            Producto producto = Comercio.ListaProductos.Find(item => item.Id == BuscarProductoForm.Id);

            txtEditarNombreProducto.Text = producto.Nombre;
            txtEditarCantidadProducto.Text = producto.Cantidad.ToString();
            txtEditarPrecioProducto.Text = producto.PrecioUnidad.ToString();
        }
    }
}
