namespace Kwit_E_Mart
{
    partial class BuscarProductoForm
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
            this.lblTituloBuscarProducto = new System.Windows.Forms.Label();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.lblIdBuscarProducto = new System.Windows.Forms.Label();
            this.txtBuscarProducto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTituloBuscarProducto
            // 
            this.lblTituloBuscarProducto.AutoSize = true;
            this.lblTituloBuscarProducto.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloBuscarProducto.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblTituloBuscarProducto.Location = new System.Drawing.Point(84, 6);
            this.lblTituloBuscarProducto.Name = "lblTituloBuscarProducto";
            this.lblTituloBuscarProducto.Size = new System.Drawing.Size(146, 19);
            this.lblTituloBuscarProducto.TabIndex = 13;
            this.lblTituloBuscarProducto.Text = "Buscar Producto";
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.BackColor = System.Drawing.Color.DarkOrange;
            this.btnBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProducto.Location = new System.Drawing.Point(75, 88);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(132, 26);
            this.btnBuscarProducto.TabIndex = 12;
            this.btnBuscarProducto.Text = "Buscar";
            this.btnBuscarProducto.UseVisualStyleBackColor = false;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // lblIdBuscarProducto
            // 
            this.lblIdBuscarProducto.AutoSize = true;
            this.lblIdBuscarProducto.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdBuscarProducto.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblIdBuscarProducto.Location = new System.Drawing.Point(12, 50);
            this.lblIdBuscarProducto.Name = "lblIdBuscarProducto";
            this.lblIdBuscarProducto.Size = new System.Drawing.Size(106, 19);
            this.lblIdBuscarProducto.TabIndex = 14;
            this.lblIdBuscarProducto.Text = "Id Producto";
            // 
            // txtBuscarProducto
            // 
            this.txtBuscarProducto.Location = new System.Drawing.Point(121, 50);
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.Size = new System.Drawing.Size(169, 20);
            this.txtBuscarProducto.TabIndex = 9;
            // 
            // BuscarProductoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(302, 126);
            this.Controls.Add(this.lblTituloBuscarProducto);
            this.Controls.Add(this.btnBuscarProducto);
            this.Controls.Add(this.lblIdBuscarProducto);
            this.Controls.Add(this.txtBuscarProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BuscarProductoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingresa el ID del Producto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloBuscarProducto;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.Label lblIdBuscarProducto;
        private System.Windows.Forms.TextBox txtBuscarProducto;
    }
}