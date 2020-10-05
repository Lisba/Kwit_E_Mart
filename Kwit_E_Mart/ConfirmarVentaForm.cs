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
    public partial class ConfirmarVentaForm : Form
    {
        #region Fields
        double precioTotalAPagar;
        List<Producto> listaProductosComprados;
        #endregion

        #region Constructor
        public ConfirmarVentaForm()
        {
            InitializeComponent();
            listaProductosComprados = new List<Producto>();
        }
        #endregion

        #region Methods
        private void ConfirmarVentaForm_Load(object sender, EventArgs e)
        {
            CargardataGridViewConfirmarCompra();
            precioTotalAPagar = CarritoCompras.GetPrecioTotalAPagar(CarritoCompras.GetPrecioSubTotal(), SeleccionarClienteForm.ClienteSeleccionado);

            this.lblDescuentoConfirmacion.Text = CarritoCompras.GetDescuento(CarritoCompras.GetPrecioSubTotal(), SeleccionarClienteForm.ClienteSeleccionado).ToString();
            this.lblPrecioTotalConfirmacion.Text = precioTotalAPagar.ToString();
            this.lblClienteConfirmacion.Text = SeleccionarClienteForm.ClienteSeleccionado.SayNameLastname(HomeForm.EmpleadoActual.Nombre, HomeForm.EmpleadoActual.Apellido);
            this.lblEmpleadoConfirmacion.Text = HomeForm.EmpleadoActual.SayNameLastname(SeleccionarClienteForm.ClienteSeleccionado.Nombre, SeleccionarClienteForm.ClienteSeleccionado.Apellido);
        }

        private void CargardataGridViewConfirmarCompra()
        {
            this.dataGridViewConfirmarCompra.DataSource = null;
            this.dataGridViewConfirmarCompra.DataSource = CarritoCompras.ListaProductosCarrito;
            this.dataGridViewConfirmarCompra.Columns["Id"].Visible = false;
            this.dataGridViewConfirmarCompra.Columns["Cantidad"].Visible = false;
        }

        private void btnConfirmarCompra_Click(object sender, EventArgs e)
        {
            CapturarListaProductosComprados();
            Comercio.ListaVentas.Add(new Venta(listaProductosComprados, precioTotalAPagar, SeleccionarClienteForm.ClienteSeleccionado, HomeForm.EmpleadoActual));
            Producto.RestarStockAProducto();
            this.DialogResult = DialogResult.OK;
        }

        private void CapturarListaProductosComprados()
        {
            foreach (Producto producto in CarritoCompras.ListaProductosCarrito)
            {
                listaProductosComprados.Add(producto);
            }
        }
        #endregion
    }
}
