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
    public partial class EmpleadosForm : Form
    {
        #region Fields
        static Empleado empleadoSeleccionado;
        string idDoubleClickedRow;
        #endregion

        #region Properties
        public static Empleado EmpleadoSeleccionado
        {
            get
            {
                return empleadoSeleccionado;
            }
        }
        #endregion

        #region Constructors
        public EmpleadosForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Methods
        /// <summary>
        /// Llama al metodo correspondiente para cargar el dataGridViewEmpleados con datos al cargar el formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EmpleadosForm_Load(object sender, EventArgs e)
        {
            CargardataGridViewEmpleados();
        }

        /// <summary>
        /// Carga datos al dataGridViewEmpleados ocultando las filas id y contraseña.
        /// </summary>
        private void CargardataGridViewEmpleados()
        {
            this.dataGridViewEmpleados.DataSource = null;
            this.dataGridViewEmpleados.DataSource = Comercio.GetListaDeEmpleados();
            this.dataGridViewEmpleados.Columns["Contrasenia"].Visible = false;
            this.dataGridViewEmpleados.Columns[0].HeaderText = "Id";
        }

        /// <summary>
        /// Obtiene la fila seleccionada al hacer doble click sobre ella y llama a los metodos correspondientes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewEmpleados_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            idDoubleClickedRow = ObtenerIdFilaSeleccionadaEmpleados(e);
            CargarEmpleadoSeleccionado();
            LlamarFormVentasPorEmpleado();
        }

        /// <summary>
        /// Llama al formulario de ventas del empleado seleccionado en el dataGridViewEmpleados.
        /// </summary>
        private void LlamarFormVentasPorEmpleado()
        {
            VentasEmpleadoForm ventasEmpleadoForm = new VentasEmpleadoForm();
            ventasEmpleadoForm.ShowDialog();
        }

        /// <summary>
        /// Carga en la propiedad empleadoSeleccionado el empleado al cual se le hizo doble click en el dataGridViewEmpleados.
        /// </summary>
        private void CargarEmpleadoSeleccionado()
        {
            foreach (Empleado empleado in Comercio.GetListaDeEmpleados())
            {
                if (empleado.IdPropio.ToString() == idDoubleClickedRow)
                {
                    empleadoSeleccionado = empleado;
                }
            }
        }

        /// <summary>
        /// Obtiene el id de la fila seleccionada y valida que no se haga click en la fila head del dataGridViewEmpleados.
        /// </summary>
        /// <param name="e"></param>
        /// <returns>Retorna el id como string de la fila a la cual se le hizo doble click en el dataGridViewEmpleados.</returns>
        private string ObtenerIdFilaSeleccionadaEmpleados(DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return "Click incorrecto";
            }
            else
            {
                return this.dataGridViewEmpleados.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }
        #endregion
    }
}
