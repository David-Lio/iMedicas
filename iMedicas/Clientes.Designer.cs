namespace iMedicas
{
    partial class Clientes
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
            this.dgvClientes = new MetroFramework.Controls.MetroGrid();
            this.Id_cte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_cte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel_cte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dir_cte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email_cte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregar = new MetroFramework.Controls.MetroButton();
            this.txbNombre = new MetroFramework.Controls.MetroTextBox();
            this.txbTelefono = new MetroFramework.Controls.MetroTextBox();
            this.txbDireccion = new MetroFramework.Controls.MetroTextBox();
            this.txbEmail = new MetroFramework.Controls.MetroTextBox();
            this.txbId = new MetroFramework.Controls.MetroTextBox();
            this.btnEliminar = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToResizeRows = false;
            this.dgvClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_cte,
            this.nom_cte,
            this.tel_cte,
            this.dir_cte,
            this.email_cte});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClientes.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvClientes.EnableHeadersVisualStyles = false;
            this.dgvClientes.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvClientes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgvClientes.Location = new System.Drawing.Point(20, 145);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvClientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(543, 281);
            this.dgvClientes.Style = MetroFramework.MetroColorStyle.Red;
            this.dgvClientes.TabIndex = 0;
            this.dgvClientes.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.dgvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellClick);
            // 
            // Id_cte
            // 
            this.Id_cte.DataPropertyName = "Id_Cliente";
            this.Id_cte.HeaderText = "ID";
            this.Id_cte.Name = "Id_cte";
            // 
            // nom_cte
            // 
            this.nom_cte.DataPropertyName = "Nombre_Cliente";
            this.nom_cte.HeaderText = "Nombre";
            this.nom_cte.Name = "nom_cte";
            // 
            // tel_cte
            // 
            this.tel_cte.DataPropertyName = "Telefono";
            this.tel_cte.HeaderText = "Telefono";
            this.tel_cte.Name = "tel_cte";
            // 
            // dir_cte
            // 
            this.dir_cte.DataPropertyName = "Direccion";
            this.dir_cte.HeaderText = "Direccion";
            this.dir_cte.Name = "dir_cte";
            // 
            // email_cte
            // 
            this.email_cte.DataPropertyName = "Email";
            this.email_cte.HeaderText = "Email";
            this.email_cte.Name = "email_cte";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(131, 101);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(110, 23);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseSelectable = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txbNombre
            // 
            // 
            // 
            // 
            this.txbNombre.CustomButton.Image = null;
            this.txbNombre.CustomButton.Location = new System.Drawing.Point(88, 1);
            this.txbNombre.CustomButton.Name = "";
            this.txbNombre.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txbNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbNombre.CustomButton.TabIndex = 1;
            this.txbNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbNombre.CustomButton.UseSelectable = true;
            this.txbNombre.CustomButton.Visible = false;
            this.txbNombre.Lines = new string[] {
        "Nombre"};
            this.txbNombre.Location = new System.Drawing.Point(72, 72);
            this.txbNombre.MaxLength = 32767;
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.PasswordChar = '\0';
            this.txbNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbNombre.SelectedText = "";
            this.txbNombre.SelectionLength = 0;
            this.txbNombre.SelectionStart = 0;
            this.txbNombre.ShortcutsEnabled = true;
            this.txbNombre.Size = new System.Drawing.Size(110, 23);
            this.txbNombre.TabIndex = 2;
            this.txbNombre.Text = "Nombre";
            this.txbNombre.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txbNombre.UseSelectable = true;
            this.txbNombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbNombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txbTelefono
            // 
            // 
            // 
            // 
            this.txbTelefono.CustomButton.Image = null;
            this.txbTelefono.CustomButton.Location = new System.Drawing.Point(88, 1);
            this.txbTelefono.CustomButton.Name = "";
            this.txbTelefono.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txbTelefono.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbTelefono.CustomButton.TabIndex = 1;
            this.txbTelefono.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbTelefono.CustomButton.UseSelectable = true;
            this.txbTelefono.CustomButton.Visible = false;
            this.txbTelefono.Lines = new string[] {
        "Telefono"};
            this.txbTelefono.Location = new System.Drawing.Point(199, 72);
            this.txbTelefono.MaxLength = 32767;
            this.txbTelefono.Name = "txbTelefono";
            this.txbTelefono.PasswordChar = '\0';
            this.txbTelefono.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbTelefono.SelectedText = "";
            this.txbTelefono.SelectionLength = 0;
            this.txbTelefono.SelectionStart = 0;
            this.txbTelefono.ShortcutsEnabled = true;
            this.txbTelefono.Size = new System.Drawing.Size(110, 23);
            this.txbTelefono.TabIndex = 3;
            this.txbTelefono.Text = "Telefono";
            this.txbTelefono.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txbTelefono.UseSelectable = true;
            this.txbTelefono.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbTelefono.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txbDireccion
            // 
            // 
            // 
            // 
            this.txbDireccion.CustomButton.Image = null;
            this.txbDireccion.CustomButton.Location = new System.Drawing.Point(88, 1);
            this.txbDireccion.CustomButton.Name = "";
            this.txbDireccion.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txbDireccion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbDireccion.CustomButton.TabIndex = 1;
            this.txbDireccion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbDireccion.CustomButton.UseSelectable = true;
            this.txbDireccion.CustomButton.Visible = false;
            this.txbDireccion.Lines = new string[] {
        "Direccion"};
            this.txbDireccion.Location = new System.Drawing.Point(326, 72);
            this.txbDireccion.MaxLength = 32767;
            this.txbDireccion.Name = "txbDireccion";
            this.txbDireccion.PasswordChar = '\0';
            this.txbDireccion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbDireccion.SelectedText = "";
            this.txbDireccion.SelectionLength = 0;
            this.txbDireccion.SelectionStart = 0;
            this.txbDireccion.ShortcutsEnabled = true;
            this.txbDireccion.Size = new System.Drawing.Size(110, 23);
            this.txbDireccion.TabIndex = 4;
            this.txbDireccion.Text = "Direccion";
            this.txbDireccion.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txbDireccion.UseSelectable = true;
            this.txbDireccion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbDireccion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txbEmail
            // 
            // 
            // 
            // 
            this.txbEmail.CustomButton.Image = null;
            this.txbEmail.CustomButton.Location = new System.Drawing.Point(88, 1);
            this.txbEmail.CustomButton.Name = "";
            this.txbEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txbEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbEmail.CustomButton.TabIndex = 1;
            this.txbEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbEmail.CustomButton.UseSelectable = true;
            this.txbEmail.CustomButton.Visible = false;
            this.txbEmail.Lines = new string[] {
        "Email"};
            this.txbEmail.Location = new System.Drawing.Point(453, 72);
            this.txbEmail.MaxLength = 32767;
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.PasswordChar = '\0';
            this.txbEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbEmail.SelectedText = "";
            this.txbEmail.SelectionLength = 0;
            this.txbEmail.SelectionStart = 0;
            this.txbEmail.ShortcutsEnabled = true;
            this.txbEmail.Size = new System.Drawing.Size(110, 23);
            this.txbEmail.TabIndex = 5;
            this.txbEmail.Text = "Email";
            this.txbEmail.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txbEmail.UseSelectable = true;
            this.txbEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txbId
            // 
            // 
            // 
            // 
            this.txbId.CustomButton.Image = null;
            this.txbId.CustomButton.Location = new System.Drawing.Point(13, 1);
            this.txbId.CustomButton.Name = "";
            this.txbId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txbId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbId.CustomButton.TabIndex = 1;
            this.txbId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbId.CustomButton.UseSelectable = true;
            this.txbId.CustomButton.Visible = false;
            this.txbId.Lines = new string[0];
            this.txbId.Location = new System.Drawing.Point(20, 72);
            this.txbId.MaxLength = 32767;
            this.txbId.Name = "txbId";
            this.txbId.PasswordChar = '\0';
            this.txbId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbId.SelectedText = "";
            this.txbId.SelectionLength = 0;
            this.txbId.SelectionStart = 0;
            this.txbId.ShortcutsEnabled = true;
            this.txbId.Size = new System.Drawing.Size(35, 23);
            this.txbId.TabIndex = 1;
            this.txbId.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txbId.UseSelectable = true;
            this.txbId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(271, 101);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(110, 23);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseSelectable = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 449);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txbId);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.txbDireccion);
            this.Controls.Add(this.txbTelefono);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvClientes);
            this.Name = "Clientes";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Clientes";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid dgvClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_cte;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_cte;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel_cte;
        private System.Windows.Forms.DataGridViewTextBoxColumn dir_cte;
        private System.Windows.Forms.DataGridViewTextBoxColumn email_cte;
        private MetroFramework.Controls.MetroButton btnAgregar;
        private MetroFramework.Controls.MetroTextBox txbNombre;
        private MetroFramework.Controls.MetroTextBox txbTelefono;
        private MetroFramework.Controls.MetroTextBox txbDireccion;
        private MetroFramework.Controls.MetroTextBox txbEmail;
        private MetroFramework.Controls.MetroTextBox txbId;
        private MetroFramework.Controls.MetroButton btnEliminar;
    }
}