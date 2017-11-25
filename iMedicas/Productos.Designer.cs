namespace iMedicas
{
    partial class Productos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txbId = new MetroFramework.Controls.MetroTextBox();
            this.txbDescripcion = new MetroFramework.Controls.MetroTextBox();
            this.txbPrecio = new MetroFramework.Controls.MetroTextBox();
            this.cbTipo = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.dgvProductos = new MetroFramework.Controls.MetroGrid();
            this.btnAgregar = new MetroFramework.Controls.MetroButton();
            this.btnActualizar = new MetroFramework.Controls.MetroButton();
            this.btnEliminar = new MetroFramework.Controls.MetroButton();
            this.Id_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.existenciaProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txbExistencia = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // txbId
            // 
            // 
            // 
            // 
            this.txbId.CustomButton.Image = null;
            this.txbId.CustomButton.Location = new System.Drawing.Point(11, 1);
            this.txbId.CustomButton.Name = "";
            this.txbId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txbId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbId.CustomButton.TabIndex = 1;
            this.txbId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbId.CustomButton.UseSelectable = true;
            this.txbId.CustomButton.Visible = false;
            this.txbId.Lines = new string[0];
            this.txbId.Location = new System.Drawing.Point(23, 128);
            this.txbId.MaxLength = 32767;
            this.txbId.Name = "txbId";
            this.txbId.PasswordChar = '\0';
            this.txbId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbId.SelectedText = "";
            this.txbId.SelectionLength = 0;
            this.txbId.SelectionStart = 0;
            this.txbId.ShortcutsEnabled = true;
            this.txbId.Size = new System.Drawing.Size(33, 23);
            this.txbId.TabIndex = 0;
            this.txbId.UseSelectable = true;
            this.txbId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txbId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbId_KeyPress);
            // 
            // txbDescripcion
            // 
            // 
            // 
            // 
            this.txbDescripcion.CustomButton.Image = null;
            this.txbDescripcion.CustomButton.Location = new System.Drawing.Point(109, 1);
            this.txbDescripcion.CustomButton.Name = "";
            this.txbDescripcion.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txbDescripcion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbDescripcion.CustomButton.TabIndex = 1;
            this.txbDescripcion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbDescripcion.CustomButton.UseSelectable = true;
            this.txbDescripcion.CustomButton.Visible = false;
            this.txbDescripcion.Lines = new string[0];
            this.txbDescripcion.Location = new System.Drawing.Point(91, 128);
            this.txbDescripcion.MaxLength = 32767;
            this.txbDescripcion.Name = "txbDescripcion";
            this.txbDescripcion.PasswordChar = '\0';
            this.txbDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbDescripcion.SelectedText = "";
            this.txbDescripcion.SelectionLength = 0;
            this.txbDescripcion.SelectionStart = 0;
            this.txbDescripcion.ShortcutsEnabled = true;
            this.txbDescripcion.Size = new System.Drawing.Size(131, 23);
            this.txbDescripcion.TabIndex = 1;
            this.txbDescripcion.UseSelectable = true;
            this.txbDescripcion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbDescripcion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.txbPrecio.Lines = new string[0];
            this.txbPrecio.Location = new System.Drawing.Point(254, 128);
            this.txbPrecio.MaxLength = 32767;
            this.txbPrecio.Name = "txbPrecio";
            this.txbPrecio.PasswordChar = '\0';
            this.txbPrecio.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbPrecio.SelectedText = "";
            this.txbPrecio.SelectionLength = 0;
            this.txbPrecio.SelectionStart = 0;
            this.txbPrecio.ShortcutsEnabled = true;
            this.txbPrecio.Size = new System.Drawing.Size(118, 23);
            this.txbPrecio.TabIndex = 2;
            this.txbPrecio.UseSelectable = true;
            this.txbPrecio.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbPrecio.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txbPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbId_KeyPress);
            // 
            // cbTipo
            // 
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.ItemHeight = 23;
            this.cbTipo.Items.AddRange(new object[] {
            "Microscopio",
            "Accesorio"});
            this.cbTipo.Location = new System.Drawing.Point(497, 122);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(121, 29);
            this.cbTipo.TabIndex = 3;
            this.cbTipo.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 106);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(21, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "ID";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(114, 106);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(76, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Descripcion";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(282, 106);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(46, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Precio";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(497, 100);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(35, 19);
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "Tipo";
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToResizeRows = false;
            this.dgvProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Producto,
            this.Descripcion_Producto,
            this.Precio_Producto,
            this.Tipo_Producto,
            this.existenciaProducto});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProductos.EnableHeadersVisualStyles = false;
            this.dgvProductos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvProductos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvProductos.Location = new System.Drawing.Point(23, 196);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(623, 193);
            this.dgvProductos.TabIndex = 8;
            this.dgvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellClick);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(74, 167);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseSelectable = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(226, 167);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 10;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseSelectable = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(395, 167);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseSelectable = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Id_Producto
            // 
            this.Id_Producto.DataPropertyName = "Id_Producto";
            this.Id_Producto.HeaderText = "Id";
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
            // Tipo_Producto
            // 
            this.Tipo_Producto.DataPropertyName = "Tipo_Producto";
            this.Tipo_Producto.HeaderText = "Tipo";
            this.Tipo_Producto.Name = "Tipo_Producto";
            this.Tipo_Producto.ReadOnly = true;
            this.Tipo_Producto.Width = 80;
            // 
            // existenciaProducto
            // 
            this.existenciaProducto.DataPropertyName = "Existencia";
            this.existenciaProducto.HeaderText = "Existencia";
            this.existenciaProducto.Name = "existenciaProducto";
            this.existenciaProducto.ReadOnly = true;
            // 
            // txbExistencia
            // 
            this.txbExistencia.AutoSize = true;
            this.txbExistencia.Location = new System.Drawing.Point(395, 106);
            this.txbExistencia.Name = "txbExistencia";
            this.txbExistencia.Size = new System.Drawing.Size(64, 19);
            this.txbExistencia.TabIndex = 13;
            this.txbExistencia.Text = "Existencia";
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(395, 128);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(75, 23);
            this.metroTextBox1.TabIndex = 12;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbId_KeyPress);
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 397);
            this.Controls.Add(this.txbExistencia);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.txbPrecio);
            this.Controls.Add(this.txbDescripcion);
            this.Controls.Add(this.txbId);
            this.Name = "Productos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txbId;
        private MetroFramework.Controls.MetroTextBox txbDescripcion;
        private MetroFramework.Controls.MetroTextBox txbPrecio;
        private MetroFramework.Controls.MetroComboBox cbTipo;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroGrid dgvProductos;
        private MetroFramework.Controls.MetroButton btnAgregar;
        private MetroFramework.Controls.MetroButton btnActualizar;
        private MetroFramework.Controls.MetroButton btnEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn existenciaProducto;
        private MetroFramework.Controls.MetroLabel txbExistencia;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
    }
}