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
        public StockMenosDiezForm()
        {
            InitializeComponent();
        }

        private void StockMenosDiezForm_Load(object sender, EventArgs e)
        {
            this.dataGridViewStockMenorDiez.DataSource = null;
            this.dataGridViewStockMenorDiez.DataSource = Comercio.GetListaProductosMenorDiez();
        }
    }
}
