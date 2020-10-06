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
    public partial class VentasEmpleadoForm : Form
    {
        #region Fields
        List<Venta> listaVentasEmpleadoSeleccionado;
        string idDoubleClickedRow;
        static Venta ventaSeleccionada;
        #endregion

        #region Properties
        public static Venta VentaSeleccionada
        {
            get
            {
                return ventaSeleccionada;
            }
        }
        #endregion

        #region Constructors
        public VentasEmpleadoForm()
        {
            InitializeComponent();
            listaVentasEmpleadoSeleccionado = new List<Venta>();
        }
        #endregion

        #region Methods
        private void VentasEmpleadoForm_Load(object sender, EventArgs e)
        {
            CargarDataGridViewVentasEmpleado();
        }

        private void CargarDataGridViewVentasEmpleado()
        {
            this.dataGridViewVentasEmpleado.DataSource = null;
            CargarVentasDeEmpleadoSeleccionado();
            this.dataGridViewVentasEmpleado.DataSource = CargarVentasDeEmpleadoSeleccionado();
            this.dataGridViewVentasEmpleado.Columns["Cliente"].Visible = false;
            this.dataGridViewVentasEmpleado.Columns["Empleado"].Visible = false;
        }

        private List<Venta> CargarVentasDeEmpleadoSeleccionado()
        {
            return Comercio.GetListaVentasEmpleado(EmpleadosForm.EmpleadoSeleccionado);
        }

        private void dataGridViewVentasEmpleado_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            idDoubleClickedRow = ObtenerIdFilaSeleccionadaVenta(e);

            foreach (Venta venta in Comercio.ListaVentas)
            {
                if (venta.Id.ToString() == idDoubleClickedRow)
                {
                    ventaSeleccionada = venta;
                    LlamarDetallesVentaEmpleadoForm();
                    break;
                }
            }
        }

        private string ObtenerIdFilaSeleccionadaVenta(DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return "Click incorrecto";
            }
            else
            {
                return this.dataGridViewVentasEmpleado.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }

        private void LlamarDetallesVentaEmpleadoForm()
        {
            DetallesVentaEmpleadoForm detallesVentaEmpleadoForm = new DetallesVentaEmpleadoForm();
            detallesVentaEmpleadoForm.ShowDialog();
        }
        #endregion
    }
}
