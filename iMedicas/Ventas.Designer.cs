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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbProductos = new MetroFramework.Controls.MetroComboBox();
            this.btnAgregar = new MetroFramework.Controls.MetroButton();
            this.dgvProductos = new MetroFramework.Controls.MetroGrid();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txbPrecio = new MetroFramework.Controls.MetroTextBox();
            this.txbDescripcion = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.lblTotal = new MetroFramework.Controls.MetroLabel();
            this.btnVenta = new MetroFramework.Controls.MetroButton();
            this.lblVenta = new MetroFramework.Controls.MetroLabel();
            this.btnEliminar = new MetroFramework.Controls.MetroButton();
            this.cbClientes = new MetroFramework.Controls.MetroComboBox();
            this.txbEmail = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txbDireccion = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txbTelefono = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.Id_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // cbProductos
            // 
            this.cbProductos.FormattingEnabled = true;
            this.cbProductos.ItemHeight = 23;
            this.cbProductos.Location = new System.Drawing.Point(23, 169);
            this.cbProductos.Name = "cbProductos";
            this.cbProductos.Size = new System.Drawing.Size(166, 29);
            this.cbProductos.TabIndex = 0;
            this.cbProductos.UseSelectable = true;
            this.cbProductos.SelectedIndexChanged += new System.EventHandler(this.cbProductos_SelectedIndexChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(44, 272);
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
            this.Precio_Producto});
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
            this.dgvProductos.Location = new System.Drawing.Point(23, 301);
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
            this.dgvProductos.Size = new System.Drawing.Size(451, 193);
            this.dgvProductos.TabIndex = 20;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(372, 221);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(46, 19);
            this.metroLabel3.TabIndex = 18;
            this.metroLabel3.Text = "Precio";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(142, 221);
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
            this.txbPrecio.Location = new System.Drawing.Point(344, 243);
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
            this.txbDescripcion.Location = new System.Drawing.Point(23, 243);
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
            this.metroLabel4.Location = new System.Drawing.Point(344, 513);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(43, 19);
            this.metroLabel4.TabIndex = 24;
            this.metroLabel4.Text = "Total :";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(413, 513);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(16, 19);
            this.lblTotal.TabIndex = 25;
            this.lblTotal.Text = "0";
            // 
            // btnVenta
            // 
            this.btnVenta.Location = new System.Drawing.Point(413, 548);
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
            this.lblVenta.Location = new System.Drawing.Point(469, 169);
            this.lblVenta.Name = "lblVenta";
            this.lblVenta.Size = new System.Drawing.Size(81, 19);
            this.lblVenta.TabIndex = 27;
            this.lblVenta.Text = "metroLabel1";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(173, 272);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 28;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseSelectable = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // cbClientes
            // 
            this.cbClientes.FormattingEnabled = true;
            this.cbClientes.ItemHeight = 23;
            this.cbClientes.Location = new System.Drawing.Point(23, 106);
            this.cbClientes.Name = "cbClientes";
            this.cbClientes.Size = new System.Drawing.Size(166, 29);
            this.cbClientes.TabIndex = 29;
            this.cbClientes.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cbClientes.UseSelectable = true;
            this.cbClientes.SelectedIndexChanged += new System.EventHandler(this.cbClientes_SelectedIndexChanged);
            // 
            // txbEmail
            // 
            // 
            // 
            // 
            this.txbEmail.CustomButton.Image = null;
            this.txbEmail.CustomButton.Location = new System.Drawing.Point(107, 1);
            this.txbEmail.CustomButton.Name = "";
            this.txbEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txbEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbEmail.CustomButton.TabIndex = 1;
            this.txbEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbEmail.CustomButton.UseSelectable = true;
            this.txbEmail.CustomButton.Visible = false;
            this.txbEmail.Lines = new string[0];
            this.txbEmail.Location = new System.Drawing.Point(509, 112);
            this.txbEmail.MaxLength = 32767;
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.PasswordChar = '\0';
            this.txbEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbEmail.SelectedText = "";
            this.txbEmail.SelectionLength = 0;
            this.txbEmail.SelectionStart = 0;
            this.txbEmail.ShortcutsEnabled = true;
            this.txbEmail.Size = new System.Drawing.Size(129, 23);
            this.txbEmail.TabIndex = 35;
            this.txbEmail.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbEmail.UseSelectable = true;
            this.txbEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(509, 90);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(41, 19);
            this.metroLabel1.TabIndex = 34;
            this.metroLabel1.Text = "Email";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // txbDireccion
            // 
            // 
            // 
            // 
            this.txbDireccion.CustomButton.Image = null;
            this.txbDireccion.CustomButton.Location = new System.Drawing.Point(107, 1);
            this.txbDireccion.CustomButton.Name = "";
            this.txbDireccion.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txbDireccion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbDireccion.CustomButton.TabIndex = 1;
            this.txbDireccion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbDireccion.CustomButton.UseSelectable = true;
            this.txbDireccion.CustomButton.Visible = false;
            this.txbDireccion.Lines = new string[0];
            this.txbDireccion.Location = new System.Drawing.Point(359, 112);
            this.txbDireccion.MaxLength = 32767;
            this.txbDireccion.Name = "txbDireccion";
            this.txbDireccion.PasswordChar = '\0';
            this.txbDireccion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbDireccion.SelectedText = "";
            this.txbDireccion.SelectionLength = 0;
            this.txbDireccion.SelectionStart = 0;
            this.txbDireccion.ShortcutsEnabled = true;
            this.txbDireccion.Size = new System.Drawing.Size(129, 23);
            this.txbDireccion.TabIndex = 33;
            this.txbDireccion.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbDireccion.UseSelectable = true;
            this.txbDireccion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbDireccion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(359, 90);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(63, 19);
            this.metroLabel5.TabIndex = 32;
            this.metroLabel5.Text = "Direccion";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // txbTelefono
            // 
            // 
            // 
            // 
            this.txbTelefono.CustomButton.Image = null;
            this.txbTelefono.CustomButton.Location = new System.Drawing.Point(107, 1);
            this.txbTelefono.CustomButton.Name = "";
            this.txbTelefono.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txbTelefono.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbTelefono.CustomButton.TabIndex = 1;
            this.txbTelefono.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbTelefono.CustomButton.UseSelectable = true;
            this.txbTelefono.CustomButton.Visible = false;
            this.txbTelefono.Lines = new string[0];
            this.txbTelefono.Location = new System.Drawing.Point(209, 112);
            this.txbTelefono.MaxLength = 32767;
            this.txbTelefono.Name = "txbTelefono";
            this.txbTelefono.PasswordChar = '\0';
            this.txbTelefono.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbTelefono.SelectedText = "";
            this.txbTelefono.SelectionLength = 0;
            this.txbTelefono.SelectionStart = 0;
            this.txbTelefono.ShortcutsEnabled = true;
            this.txbTelefono.Size = new System.Drawing.Size(129, 23);
            this.txbTelefono.TabIndex = 31;
            this.txbTelefono.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbTelefono.UseSelectable = true;
            this.txbTelefono.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbTelefono.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(209, 90);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(58, 19);
            this.metroLabel6.TabIndex = 30;
            this.metroLabel6.Text = "Telefono";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(23, 69);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(114, 19);
            this.metroLabel7.TabIndex = 36;
            this.metroLabel7.Text = "Seleccione Cliente";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(23, 147);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(128, 19);
            this.metroLabel8.TabIndex = 37;
            this.metroLabel8.Text = "Seleccione Producto";
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
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 587);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txbDireccion);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.txbTelefono);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.cbClientes);
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
        private MetroFramework.Controls.MetroButton btnAgregar;
        private MetroFramework.Controls.MetroGrid dgvProductos;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txbPrecio;
        private MetroFramework.Controls.MetroTextBox txbDescripcion;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel lblTotal;
        private MetroFramework.Controls.MetroButton btnVenta;
        private MetroFramework.Controls.MetroLabel lblVenta;
        private MetroFramework.Controls.MetroButton btnEliminar;
        private MetroFramework.Controls.MetroComboBox cbClientes;
        private MetroFramework.Controls.MetroTextBox txbEmail;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txbDireccion;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txbTelefono;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Producto;
    }
}