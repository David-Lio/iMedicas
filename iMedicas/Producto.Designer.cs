namespace iMedicas
{
    partial class Producto
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txbId = new MetroFramework.Controls.MetroTextBox();
            this.txbModelo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txbPrecioV = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txbPrecioR = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.dgvMicroscopios = new MetroFramework.Controls.MetroGrid();
            this.Id_Microscopio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo_Microscopio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_V = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_Renta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnActualizar = new MetroFramework.Controls.MetroButton();
            this.btnEliminar = new MetroFramework.Controls.MetroButton();
            this.btnAgregar = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMicroscopios)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(75, 75);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(21, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "ID";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // txbId
            // 
            // 
            // 
            // 
            this.txbId.CustomButton.Image = null;
            this.txbId.CustomButton.Location = new System.Drawing.Point(-1, 1);
            this.txbId.CustomButton.Name = "";
            this.txbId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txbId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbId.CustomButton.TabIndex = 1;
            this.txbId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbId.CustomButton.UseSelectable = true;
            this.txbId.CustomButton.Visible = false;
            this.txbId.Lines = new string[0];
            this.txbId.Location = new System.Drawing.Point(75, 108);
            this.txbId.MaxLength = 32767;
            this.txbId.Name = "txbId";
            this.txbId.PasswordChar = '\0';
            this.txbId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbId.SelectedText = "";
            this.txbId.SelectionLength = 0;
            this.txbId.SelectionStart = 0;
            this.txbId.ShortcutsEnabled = true;
            this.txbId.Size = new System.Drawing.Size(21, 23);
            this.txbId.TabIndex = 1;
            this.txbId.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbId.UseSelectable = true;
            this.txbId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txbId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbId_KeyPress);
            // 
            // txbModelo
            // 
            // 
            // 
            // 
            this.txbModelo.CustomButton.Image = null;
            this.txbModelo.CustomButton.Location = new System.Drawing.Point(126, 1);
            this.txbModelo.CustomButton.Name = "";
            this.txbModelo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txbModelo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbModelo.CustomButton.TabIndex = 1;
            this.txbModelo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbModelo.CustomButton.UseSelectable = true;
            this.txbModelo.CustomButton.Visible = false;
            this.txbModelo.Lines = new string[0];
            this.txbModelo.Location = new System.Drawing.Point(120, 108);
            this.txbModelo.MaxLength = 32767;
            this.txbModelo.Name = "txbModelo";
            this.txbModelo.PasswordChar = '\0';
            this.txbModelo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbModelo.SelectedText = "";
            this.txbModelo.SelectionLength = 0;
            this.txbModelo.SelectionStart = 0;
            this.txbModelo.ShortcutsEnabled = true;
            this.txbModelo.Size = new System.Drawing.Size(148, 23);
            this.txbModelo.TabIndex = 3;
            this.txbModelo.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbModelo.UseSelectable = true;
            this.txbModelo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbModelo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(169, 75);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(55, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Modelo";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // txbPrecioV
            // 
            // 
            // 
            // 
            this.txbPrecioV.CustomButton.Image = null;
            this.txbPrecioV.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txbPrecioV.CustomButton.Name = "";
            this.txbPrecioV.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txbPrecioV.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbPrecioV.CustomButton.TabIndex = 1;
            this.txbPrecioV.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbPrecioV.CustomButton.UseSelectable = true;
            this.txbPrecioV.CustomButton.Visible = false;
            this.txbPrecioV.Lines = new string[0];
            this.txbPrecioV.Location = new System.Drawing.Point(292, 108);
            this.txbPrecioV.MaxLength = 32767;
            this.txbPrecioV.Name = "txbPrecioV";
            this.txbPrecioV.PasswordChar = '\0';
            this.txbPrecioV.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbPrecioV.SelectedText = "";
            this.txbPrecioV.SelectionLength = 0;
            this.txbPrecioV.SelectionStart = 0;
            this.txbPrecioV.ShortcutsEnabled = true;
            this.txbPrecioV.Size = new System.Drawing.Size(75, 23);
            this.txbPrecioV.TabIndex = 5;
            this.txbPrecioV.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbPrecioV.UseSelectable = true;
            this.txbPrecioV.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbPrecioV.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txbPrecioV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbId_KeyPress);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(288, 75);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(82, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Precio Venta";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // txbPrecioR
            // 
            // 
            // 
            // 
            this.txbPrecioR.CustomButton.Image = null;
            this.txbPrecioR.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txbPrecioR.CustomButton.Name = "";
            this.txbPrecioR.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txbPrecioR.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbPrecioR.CustomButton.TabIndex = 1;
            this.txbPrecioR.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbPrecioR.CustomButton.UseSelectable = true;
            this.txbPrecioR.CustomButton.Visible = false;
            this.txbPrecioR.Lines = new string[0];
            this.txbPrecioR.Location = new System.Drawing.Point(391, 108);
            this.txbPrecioR.MaxLength = 32767;
            this.txbPrecioR.Name = "txbPrecioR";
            this.txbPrecioR.PasswordChar = '\0';
            this.txbPrecioR.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbPrecioR.SelectedText = "";
            this.txbPrecioR.SelectionLength = 0;
            this.txbPrecioR.SelectionStart = 0;
            this.txbPrecioR.ShortcutsEnabled = true;
            this.txbPrecioR.Size = new System.Drawing.Size(75, 23);
            this.txbPrecioR.TabIndex = 7;
            this.txbPrecioR.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbPrecioR.UseSelectable = true;
            this.txbPrecioR.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbPrecioR.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txbPrecioR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbId_KeyPress);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(393, 75);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(83, 19);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "Precio Renta";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // dgvMicroscopios
            // 
            this.dgvMicroscopios.AllowUserToResizeRows = false;
            this.dgvMicroscopios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvMicroscopios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMicroscopios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvMicroscopios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMicroscopios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMicroscopios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMicroscopios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Microscopio,
            this.Modelo_Microscopio,
            this.Precio_V,
            this.Precio_Renta});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMicroscopios.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMicroscopios.EnableHeadersVisualStyles = false;
            this.dgvMicroscopios.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvMicroscopios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvMicroscopios.Location = new System.Drawing.Point(23, 173);
            this.dgvMicroscopios.Name = "dgvMicroscopios";
            this.dgvMicroscopios.ReadOnly = true;
            this.dgvMicroscopios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMicroscopios.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMicroscopios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvMicroscopios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMicroscopios.Size = new System.Drawing.Size(524, 162);
            this.dgvMicroscopios.Style = MetroFramework.MetroColorStyle.Blue;
            this.dgvMicroscopios.TabIndex = 10;
            this.dgvMicroscopios.Theme = MetroFramework.MetroThemeStyle.Light;
            this.dgvMicroscopios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMicroscopios_CellClick);
            // 
            // Id_Microscopio
            // 
            this.Id_Microscopio.DataPropertyName = "Id_Microscopio";
            this.Id_Microscopio.HeaderText = "Id";
            this.Id_Microscopio.Name = "Id_Microscopio";
            this.Id_Microscopio.ReadOnly = true;
            this.Id_Microscopio.Width = 50;
            // 
            // Modelo_Microscopio
            // 
            this.Modelo_Microscopio.DataPropertyName = "Modelo";
            this.Modelo_Microscopio.HeaderText = "Modelo";
            this.Modelo_Microscopio.Name = "Modelo_Microscopio";
            this.Modelo_Microscopio.ReadOnly = true;
            this.Modelo_Microscopio.Width = 250;
            // 
            // Precio_V
            // 
            this.Precio_V.DataPropertyName = "Precio_V";
            this.Precio_V.HeaderText = "Precio Venta";
            this.Precio_V.Name = "Precio_V";
            this.Precio_V.ReadOnly = true;
            this.Precio_V.Width = 90;
            // 
            // Precio_Renta
            // 
            this.Precio_Renta.DataPropertyName = "Precio_R";
            this.Precio_Renta.HeaderText = "Precio Renta";
            this.Precio_Renta.Name = "Precio_Renta";
            this.Precio_Renta.ReadOnly = true;
            this.Precio_Renta.Width = 90;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(366, 144);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(110, 23);
            this.btnActualizar.TabIndex = 16;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnActualizar.UseSelectable = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(222, 144);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(110, 23);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnEliminar.UseSelectable = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(78, 144);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(110, 23);
            this.btnAgregar.TabIndex = 14;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnAgregar.UseSelectable = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 355);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvMicroscopios);
            this.Controls.Add(this.txbPrecioR);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txbPrecioV);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txbModelo);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txbId);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Producto";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Microscopios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMicroscopios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txbId;
        private MetroFramework.Controls.MetroTextBox txbModelo;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txbPrecioV;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txbPrecioR;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroGrid dgvMicroscopios;
        private MetroFramework.Controls.MetroButton btnActualizar;
        private MetroFramework.Controls.MetroButton btnEliminar;
        private MetroFramework.Controls.MetroButton btnAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Microscopio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo_Microscopio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_V;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Renta;
    }
}