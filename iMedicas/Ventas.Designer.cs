namespace iMedicas
{
    partial class Ventas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbProductos = new MetroFramework.Controls.MetroComboBox();
            this.lblCliente = new MetroFramework.Controls.MetroLabel();
            this.btnAgregar = new MetroFramework.Controls.MetroButton();
            this.dgvProductos = new MetroFramework.Controls.MetroGrid();
            this.Id_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txbPrecio = new MetroFramework.Controls.MetroTextBox();
            this.txbDescripcion = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.lblTotal = new MetroFramework.Controls.MetroLabel();
            this.btnVenta = new MetroFramework.Controls.MetroButton();
            this.lblVenta = new MetroFramework.Controls.MetroLabel();
            this.btnEliminar = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // cbProductos
            // 
            this.cbProductos.FormattingEnabled = true;
            this.cbProductos.ItemHeight = 23;
            this.cbProductos.Location = new System.Drawing.Point(23, 113);
            this.cbProductos.Name = "cbProductos";
            this.cbProductos.Size = new System.Drawing.Size(166, 29);
            this.cbProductos.TabIndex = 0;
            this.cbProductos.UseSelectable = true;
            this.cbProductos.SelectedIndexChanged += new System.EventHandler(this.cbProductos_SelectedIndexChanged);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(23, 69);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(81, 19);
            this.lblCliente.TabIndex = 1;
            this.lblCliente.Text = "metroLabel1";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(44, 216);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 21;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseSelectable = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToResizeRows = false;
            this.dgvProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Producto,
            this.Descripcion_Producto,
            this.Precio_Producto});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductos.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvProductos.EnableHeadersVisualStyles = false;
            this.dgvProductos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvProductos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvProductos.Location = new System.Drawing.Point(23, 245);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(523, 193);
            this.dgvProductos.TabIndex = 20;
            // 
            // Id_Producto
            // 
            this.Id_Producto.DataPropertyName = "Id_Producto";
            this.Id_Producto.HeaderText = "Id Producto";
            this.Id_Producto.Name = "Id_Producto";
            this.Id_Producto.ReadOnly = true;
            // 
            // Descripcion_Producto
            // 
            this.Descripcion_Producto.DataPropertyName = "Descripcion";
            this.Descripcion_Producto.HeaderText = "Descripcion";
            this.Descripcion_Producto.Name = "Descripcion_Producto";
            this.Descripcion_Producto.ReadOnly = true;
            this.Descripcion_Producto.Width = 200;
            // 
            // Precio_Producto
            // 
            this.Precio_Producto.DataPropertyName = "Precio_Venta";
            this.Precio_Producto.HeaderText = "Precio";
            this.Precio_Producto.Name = "Precio_Producto";
            this.Precio_Producto.ReadOnly = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(372, 165);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(46, 19);
            this.metroLabel3.TabIndex = 18;
            this.metroLabel3.Text = "Precio";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(142, 165);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(76, 19);
            this.metroLabel2.TabIndex = 17;
            this.metroLabel2.Text = "Descripcion";
            // 
            // txbPrecio
            // 
            // 
            // 
            // 
            this.txbPrecio.CustomButton.Image = null;
            this.txbPrecio.CustomButton.Location = new System.Drawing.Point(96, 1);
            this.txbPrecio.CustomButton.Name = "";
            this.txbPrecio.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txbPrecio.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbPrecio.CustomButton.TabIndex = 1;
            this.txbPrecio.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbPrecio.CustomButton.UseSelectable = true;
            this.txbPrecio.CustomButton.Visible = false;
            this.txbPrecio.Enabled = false;
            this.txbPrecio.Lines = new string[0];
            this.txbPrecio.Location = new System.Drawing.Point(344, 187);
            this.txbPrecio.MaxLength = 32767;
            this.txbPrecio.Name = "txbPrecio";
            this.txbPrecio.PasswordChar = '\0';
            this.txbPrecio.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbPrecio.SelectedText = "";
            this.txbPrecio.SelectionLength = 0;
            this.txbPrecio.SelectionStart = 0;
            this.txbPrecio.ShortcutsEnabled = true;
            this.txbPrecio.Size = new System.Drawing.Size(118, 23);
            this.txbPrecio.TabIndex = 14;
            this.txbPrecio.UseSelectable = true;
            this.txbPrecio.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbPrecio.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txbDescripcion
            // 
            // 
            // 
            // 
            this.txbDescripcion.CustomButton.Image = null;
            this.txbDescripcion.CustomButton.Location = new System.Drawing.Point(293, 1);
            this.txbDescripcion.CustomButton.Name = "";
            this.txbDescripcion.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txbDescripcion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbDescripcion.CustomButton.TabIndex = 1;
            this.txbDescripcion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbDescripcion.CustomButton.UseSelectable = true;
            this.txbDescripcion.CustomButton.Visible = false;
            this.txbDescripcion.Enabled = false;
            this.txbDescripcion.Lines = new string[0];
            this.txbDescripcion.Location = new System.Drawing.Point(23, 187);
            this.txbDescripcion.MaxLength = 32767;
            this.txbDescripcion.Name = "txbDescripcion";
            this.txbDescripcion.PasswordChar = '\0';
            this.txbDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbDescripcion.SelectedText = "";
            this.txbDescripcion.SelectionLength = 0;
            this.txbDescripcion.SelectionStart = 0;
            this.txbDescripcion.ShortcutsEnabled = true;
            this.txbDescripcion.Size = new System.Drawing.Size(315, 23);
            this.txbDescripcion.TabIndex = 13;
            this.txbDescripcion.UseSelectable = true;
            this.txbDescripcion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbDescripcion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(344, 457);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(43, 19);
            this.metroLabel4.TabIndex = 24;
            this.metroLabel4.Text = "Total :";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(413, 457);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(83, 19);
            this.lblTotal.TabIndex = 25;
            this.lblTotal.Text = "metroLabel5";
            // 
            // btnVenta
            // 
            this.btnVenta.Location = new System.Drawing.Point(413, 492);
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.Size = new System.Drawing.Size(75, 23);
            this.btnVenta.TabIndex = 26;
            this.btnVenta.Text = "Hacer Venta";
            this.btnVenta.UseSelectable = true;
            this.btnVenta.Click += new System.EventHandler(this.btnVenta_Click);
            // 
            // lblVenta
            // 
            this.lblVenta.AutoSize = true;
            this.lblVenta.Location = new System.Drawing.Point(494, 69);
            this.lblVenta.Name = "lblVenta";
            this.lblVenta.Size = new System.Drawing.Size(81, 19);
            this.lblVenta.TabIndex = 27;
            this.lblVenta.Text = "metroLabel1";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(173, 216);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 28;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseSelectable = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 525);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lblVenta);
            this.Controls.Add(this.btnVenta);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txbPrecio);
            this.Controls.Add(this.txbDescripcion);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.cbProductos);
            this.Name = "Ventas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.Ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cbProductos;
        private MetroFramework.Controls.MetroLabel lblCliente;
        private MetroFramework.Controls.MetroButton btnAgregar;
        private MetroFramework.Controls.MetroGrid dgvProductos;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txbPrecio;
        private MetroFramework.Controls.MetroTextBox txbDescripcion;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel lblTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Producto;
        private MetroFramework.Controls.MetroButton btnVenta;
        private MetroFramework.Controls.MetroLabel lblVenta;
        private MetroFramework.Controls.MetroButton btnEliminar;
    }
}