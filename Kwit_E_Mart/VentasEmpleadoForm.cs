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
        }
        #endregion

        #region Methods
        /// <summary>
        /// Carga el dataGridViewVentasEmpleado llamando al metodo adecuado al cargar el formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VentasEmpleadoForm_Load(object sender, EventArgs e)
        {
            CargarDataGridViewVentasEmpleado();
        }

        /// <summary>
        /// Carga el dataGridViewVentasEmpleado con datos y oculta las filas Cliente y Empleado.
        /// </summary>
        private void CargarDataGridViewVentasEmpleado()
        {
            this.dataGridViewVentasEmpleado.DataSource = null;
            CargarVentasDeEmpleadoSeleccionado();
            this.dataGridViewVentasEmpleado.DataSource = CargarVentasDeEmpleadoSeleccionado();
            this.dataGridViewVentasEmpleado.Columns["Cliente"].Visible = false;
            this.dataGridViewVentasEmpleado.Columns["Empleado"].Visible = false;
        }

        /// <summary>
        /// Retorna la lista de ventas del empleado seleccionado.
        /// </summary>
        /// <returns>La lista de ventas del empleado seleccionado.</returns>
        private List<Venta> CargarVentasDeEmpleadoSeleccionado()
        {
            return Comercio.GetListaVentasEmpleado(EmpleadosForm.EmpleadoSeleccionado);
        }

        /// <summary>
        /// Carga en la propiedad ventaSeleccionada la venta del empleado a la cual se hizo doble click en el DataGridView y llama al formulario correspondiente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Obtiene el id de la fila seleccionada y valida que no sea la fila head.
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Llama al formulario detallesVentaEmpleadoForm.
        /// </summary>
        private void LlamarDetallesVentaEmpleadoForm()
        {
            DetallesVentaEmpleadoForm detallesVentaEmpleadoForm = new DetallesVentaEmpleadoForm();
            detallesVentaEmpleadoForm.ShowDialog();
        }
        #endregion
    }
}
