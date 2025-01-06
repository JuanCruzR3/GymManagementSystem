namespace GestionGimnasio.Forms.Seguridad
{
    partial class CambiarContra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CambiarContra));
            lblFSIS = new Label();
            txtMailCambContra = new TextBox();
            btnEnviarCod = new Button();
            txtCod = new TextBox();
            btnVerCod = new Button();
            txtNuevaContra = new TextBox();
            txtConfirmarNuevaContra = new TextBox();
            btnConfirmarContra = new Button();
            btnFlechaCambContra = new Button();
            SuspendLayout();
            // 
            // lblFSIS
            // 
            lblFSIS.AutoSize = true;
            lblFSIS.FlatStyle = FlatStyle.Flat;
            lblFSIS.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblFSIS.ForeColor = Color.Gray;
            lblFSIS.Location = new Point(130, 30);
            lblFSIS.Name = "lblFSIS";
            lblFSIS.Size = new Size(212, 30);
            lblFSIS.TabIndex = 8;
            lblFSIS.Text = "FORMAS STUDIO";
            // 
            // txtMailCambContra
            // 
            txtMailCambContra.BackColor = SystemColors.Window;
            txtMailCambContra.Location = new Point(22, 90);
            txtMailCambContra.Name = "txtMailCambContra";
            txtMailCambContra.Size = new Size(297, 23);
            txtMailCambContra.TabIndex = 9;
            // 
            // btnEnviarCod
            // 
            btnEnviarCod.Location = new Point(364, 81);
            btnEnviarCod.Name = "btnEnviarCod";
            btnEnviarCod.Size = new Size(91, 39);
            btnEnviarCod.TabIndex = 10;
            btnEnviarCod.Text = "Enviar código";
            btnEnviarCod.UseVisualStyleBackColor = true;
            // 
            // txtCod
            // 
            txtCod.BackColor = SystemColors.Window;
            txtCod.Location = new Point(22, 165);
            txtCod.Name = "txtCod";
            txtCod.Size = new Size(297, 23);
            txtCod.TabIndex = 11;
            // 
            // btnVerCod
            // 
            btnVerCod.Location = new Point(364, 156);
            btnVerCod.Name = "btnVerCod";
            btnVerCod.Size = new Size(91, 39);
            btnVerCod.TabIndex = 12;
            btnVerCod.Text = "Verificar código";
            btnVerCod.UseVisualStyleBackColor = true;
            // 
            // txtNuevaContra
            // 
            txtNuevaContra.BackColor = SystemColors.Window;
            txtNuevaContra.Location = new Point(22, 238);
            txtNuevaContra.Name = "txtNuevaContra";
            txtNuevaContra.Size = new Size(297, 23);
            txtNuevaContra.TabIndex = 13;
            // 
            // txtConfirmarNuevaContra
            // 
            txtConfirmarNuevaContra.BackColor = SystemColors.Window;
            txtConfirmarNuevaContra.Location = new Point(22, 277);
            txtConfirmarNuevaContra.Name = "txtConfirmarNuevaContra";
            txtConfirmarNuevaContra.Size = new Size(297, 23);
            txtConfirmarNuevaContra.TabIndex = 14;
            // 
            // btnConfirmarContra
            // 
            btnConfirmarContra.Location = new Point(355, 238);
            btnConfirmarContra.Name = "btnConfirmarContra";
            btnConfirmarContra.Size = new Size(110, 71);
            btnConfirmarContra.TabIndex = 15;
            btnConfirmarContra.Text = "Confirmar Contraseña";
            btnConfirmarContra.UseVisualStyleBackColor = true;
            // 
            // btnFlechaCambContra
            // 
            btnFlechaCambContra.BackgroundImage = (Image)resources.GetObject("btnFlechaCambContra.BackgroundImage");
            btnFlechaCambContra.Location = new Point(12, 12);
            btnFlechaCambContra.Name = "btnFlechaCambContra";
            btnFlechaCambContra.Size = new Size(48, 34);
            btnFlechaCambContra.TabIndex = 16;
            btnFlechaCambContra.Text = "🡸";
            btnFlechaCambContra.UseVisualStyleBackColor = true;
            btnFlechaCambContra.Click += button1_Click;
            // 
            // CambiarContra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(490, 340);
            Controls.Add(btnFlechaCambContra);
            Controls.Add(btnConfirmarContra);
            Controls.Add(txtConfirmarNuevaContra);
            Controls.Add(txtNuevaContra);
            Controls.Add(btnVerCod);
            Controls.Add(txtCod);
            Controls.Add(btnEnviarCod);
            Controls.Add(txtMailCambContra);
            Controls.Add(lblFSIS);
            Name = "CambiarContra";
            Text = "CambiarContra";
            Load += CambiarContra_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFSIS;
        private TextBox txtMailCambContra;
        private Button btnEnviarCod;
        private TextBox txtCod;
        private Button btnVerCod;
        private TextBox txtNuevaContra;
        private TextBox txtConfirmarNuevaContra;
        private Button btnConfirmarContra;
        private Button btnFlechaCambContra;
    }
}