using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kwit_E_Mart
{
    public partial class HomeForm : Form
    {
        #region Fields
        string idDoubleClickedRow;
        static Empleado empleadoActual;
        #endregion

        #region Properties
        public static Empleado EmpleadoActual
        {
            get
            {
                return empleadoActual;
            }
        }
        #endregion

        #region Constructor
        public HomeForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Methods
        /// <summary>
        /// Carga el DataGridView de productos (Setea null para refrescar).
        /// </summary>
        private void CargaDataGridProductos()
        {
            this.dataGridViewProductos.DataSource = null;
            this.dataGridViewProductos.DataSource = Comercio.ListaProductos;
        }

        /// <summary>
        /// Detecta la posicion del mouse y hace visible o invisible el menu superior.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HomeForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Y < 26)
            {
                this.menuStripHome.Visible = true;
            }
            else
            {
                this.menuStripHome.Visible = false;
            }
        }

        /// <summary>
        /// Carga 4 clientes para test.
        /// </summary>
        private void CargaInicialClientes()
        {
            Comercio.ListaPersonas.Add(new Cliente("Luis", "Moreira", 23456789, "luisgarcia10@gmail.com"));
            Comercio.ListaPersonas.Add(new Cliente("Homero", "Simpson", 23425584, "homerosimpson@hotmail.com"));
            Comercio.ListaPersonas.Add(new Cliente("Bart", "Simpson", 23425584, "homerosimpson@hotmail.com"));
            Comercio.ListaPersonas.Add(new Cliente("Javier", "Barroso", 93423484));
            Comercio.ListaPersonas.Add(new Cliente("Keimarly", "Cisnero", 82523484, "keimarly1210@gmail.com"));
            Comercio.ListaPersonas.Add(new Cliente("Ketty", "Leon", 78423484));
        }

        /// <summary>
        /// Carga 20 productos al comercio.
        /// </summary>
        private void CargaInicialProductos()
        {
            Comercio.ListaProductos.Add(new Producto("Candado", 9, 70.3));
            Comercio.ListaProductos.Add(new Producto("Martillo", 20, 500.50));
            Comercio.ListaProductos.Add(new Producto("Clavo P.", 300, 30.50));
            Comercio.ListaProductos.Add(new Producto("Clavo G.", 200, 50.20));
            Comercio.ListaProductos.Add(new Producto("Taladro", 30, 1000.80));
            Comercio.ListaProductos.Add(new Producto("Destorn. Estría", 70, 200.10));
            Comercio.ListaProductos.Add(new Producto("Destorn. Plano", 70, 200.10));
            Comercio.ListaProductos.Add(new Producto("Llave Ing. 3/4", 100, 150.00));
            Comercio.ListaProductos.Add(new Producto("Llave Ing. 2/4", 230, 150.00));
            Comercio.ListaProductos.Add(new Producto("Llave Ing. 1/4", 160, 150.00));
            Comercio.ListaProductos.Add(new Producto("Manguera Roja", 267, 50.10));
            Comercio.ListaProductos.Add(new Producto("Manguera Verde", 256, 50.10));
            Comercio.ListaProductos.Add(new Producto("Manguera Azul", 205, 50.10));
            Comercio.ListaProductos.Add(new Producto("Manguera P.", 703, 50.10));
            Comercio.ListaProductos.Add(new Producto("Manguera M.", 202, 50.10));
            Comercio.ListaProductos.Add(new Producto("Manguera G.", 151, 80.20));
            Comercio.ListaProductos.Add(new Producto("Llave Cruz", 6, 500.00));
            Comercio.ListaProductos.Add(new Producto("Llave Fra. 1/4", 300, 150.00));
            Comercio.ListaProductos.Add(new Producto("Llave Fra. 2/4", 100, 150.00));
            Comercio.ListaProductos.Add(new Producto("Llave Fra. 3/4", 400, 150.00));
            Comercio.ListaProductos.Add(new Producto("Llave Fra. 4/4", 5, 150.00));
            Comercio.ListaProductos.Add(new Producto("Llave Ing. 4/4", 200, 150.00));
            Comercio.ListaProductos.Add(new Producto("Tornillo G.", 400, 40.00));
            Comercio.ListaProductos.Add(new Producto("Tornillo M.", 550, 30.00));
            Comercio.ListaProductos.Add(new Producto("Tornillo P.", 520, 20.00));
            Comercio.ListaProductos.Add(new Producto("Tornillo Estria", 210, 50.00));
            Comercio.ListaProductos.Add(new Producto("Tornillo Plano", 280, 50.00));
            Comercio.ListaProductos.Add(new Producto("Tornillo Estrella", 9, 40.00));
            Comercio.ListaProductos.Add(new Producto("Juego de tornillos", 80, 1100.00));
            Comercio.ListaProductos.Add(new Producto("Juego de Destorn.", 5, 1500.00));
        }

        /// <summary>
        /// Carga compras al comercio automaticamente llamando al metodo correspondiente.
        /// </summary>
        private void cargaInicialVentas()
        {
            List<Producto> listaDeProductos = new List<Producto>();

            LoopCargarVentasAutomaticamente(8, 0, 1, listaDeProductos);
            LoopCargarVentasAutomaticamente(12, 5, 0, listaDeProductos);
            LoopCargarVentasAutomaticamente(8, 4, 1, listaDeProductos);
            LoopCargarVentasAutomaticamente(12, 3, 0, listaDeProductos);
            LoopCargarVentasAutomaticamente(8, 5, 1, listaDeProductos);
            LoopCargarVentasAutomaticamente(8, 4, 0, listaDeProductos);
        }

        /// <summary>
        /// Instancia ventas con los valores recibidos por parametro.
        /// </summary>
        /// <param name="cliente"></param>
        /// <param name="empleado"></param>
        /// <param name="listaDeProductos"></param>
        private void LoopCargarVentasAutomaticamente(int cantidadDeVentas, int cliente, int empleado, List<Producto> listaDeProductos)
        {
            for (int i = 1; i < cantidadDeVentas; i++)
            {
                listaDeProductos = CargarListaDeProductos(i);
                Comercio.ListaVentas.Add(new Venta(listaDeProductos, Math.Round(CarritoCompras.GetPrecioSubTotal(listaDeProductos), 2), Comercio.GetListaDeClientes()[cliente], Comercio.GetListaDeEmpleados()[empleado]));
            }
        }

        /// <summary>
        /// Carga listas de productos para la carga de 50 ventas.
        /// </summary>
        /// <param name="cantidadDeProductos"></param>
        /// <returns></returns>
        private List<Producto> CargarListaDeProductos(int cantidadDeProductos)
        {
            List<Producto> listaDeProductos = new List<Producto>();

            if(cantidadDeProductos < 30)
            {
                for(int i=0; i < cantidadDeProductos; i++)
                {
                    listaDeProductos.Add(Comercio.ListaProductos[i]);
                }
            }
            else
            {
                MessageBox.Show("Operación no permitida!", "Operacion bloqueada");
            }

            return listaDeProductos;
        }

        /// <summary>
        /// Cierra toda la app al cerrar el formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HomeForm_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Obtiene la fila seleccionada al hacer doble click y llama al metodo para cargar dicho producto al carrito de compras.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewProductos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            idDoubleClickedRow = ObtenerIdFilaSeleccionadaProductos(e);
            CargarProductoACarritoCompras(1);
        }

        /// <summary>
        /// Carga el producto al carrito de compras segun la cantidad deseada.
        /// </summary>
        /// <param name="cantidadDeseada"></param>
        private void CargarProductoACarritoCompras(int cantidadDeseada)
        {
            foreach (Producto producto in Comercio.ListaProductos)
            {
                if (producto.Id.ToString() == idDoubleClickedRow)
                {
                    if (Validaciones.StockDisponibleDeProducto(producto, cantidadDeseada))
                    {
                        for (int i = 0; i < cantidadDeseada; i++)
                        {
                            CarritoCompras.ListaProductosCarrito.Add(producto);
                        }

                        CargarDataGridViewCarritoCompras();
                    }
                    else
                    {
                        MessageBox.Show("Stock insuficiente!", "Insuficiente");
                    }
                    break;
                }
            }
        }

        /// <summary>
        /// Carga datos al DataGridView del carrito de compras y configura las columnas a mostrar (Setea null para refrescar).
        /// </summary>
        private void CargarDataGridViewCarritoCompras()
        {
            this.dataGridViewCarrito.DataSource = null;
            this.dataGridViewCarrito.DataSource = CarritoCompras.ListaProductosCarrito;
            this.dataGridViewCarrito.Columns["Id"].Visible = false;
            this.dataGridViewCarrito.Columns["Cantidad"].Visible = false;
            this.lblSubTotalCifraHome.Text = Math.Round(CarritoCompras.GetPrecioSubTotal(), 2).ToString();
        }

        /// <summary>
        /// Obtiene la fila selecciona al hacer solo un click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewProductos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            idDoubleClickedRow = ObtenerIdFilaSeleccionadaProductos(e);
        }

        /// <summary>
        /// Agrega un producto al carrito de compras siempre que cantidad no sea cero.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btbAgregarAlCarro_Click(object sender, EventArgs e)
        {
            int cantidadDeseada = Validaciones.ValidarInt(txtCantidadHome.Text);

            if(cantidadDeseada > 0)
            {
                CargarProductoACarritoCompras(cantidadDeseada);
            }
            else
            {
                MessageBox.Show("Ingrese un número válido!", "¡Valor Inválido!");
            }

        }

        /// <summary>
        /// Elimina todos los productos del carrito de compras.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnResetCar_Click(object sender, EventArgs e)
        {
            if(CarritoCompras.ListaProductosCarrito.Count > 0)
            {
                CarritoCompras.RemoveAllItemsFromShopCar();
                CargarDataGridViewCarritoCompras();
            }
        }

        /// <summary>
        /// Remueve un producto del carrito al hacer doble click sobre el.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewCarrito_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            idDoubleClickedRow = ObtenerIdFilaSeleccionadaCarrito(e);

            foreach (Producto producto in Comercio.ListaProductos)
            {
                if (producto.Id.ToString() == idDoubleClickedRow)
                {
                    CarritoCompras.RemoveItemFromShopCar(producto);
                    CargarDataGridViewCarritoCompras();
                    break;
                }
            }
        }

        /// <summary>
        /// Obtiene la fila seleccionada de la lista de productos al hacer click y valida que no sea la fila head.
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        private string ObtenerIdFilaSeleccionadaProductos(DataGridViewCellMouseEventArgs e)
        {
            if(e.RowIndex == -1)
            {
                return "Click incorrecto";
            }
            else
            {
                return this.dataGridViewProductos.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }

        /// <summary>
        /// Obtiene la fila seleccionada del carrito al hacer click y valida que no sea la fila head
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        private string ObtenerIdFilaSeleccionadaCarrito(DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return "Click incorrecto";
            }
            else
            {
                return this.dataGridViewCarrito.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }

        /// <summary>
        /// Agrega un producto a la lista de productos del comercio (Utiliza sobrecarga del operador +)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void agregarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaProductoForm altaProductoForm = new AltaProductoForm();
            if(altaProductoForm.ShowDialog() == DialogResult.OK)
            {
                if(altaProductoForm.Producto + Comercio.ListaProductos)
                {
                    CargaDataGridProductos();
                    MessageBox.Show("Carga de datos exitosa!", "Carga Exitosa");
                }
                else
                {
                    MessageBox.Show("No se pudo completar la carga!", "Operación incompleta");
                }
            }
            else
            {
                MessageBox.Show("No se pudo concretar la carga de datos!", "Operación incompleta");
            }
        }

        /// <summary>
        /// Agrega Productos, ventas, clientes y carga el dataGridView de productos al presiona el boton correspondiente del menu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void agregarDatosPruebaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Comercio.ListaProductos.Count == 0 && Comercio.ListaPersonas.Count == 2)
            {
                CargaInicialClientes();
                CargaInicialProductos();
                CargaDataGridProductos();
                cargaInicialVentas();
            }
        }

        /// <summary>
        /// Modifica el producto llamando al Form necesario al presiona el boton correspondiente del menú.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void modificarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarProductoForm buscarProductoForm = new BuscarProductoForm();
            if (buscarProductoForm.ShowDialog() == DialogResult.OK)
            {
                CargaDataGridProductos();
                MessageBox.Show("Modificacion de datos exitosa!", "Carga Exitosa");
            }
            else
            {
                MessageBox.Show("No se pudo concretar la modificación de datos!", "Operación incompleta");
            }
        }

        /// <summary>
        /// Llama al form correspondiente para mostrar productos con menos de diez unidades.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void stockMenorADiezToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockMenosDiezForm stockMenosDiezForm = new StockMenosDiezForm();
            stockMenosDiezForm.ShowDialog();
        }

        /// <summary>
        /// Inicia el proceso de compra validando todo lo necesario (Carrito no este vacio, no haya mas productos que en el stock, etc).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnComprarHome_Click(object sender, EventArgs e)
        {
            if(CarritoCompras.ListaProductosCarrito.Count > 0)
            {
                if (Validaciones.StockDisponibleParaComprar())
                {
                    SeleccionarClienteForm seleccionarClienteForm = new SeleccionarClienteForm();

                    if(seleccionarClienteForm.ShowDialog() == DialogResult.OK)
                    {
                        CarritoCompras.RemoveAllItemsFromShopCar();
                        CargarDataGridViewCarritoCompras();
                        CargaDataGridProductos();
                        RepodrucirSonidoDeCompra();
                        MessageBox.Show("Gracias!! Vuelva Prontosss", "¡Gracias por su compra!");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo concretar la compra!", "Operación incompleta");
                    }
                }
                else
                {

                    MessageBox.Show("¡Parece que te emocionaste demasiado!", "¡Saca productos del carrito!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Tu carrito esta vacío!", "Carrito vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Reproduce el sonido personalizado al efectuarse una compra exitosamente.
        /// </summary>
        private void RepodrucirSonidoDeCompra()
        {
            try
            {
                SoundPlayer sellSound = new SoundPlayer(GetSongPath());
                sellSound.Play();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Ocurrió un inconveniente");
            }
        }

        /// <summary>
        /// Genera la ruta del arcivho de sonido wav para la venta exitosa.
        /// </summary>
        /// <returns>Ruta del archivo de audio .wav.</returns>
        private string GetSongPath()
        {
            return System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "rockGuitar.wav");
        }

        /// <summary>
        /// Setea el empleado actual logeado.
        /// </summary>
        /// <param name="empleado"></param>
        public void SetEmpleadoSesionActual(Empleado empleado)
        {
            empleadoActual = empleado;
        }

        /// <summary>
        /// Llama al Form necesario para mostrar las ventas por empleado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void porEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmpleadosForm empleadosForm = new EmpleadosForm();
            empleadosForm.ShowDialog();
        }
        #endregion

    }
}
