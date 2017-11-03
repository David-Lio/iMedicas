namespace iMedicas
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCotizacion = new MetroFramework.Controls.MetroButton();
            this.btnClientes = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btnCotizacion
            // 
            this.btnCotizacion.Location = new System.Drawing.Point(23, 84);
            this.btnCotizacion.Name = "btnCotizacion";
            this.btnCotizacion.Size = new System.Drawing.Size(171, 39);
            this.btnCotizacion.TabIndex = 1;
            this.btnCotizacion.Text = "Nueva Cotizacion";
            this.btnCotizacion.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnCotizacion.UseSelectable = true;
            this.btnCotizacion.Click += new System.EventHandler(this.btnCotizacion_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Location = new System.Drawing.Point(23, 160);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(171, 39);
            this.btnClientes.TabIndex = 2;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnClientes.UseSelectable = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 330);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.btnCotizacion);
            this.Name = "Inicio";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Inicio";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnCotizacion;
        private MetroFramework.Controls.MetroButton btnClientes;
    }
}

