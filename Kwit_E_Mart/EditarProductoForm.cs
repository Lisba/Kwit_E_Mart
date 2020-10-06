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

        #region Properties
        public Producto Producto
        {
            get
            {
                return producto;
            }
        }
        #endregion

        #region Constructors
        public EditarProductoForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Methods
        /// <summary>
        /// Genera una instancia de producto previamente validando los datos de los textBox al recibir click sobre el boton adecuado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Carga los TextBox con la informacion actual del producto a editar para se usados como referencia.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditarProductoForm_Load(object sender, EventArgs e)
        {
            producto = BuscarProductoAEditar();
            txtEditarNombreProducto.Text = producto.Nombre;
            txtEditarCantidadProducto.Text = producto.Cantidad.ToString();
            txtEditarPrecioProducto.Text = producto.PrecioUnidad.ToString();
        }

        /// <summary>
        /// Busca el producto a editar para usar su informacion actual como referencia.
        /// </summary>
        /// <returns>El producto a editar.</returns>
        public Producto BuscarProductoAEditar()
        {
            Producto producto = Comercio.ListaProductos.Find(item => item.Id == BuscarProductoForm.Id);
            return producto;
        }
        #endregion
    }
}
