using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Kwit_E_Mart
{
    public partial class BuscarProductoForm : Form
    {
        #region Fields
        static int id;
        #endregion

        #region Properties
        public static int Id
        {
            get
            {
                return id;
            }
        }
        #endregion

        #region Constructors
        public BuscarProductoForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Methods
        /// <summary>
        /// Al recibir el click sobre el boton adecuado llama al form adecuado segun el id recibido en el textBox previamente validado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            if (int.TryParse(this.txtBuscarProducto.Text, out id))
            {
                Producto producto = Comercio.ListaProductos.Find(item => item.Id == id);

                try
                {
                    if (producto.Id == id)
                    {
                        EditarProductoForm editarProductoForm = new EditarProductoForm();

                        if (editarProductoForm.ShowDialog() == DialogResult.OK)
                        {
                            producto.SetNombreProducto(editarProductoForm.Producto.Nombre);
                            producto.SetCantidadProducto(editarProductoForm.Producto.Cantidad);
                            producto.SetPrecioProducto(editarProductoForm.Producto.PrecioUnidad);
                            this.DialogResult = DialogResult.OK;
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("No se encontró un producto con dicho ID");
                    this.DialogResult = DialogResult.No;
                }
            }
            else
            {
                this.DialogResult = DialogResult.No;
            }
        }
        #endregion
    }
}
