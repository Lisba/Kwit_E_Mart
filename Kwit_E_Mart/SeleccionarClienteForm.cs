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
    public partial class SeleccionarClienteForm : Form
    {
        #region Fields
        List<Cliente> listaDecliente;
        string idClientDoubleClicked;
        static Cliente clienteSeleccionado;
        #endregion

        #region Properties
        public List<Cliente> ListaDecliente
        {
            get
            {
                return listaDecliente;
            }
        }

        public static Cliente ClienteSeleccionado
        {
            get
            {
                return clienteSeleccionado;
            }
        }
        #endregion

        #region Constructors
        public SeleccionarClienteForm()
        {
            InitializeComponent();
            listaDecliente = new List<Cliente>();
        }
        #endregion

        #region Methods
        /// <summary>
        /// Carga los datos al dataGridViewClientes llamando al metodo correspondiente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SeleccionarClienteForm_Load(object sender, EventArgs e)
        {
            CargarDataGridViewClientes();
        }

        /// <summary>
        /// Carga los datos al dataGridViewClientes.
        /// </summary>
        private void CargarDataGridViewClientes()
        {
            this.dataGridViewClientes.DataSource = null;
            this.dataGridViewClientes.DataSource = Comercio.GetListaDeClientes();
        }

        /// <summary>
        /// Carga a la propiedad clienteSeleccionado al cliente seleccionado con soble click en el dataGridView y llama al formulario de confirmacion de venta.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewClientes_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            idClientDoubleClicked = ObtenerIdClienteSeleccionado(e);

            foreach (Cliente cliente in Comercio.GetListaDeClientes())
            {
                if (cliente.IdPropio.ToString() == idClientDoubleClicked)
                {
                    clienteSeleccionado = cliente;
                    LlamarFormularioDeConfirmacion();
                    break;
                }
            }
        }

        /// <summary>
        /// Retorna el valor id de la fila seleccionada y valida que no sea la fila head del DataGridView.
        /// </summary>
        /// <param name="e"></param>
        /// <returns>El valor id de la fila seleccionada en formato string.</returns>
        private string ObtenerIdClienteSeleccionado(DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return "Click incorrecto";
            }
            else
            {
                return this.dataGridViewClientes.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }

        /// <summary>
        /// Llama al formulario de confirmacion de venta.
        /// </summary>
        private void LlamarFormularioDeConfirmacion()
        {
            ConfirmarVentaForm confirmarVentaform = new ConfirmarVentaForm();
            if(confirmarVentaform.ShowDialog() == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.No;
            }
        }

        /// <summary>
        /// Llama al formulario de Alta Cliente al recibir click sobre el boton correspondiente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            AltaClienteForm altaClienteForm = new AltaClienteForm();
            if (altaClienteForm.ShowDialog() == DialogResult.OK)
            {
                Comercio.ListaPersonas.Add(altaClienteForm.Cliente);
                CargarDataGridViewClientes();
            }
            else
            {
                MessageBox.Show("No se pudo agregar al nuevo cliente!");
            }
        }
        #endregion
    }
}
