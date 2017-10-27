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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_cte,
            this.nom_cte,
            this.tel_cte,
            this.dir_cte,
            this.email_cte});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClientes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClientes.EnableHeadersVisualStyles = false;
            this.dgvClientes.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvClientes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgvClientes.Location = new System.Drawing.Point(20, 145);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
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
            this.btnAgregar.Location = new System.Drawing.Point(206, 105);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(110, 23);
            this.btnAgregar.TabIndex = 1;
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
            this.txbNombre.Lines = new string[0];
            this.txbNombre.Location = new System.Drawing.Point(20, 76);
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
            this.txbTelefono.Lines = new string[0];
            this.txbTelefono.Location = new System.Drawing.Point(147, 76);
            this.txbTelefono.MaxLength = 32767;
            this.txbTelefono.Name = "txbTelefono";
            this.txbTelefono.PasswordChar = '\0';
            this.txbTelefono.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbTelefono.SelectedText = "";
            this.txbTelefono.SelectionLength = 0;
            this.txbTelefono.SelectionStart = 0;
            this.txbTelefono.ShortcutsEnabled = true;
            this.txbTelefono.Size = new System.Drawing.Size(110, 23);
            this.txbTelefono.TabIndex = 4;
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
            this.txbDireccion.Lines = new string[0];
            this.txbDireccion.Location = new System.Drawing.Point(277, 76);
            this.txbDireccion.MaxLength = 32767;
            this.txbDireccion.Name = "txbDireccion";
            this.txbDireccion.PasswordChar = '\0';
            this.txbDireccion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbDireccion.SelectedText = "";
            this.txbDireccion.SelectionLength = 0;
            this.txbDireccion.SelectionStart = 0;
            this.txbDireccion.ShortcutsEnabled = true;
            this.txbDireccion.Size = new System.Drawing.Size(110, 23);
            this.txbDireccion.TabIndex = 6;
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
            this.txbEmail.Lines = new string[0];
            this.txbEmail.Location = new System.Drawing.Point(406, 76);
            this.txbEmail.MaxLength = 32767;
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.PasswordChar = '\0';
            this.txbEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbEmail.SelectedText = "";
            this.txbEmail.SelectionLength = 0;
            this.txbEmail.SelectionStart = 0;
            this.txbEmail.ShortcutsEnabled = true;
            this.txbEmail.Size = new System.Drawing.Size(110, 23);
            this.txbEmail.TabIndex = 7;
            this.txbEmail.UseSelectable = true;
            this.txbEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 449);
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
    }
}