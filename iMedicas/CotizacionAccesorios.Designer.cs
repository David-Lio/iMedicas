namespace iMedicas
{
    partial class CotizacionAccesorios
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
            this.cbAccesorios = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // cbAccesorios
            // 
            this.cbAccesorios.FormattingEnabled = true;
            this.cbAccesorios.ItemHeight = 23;
            this.cbAccesorios.Location = new System.Drawing.Point(12, 103);
            this.cbAccesorios.Name = "cbAccesorios";
            this.cbAccesorios.Size = new System.Drawing.Size(156, 29);
            this.cbAccesorios.TabIndex = 0;
            this.cbAccesorios.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbAccesorios.UseSelectable = true;
            this.cbAccesorios.SelectedIndexChanged += new System.EventHandler(this.cbAccesorios_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(12, 70);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(131, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Selecciona Accesorio";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // CotizacionAccesorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 349);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cbAccesorios);
            this.Name = "CotizacionAccesorios";
            this.Text = "Cotizacion";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.CotizacionAccesorios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cbAccesorios;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}