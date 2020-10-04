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
    public partial class StockMenosDiezForm : Form
    {

        #region Fields
        List<Producto> ListaProductosMenorDiezUnidades;
        #endregion

        public StockMenosDiezForm()
        {
            InitializeComponent();
            ListaProductosMenorDiezUnidades = new List<Producto>();
        }

        private void StockMenosDiezForm_Load(object sender, EventArgs e)
        {
            foreach(Producto producto in Comercio.ListaProductos)
            {
                if(producto.Cantidad < 10)
                {
                    ListaProductosMenorDiezUnidades.Add(producto);
                }
            }

            this.dataGridViewStockMenorDiez.DataSource = null;
            this.dataGridViewStockMenorDiez.DataSource = ListaProductosMenorDiezUnidades;
        }
    }
}
