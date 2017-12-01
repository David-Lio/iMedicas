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
            this.btnProductos = new MetroFramework.Controls.MetroButton();
            this.btnVentas = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btnCotizacion
            // 
            this.btnCotizacion.Location = new System.Drawing.Point(23, 79);
            this.btnCotizacion.Name = "btnCotizacion";
            this.btnCotizacion.Size = new System.Drawing.Size(171, 39);
            this.btnCotizacion.TabIndex = 1;
            this.btnCotizacion.Text = "Nueva Venta";
            this.btnCotizacion.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnCotizacion.UseSelectable = true;
            this.btnCotizacion.Click += new System.EventHandler(this.btnCotizacion_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Location = new System.Drawing.Point(23, 199);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(171, 39);
            this.btnClientes.TabIndex = 3;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnClientes.UseSelectable = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.Location = new System.Drawing.Point(23, 263);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(171, 39);
            this.btnProductos.TabIndex = 4;
            this.btnProductos.Text = "Productos";
            this.btnProductos.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnProductos.UseSelectable = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.Location = new System.Drawing.Point(21, 142);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(171, 39);
            this.btnVentas.TabIndex = 2;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnVentas.UseSelectable = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 324);
            this.Controls.Add(this.btnVentas);
            this.Controls.Add(this.btnProductos);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.btnCotizacion);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnCotizacion;
        private MetroFramework.Controls.MetroButton btnClientes;
        private MetroFramework.Controls.MetroButton btnProductos;
        private MetroFramework.Controls.MetroButton btnVentas;
    }
}

