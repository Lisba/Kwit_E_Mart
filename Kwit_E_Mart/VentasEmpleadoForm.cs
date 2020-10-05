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
            this.dataGridViewVentasEmpleado.DataSource = listaVentasEmpleadoSeleccionado;
            this.dataGridViewVentasEmpleado.Columns["Cliente"].Visible = false;
            this.dataGridViewVentasEmpleado.Columns["Empleado"].Visible = false;
        }

        private void CargarVentasDeEmpleadoSeleccionado()
        {
            foreach (Venta venta in Comercio.ListaVentas)
            {
                if(venta.Empleado.IdPropio == EmpleadosForm.EmpleadoSeleccionado.IdPropio)
                {
                    listaVentasEmpleadoSeleccionado.Add(venta);
                }
            }
        }
        #endregion
    }
}
