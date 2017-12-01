namespace iMedicas
{
    partial class Login
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txbUsuario = new MetroFramework.Controls.MetroTextBox();
            this.txbContraseña = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnEntrar = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(23, 80);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(70, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Usuario";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // txbUsuario
            // 
            // 
            // 
            // 
            this.txbUsuario.CustomButton.Image = null;
            this.txbUsuario.CustomButton.Location = new System.Drawing.Point(122, 1);
            this.txbUsuario.CustomButton.Name = "";
            this.txbUsuario.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txbUsuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbUsuario.CustomButton.TabIndex = 1;
            this.txbUsuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbUsuario.CustomButton.UseSelectable = true;
            this.txbUsuario.CustomButton.Visible = false;
            this.txbUsuario.Lines = new string[0];
            this.txbUsuario.Location = new System.Drawing.Point(23, 108);
            this.txbUsuario.MaxLength = 32767;
            this.txbUsuario.Name = "txbUsuario";
            this.txbUsuario.PasswordChar = '\0';
            this.txbUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbUsuario.SelectedText = "";
            this.txbUsuario.SelectionLength = 0;
            this.txbUsuario.SelectionStart = 0;
            this.txbUsuario.ShortcutsEnabled = true;
            this.txbUsuario.Size = new System.Drawing.Size(144, 23);
            this.txbUsuario.TabIndex = 0;
            this.txbUsuario.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbUsuario.UseSelectable = true;
            this.txbUsuario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbUsuario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txbContraseña
            // 
            // 
            // 
            // 
            this.txbContraseña.CustomButton.Image = null;
            this.txbContraseña.CustomButton.Location = new System.Drawing.Point(122, 1);
            this.txbContraseña.CustomButton.Name = "";
            this.txbContraseña.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txbContraseña.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbContraseña.CustomButton.TabIndex = 1;
            this.txbContraseña.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbContraseña.CustomButton.UseSelectable = true;
            this.txbContraseña.CustomButton.Visible = false;
            this.txbContraseña.Lines = new string[0];
            this.txbContraseña.Location = new System.Drawing.Point(23, 180);
            this.txbContraseña.MaxLength = 32767;
            this.txbContraseña.Name = "txbContraseña";
            this.txbContraseña.PasswordChar = '*';
            this.txbContraseña.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbContraseña.SelectedText = "";
            this.txbContraseña.SelectionLength = 0;
            this.txbContraseña.SelectionStart = 0;
            this.txbContraseña.ShortcutsEnabled = true;
            this.txbContraseña.Size = new System.Drawing.Size(144, 23);
            this.txbContraseña.TabIndex = 1;
            this.txbContraseña.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbContraseña.UseSelectable = true;
            this.txbContraseña.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbContraseña.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(23, 152);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(98, 25);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Contraseña";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(43, 230);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(100, 23);
            this.btnEntrar.TabIndex = 2;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnEntrar.UseSelectable = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(191, 276);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.txbContraseña);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txbUsuario);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txbUsuario;
        private MetroFramework.Controls.MetroTextBox txbContraseña;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btnEntrar;
    }
}