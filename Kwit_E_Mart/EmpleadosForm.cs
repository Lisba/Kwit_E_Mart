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
        private void EmpleadosForm_Load(object sender, EventArgs e)
        {
            CargardataGridViewEmpleados();
        }

        private void CargardataGridViewEmpleados()
        {
            this.dataGridViewEmpleados.DataSource = null;
            this.dataGridViewEmpleados.DataSource = Comercio.GetListaDeEmpleados();
            this.dataGridViewEmpleados.Columns["Contrasenia"].Visible = false;
            this.dataGridViewEmpleados.Columns[0].HeaderText = "Id";
        }
        #endregion

        private void dataGridViewEmpleados_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            idDoubleClickedRow = ObtenerIdFilaSeleccionadaEmpleados(e);
            CargarEmpleadoSeleccionado();
            LlamarFormVentasPorEmpleado();
        }

        private void LlamarFormVentasPorEmpleado()
        {
            VentasEmpleadoForm ventasEmpleadoForm = new VentasEmpleadoForm();
            ventasEmpleadoForm.ShowDialog();
        }

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
    }
}
