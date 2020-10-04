namespace Kwit_E_Mart
{
    partial class HomeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewProductos = new System.Windows.Forms.DataGridView();
            this.dataGridViewCarrito = new System.Windows.Forms.DataGridView();
            this.lblSubTotalHome = new System.Windows.Forms.Label();
            this.lblSubTotalCifraHome = new System.Windows.Forms.Label();
            this.btnComprarHome = new System.Windows.Forms.Button();
            this.lblBienvenidoHome = new System.Windows.Forms.Label();
            this.lblEmpleadoHome = new System.Windows.Forms.Label();
            this.btnResetCar = new System.Windows.Forms.Button();
            this.btbAgregarAlCarro = new System.Windows.Forms.Button();
            this.lblCantidadHome = new System.Windows.Forms.Label();
            this.txtCantidadHome = new System.Windows.Forms.TextBox();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obtenerStockTotalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockMenorADiezToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarDatosPruebaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripHome = new System.Windows.Forms.MenuStrip();
            this.lblTituloProductos = new System.Windows.Forms.Label();
            this.lblTitleShopCar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarrito)).BeginInit();
            this.menuStripHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewProductos
            // 
            this.dataGridViewProductos.AllowUserToAddRows = false;
            this.dataGridViewProductos.AllowUserToDeleteRows = false;
            this.dataGridViewProductos.AllowUserToResizeColumns = false;
            this.dataGridViewProductos.AllowUserToResizeRows = false;
            this.dataGridViewProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.dataGridViewProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewProductos.ColumnHeadersHeight = 30;
            this.dataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewProductos.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewProductos.EnableHeadersVisualStyles = false;
            this.dataGridViewProductos.GridColor = System.Drawing.Color.Gray;
            this.dataGridViewProductos.Location = new System.Drawing.Point(12, 59);
            this.dataGridViewProductos.Name = "dataGridViewProductos";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewProductos.RowHeadersVisible = false;
            this.dataGridViewProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProductos.Size = new System.Drawing.Size(446, 374);
            this.dataGridViewProductos.TabIndex = 0;
            this.dataGridViewProductos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewProductos_CellMouseClick);
            this.dataGridViewProductos.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewProductos_CellMouseDoubleClick);
            // 
            // dataGridViewCarrito
            // 
            this.dataGridViewCarrito.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCarrito.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewCarrito.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.dataGridViewCarrito.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewCarrito.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCarrito.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewCarrito.ColumnHeadersHeight = 30;
            this.dataGridViewCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCarrito.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewCarrito.EnableHeadersVisualStyles = false;
            this.dataGridViewCarrito.Location = new System.Drawing.Point(479, 110);
            this.dataGridViewCarrito.Name = "dataGridViewCarrito";
            this.dataGridViewCarrito.RowHeadersVisible = false;
            this.dataGridViewCarrito.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewCarrito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCarrito.Size = new System.Drawing.Size(424, 250);
            this.dataGridViewCarrito.TabIndex = 1;
            this.dataGridViewCarrito.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewCarrito_CellMouseDoubleClick);
            // 
            // lblSubTotalHome
            // 
            this.lblSubTotalHome.AutoSize = true;
            this.lblSubTotalHome.BackColor = System.Drawing.Color.Transparent;
            this.lblSubTotalHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotalHome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSubTotalHome.Location = new System.Drawing.Point(497, 394);
            this.lblSubTotalHome.Name = "lblSubTotalHome";
            this.lblSubTotalHome.Size = new System.Drawing.Size(81, 20);
            this.lblSubTotalHome.TabIndex = 5;
            this.lblSubTotalHome.Text = "SubTotal";
            // 
            // lblSubTotalCifraHome
            // 
            this.lblSubTotalCifraHome.AutoSize = true;
            this.lblSubTotalCifraHome.BackColor = System.Drawing.Color.Transparent;
            this.lblSubTotalCifraHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotalCifraHome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSubTotalCifraHome.Location = new System.Drawing.Point(594, 394);
            this.lblSubTotalCifraHome.Name = "lblSubTotalCifraHome";
            this.lblSubTotalCifraHome.Size = new System.Drawing.Size(44, 20);
            this.lblSubTotalCifraHome.TabIndex = 6;
            this.lblSubTotalCifraHome.Text = "0,00";
            // 
            // btnComprarHome
            // 
            this.btnComprarHome.BackColor = System.Drawing.Color.DarkOrange;
            this.btnComprarHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnComprarHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprarHome.Location = new System.Drawing.Point(756, 383);
            this.btnComprarHome.Name = "btnComprarHome";
            this.btnComprarHome.Size = new System.Drawing.Size(133, 45);
            this.btnComprarHome.TabIndex = 7;
            this.btnComprarHome.Text = "COMPRAR";
            this.btnComprarHome.UseVisualStyleBackColor = false;
            // 
            // lblBienvenidoHome
            // 
            this.lblBienvenidoHome.AutoSize = true;
            this.lblBienvenidoHome.Font = new System.Drawing.Font("Bookman Old Style", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenidoHome.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblBienvenidoHome.Location = new System.Drawing.Point(557, 27);
            this.lblBienvenidoHome.Name = "lblBienvenidoHome";
            this.lblBienvenidoHome.Size = new System.Drawing.Size(103, 19);
            this.lblBienvenidoHome.TabIndex = 3;
            this.lblBienvenidoHome.Text = "Bienvenido";
            // 
            // lblEmpleadoHome
            // 
            this.lblEmpleadoHome.AutoSize = true;
            this.lblEmpleadoHome.Font = new System.Drawing.Font("Bookman Old Style", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleadoHome.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblEmpleadoHome.Location = new System.Drawing.Point(656, 27);
            this.lblEmpleadoHome.Name = "lblEmpleadoHome";
            this.lblEmpleadoHome.Size = new System.Drawing.Size(149, 19);
            this.lblEmpleadoHome.TabIndex = 4;
            this.lblEmpleadoHome.Text = "Nombre Apellido";
            // 
            // btnResetCar
            // 
            this.btnResetCar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnResetCar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnResetCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetCar.Location = new System.Drawing.Point(774, 70);
            this.btnResetCar.Name = "btnResetCar";
            this.btnResetCar.Size = new System.Drawing.Size(129, 34);
            this.btnResetCar.TabIndex = 8;
            this.btnResetCar.Text = "Resetear Carro";
            this.btnResetCar.UseVisualStyleBackColor = false;
            this.btnResetCar.Click += new System.EventHandler(this.btnResetCar_Click);
            // 
            // btbAgregarAlCarro
            // 
            this.btbAgregarAlCarro.BackColor = System.Drawing.Color.DarkOrange;
            this.btbAgregarAlCarro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btbAgregarAlCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbAgregarAlCarro.Location = new System.Drawing.Point(293, 439);
            this.btbAgregarAlCarro.Name = "btbAgregarAlCarro";
            this.btbAgregarAlCarro.Size = new System.Drawing.Size(152, 35);
            this.btbAgregarAlCarro.TabIndex = 9;
            this.btbAgregarAlCarro.Text = "Agregar al carro";
            this.btbAgregarAlCarro.UseVisualStyleBackColor = false;
            this.btbAgregarAlCarro.Click += new System.EventHandler(this.btbAgregarAlCarro_Click);
            // 
            // lblCantidadHome
            // 
            this.lblCantidadHome.AutoSize = true;
            this.lblCantidadHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadHome.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblCantidadHome.Location = new System.Drawing.Point(126, 447);
            this.lblCantidadHome.Name = "lblCantidadHome";
            this.lblCantidadHome.Size = new System.Drawing.Size(81, 20);
            this.lblCantidadHome.TabIndex = 10;
            this.lblCantidadHome.Text = "Cantidad";
            // 
            // txtCantidadHome
            // 
            this.txtCantidadHome.Location = new System.Drawing.Point(226, 447);
            this.txtCantidadHome.Name = "txtCantidadHome";
            this.txtCantidadHome.Size = new System.Drawing.Size(49, 20);
            this.txtCantidadHome.TabIndex = 11;
            this.txtCantidadHome.Text = "1";
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarProductoToolStripMenuItem,
            this.modificarProductoToolStripMenuItem,
            this.obtenerStockTotalToolStripMenuItem,
            this.stockMenorADiezToolStripMenuItem});
            this.inventarioToolStripMenuItem.ForeColor = System.Drawing.Color.DarkOrange;
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.inventarioToolStripMenuItem.Text = "Inventario";
            // 
            // agregarProductoToolStripMenuItem
            // 
            this.agregarProductoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.agregarProductoToolStripMenuItem.ForeColor = System.Drawing.Color.DarkOrange;
            this.agregarProductoToolStripMenuItem.Name = "agregarProductoToolStripMenuItem";
            this.agregarProductoToolStripMenuItem.Size = new System.Drawing.Size(279, 22);
            this.agregarProductoToolStripMenuItem.Text = "Agregar Producto";
            this.agregarProductoToolStripMenuItem.Click += new System.EventHandler(this.agregarProductoToolStripMenuItem_Click);
            // 
            // modificarProductoToolStripMenuItem
            // 
            this.modificarProductoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.modificarProductoToolStripMenuItem.ForeColor = System.Drawing.Color.DarkOrange;
            this.modificarProductoToolStripMenuItem.Name = "modificarProductoToolStripMenuItem";
            this.modificarProductoToolStripMenuItem.Size = new System.Drawing.Size(279, 22);
            this.modificarProductoToolStripMenuItem.Text = "Modificar Producto";
            // 
            // obtenerStockTotalToolStripMenuItem
            // 
            this.obtenerStockTotalToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.obtenerStockTotalToolStripMenuItem.ForeColor = System.Drawing.Color.DarkOrange;
            this.obtenerStockTotalToolStripMenuItem.Name = "obtenerStockTotalToolStripMenuItem";
            this.obtenerStockTotalToolStripMenuItem.Size = new System.Drawing.Size(279, 22);
            this.obtenerStockTotalToolStripMenuItem.Text = "Obtener Stock Total";
            // 
            // stockMenorADiezToolStripMenuItem
            // 
            this.stockMenorADiezToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.stockMenorADiezToolStripMenuItem.ForeColor = System.Drawing.Color.DarkOrange;
            this.stockMenorADiezToolStripMenuItem.Name = "stockMenorADiezToolStripMenuItem";
            this.stockMenorADiezToolStripMenuItem.Size = new System.Drawing.Size(279, 22);
            this.stockMenorADiezToolStripMenuItem.Text = "Productos con menos de 10 unidades";
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porEmpleadoToolStripMenuItem});
            this.ventasToolStripMenuItem.ForeColor = System.Drawing.Color.DarkOrange;
            this.ventasToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.ventasToolStripMenuItem.Text = "Ventas";
            // 
            // porEmpleadoToolStripMenuItem
            // 
            this.porEmpleadoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.porEmpleadoToolStripMenuItem.ForeColor = System.Drawing.Color.DarkOrange;
            this.porEmpleadoToolStripMenuItem.Name = "porEmpleadoToolStripMenuItem";
            this.porEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.porEmpleadoToolStripMenuItem.Text = "Por Empleado";
            // 
            // agregarDatosPruebaToolStripMenuItem
            // 
            this.agregarDatosPruebaToolStripMenuItem.ForeColor = System.Drawing.Color.DarkOrange;
            this.agregarDatosPruebaToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.agregarDatosPruebaToolStripMenuItem.Name = "agregarDatosPruebaToolStripMenuItem";
            this.agregarDatosPruebaToolStripMenuItem.Size = new System.Drawing.Size(139, 20);
            this.agregarDatosPruebaToolStripMenuItem.Text = "Agregar datos prueba";
            // 
            // menuStripHome
            // 
            this.menuStripHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuStripHome.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.menuStripHome.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inventarioToolStripMenuItem,
            this.ventasToolStripMenuItem,
            this.agregarDatosPruebaToolStripMenuItem});
            this.menuStripHome.Location = new System.Drawing.Point(0, 0);
            this.menuStripHome.Name = "menuStripHome";
            this.menuStripHome.Size = new System.Drawing.Size(915, 24);
            this.menuStripHome.TabIndex = 2;
            this.menuStripHome.Text = "menuStrip";
            this.menuStripHome.Visible = false;
            // 
            // lblTituloProductos
            // 
            this.lblTituloProductos.AutoSize = true;
            this.lblTituloProductos.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloProductos.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblTituloProductos.Location = new System.Drawing.Point(126, 37);
            this.lblTituloProductos.Name = "lblTituloProductos";
            this.lblTituloProductos.Size = new System.Drawing.Size(183, 19);
            this.lblTituloProductos.TabIndex = 12;
            this.lblTituloProductos.Text = "Listado de Productos";
            // 
            // lblTitleShopCar
            // 
            this.lblTitleShopCar.AutoSize = true;
            this.lblTitleShopCar.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleShopCar.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblTitleShopCar.Location = new System.Drawing.Point(571, 77);
            this.lblTitleShopCar.Name = "lblTitleShopCar";
            this.lblTitleShopCar.Size = new System.Drawing.Size(168, 19);
            this.lblTitleShopCar.TabIndex = 13;
            this.lblTitleShopCar.Text = "Carrito de Compras";
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(915, 496);
            this.Controls.Add(this.lblTitleShopCar);
            this.Controls.Add(this.lblTituloProductos);
            this.Controls.Add(this.txtCantidadHome);
            this.Controls.Add(this.lblCantidadHome);
            this.Controls.Add(this.btbAgregarAlCarro);
            this.Controls.Add(this.btnResetCar);
            this.Controls.Add(this.btnComprarHome);
            this.Controls.Add(this.lblSubTotalCifraHome);
            this.Controls.Add(this.lblSubTotalHome);
            this.Controls.Add(this.lblEmpleadoHome);
            this.Controls.Add(this.lblBienvenidoHome);
            this.Controls.Add(this.dataGridViewCarrito);
            this.Controls.Add(this.dataGridViewProductos);
            this.Controls.Add(this.menuStripHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStripHome;
            this.MaximizeBox = false;
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kwik E Mart - Lisbaldy Ojeda";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HomeForm_FormClosing_1);
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HomeForm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarrito)).EndInit();
            this.menuStripHome.ResumeLayout(false);
            this.menuStripHome.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProductos;
        private System.Windows.Forms.DataGridView dataGridViewCarrito;
        private System.Windows.Forms.Label lblSubTotalHome;
        private System.Windows.Forms.Label lblSubTotalCifraHome;
        private System.Windows.Forms.Button btnComprarHome;
        private System.Windows.Forms.Label lblBienvenidoHome;
        private System.Windows.Forms.Button btnResetCar;
        private System.Windows.Forms.Button btbAgregarAlCarro;
        private System.Windows.Forms.Label lblCantidadHome;
        private System.Windows.Forms.TextBox txtCantidadHome;
        public System.Windows.Forms.Label lblEmpleadoHome;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obtenerStockTotalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockMenorADiezToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarDatosPruebaToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStripHome;
        private System.Windows.Forms.Label lblTituloProductos;
        private System.Windows.Forms.Label lblTitleShopCar;
    }
}

