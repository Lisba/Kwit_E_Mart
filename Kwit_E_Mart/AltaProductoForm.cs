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
    public partial class AltaProductoForm : Form
    {
        #region Fields
        Producto producto;
        #endregion

        #region Fields
        public Producto Producto
        {
            get 
            {
                return producto; 
            }
        }
        #endregion

        public AltaProductoForm()
        {
            InitializeComponent();
        }

        private void btnAltaProducto_Click(object sender, EventArgs e)
        {   
            if (Validaciones.ValidarString(txtNombreProducto.Text) && Validaciones.ValidarInt(txtCantidadProducto.Text) != -1 && Validaciones.ValidarDouble(txtPrecioUnidadProducto.Text) != -1)
            {
                producto = new Producto(txtNombreProducto.Text, Validaciones.ValidarInt(txtCantidadProducto.Text), Validaciones.ValidarDouble(txtPrecioUnidadProducto.Text));
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.No;
            }
        }
    }
}
