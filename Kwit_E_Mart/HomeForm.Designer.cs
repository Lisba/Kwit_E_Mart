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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarrito)).BeginInit();
            this.menuStripHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewProductos
            // 
            this.dataGridViewProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.dataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductos.Location = new System.Drawing.Point(12, 41);
            this.dataGridViewProductos.Name = "dataGridViewProductos";
            this.dataGridViewProductos.Size = new System.Drawing.Size(446, 392);
            this.dataGridViewProductos.TabIndex = 0;
            this.dataGridViewProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridViewCarrito
            // 
            this.dataGridViewCarrito.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.dataGridViewCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCarrito.Location = new System.Drawing.Point(479, 65);
            this.dataGridViewCarrito.Name = "dataGridViewCarrito";
            this.dataGridViewCarrito.Size = new System.Drawing.Size(424, 295);
            this.dataGridViewCarrito.TabIndex = 1;
            this.dataGridViewCarrito.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
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
            this.lblBienvenidoHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenidoHome.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblBienvenidoHome.Location = new System.Drawing.Point(497, 36);
            this.lblBienvenidoHome.Name = "lblBienvenidoHome";
            this.lblBienvenidoHome.Size = new System.Drawing.Size(97, 20);
            this.lblBienvenidoHome.TabIndex = 3;
            this.lblBienvenidoHome.Text = "Bienvenido";
            // 
            // lblEmpleadoHome
            // 
            this.lblEmpleadoHome.AutoSize = true;
            this.lblEmpleadoHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleadoHome.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblEmpleadoHome.Location = new System.Drawing.Point(594, 36);
            this.lblEmpleadoHome.Name = "lblEmpleadoHome";
            this.lblEmpleadoHome.Size = new System.Drawing.Size(126, 20);
            this.lblEmpleadoHome.TabIndex = 4;
            this.lblEmpleadoHome.Text = "Lisbaldy Ojeda";
            // 
            // btnResetCar
            // 
            this.btnResetCar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnResetCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetCar.Location = new System.Drawing.Point(774, 27);
            this.btnResetCar.Name = "btnResetCar";
            this.btnResetCar.Size = new System.Drawing.Size(129, 34);
            this.btnResetCar.TabIndex = 8;
            this.btnResetCar.Text = "Resetear Carro";
            this.btnResetCar.UseVisualStyleBackColor = false;
            // 
            // btbAgregarAlCarro
            // 
            this.btbAgregarAlCarro.BackColor = System.Drawing.Color.DarkOrange;
            this.btbAgregarAlCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbAgregarAlCarro.Location = new System.Drawing.Point(293, 439);
            this.btbAgregarAlCarro.Name = "btbAgregarAlCarro";
            this.btbAgregarAlCarro.Size = new System.Drawing.Size(152, 35);
            this.btbAgregarAlCarro.TabIndex = 9;
            this.btbAgregarAlCarro.Text = "Agregar al carro";
            this.btbAgregarAlCarro.UseVisualStyleBackColor = false;
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
            this.stockMenorADiezToolStripMenuItem.Click += new System.EventHandler(this.stockMenorADiezToolStripMenuItem_Click);
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
            this.agregarDatosPruebaToolStripMenuItem.Click += new System.EventHandler(this.agregarDatosPruebaToolStripMenuItem_Click);
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
            this.menuStripHome.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            this.menuStripHome.MouseLeave += new System.EventHandler(this.menuStripHome_MouseLeave);
            this.menuStripHome.MouseHover += new System.EventHandler(this.menuStrip1_MouseHover);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(915, 496);
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
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kwik E Mart - Lisbaldy Ojeda";
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
    }
}

