namespace GestionGimnasio
{
    partial class InicioSesion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnIniciarSesion = new Button();
            txtMailSesion = new TextBox();
            txtContraSesion = new TextBox();
            LlblCambContra = new LinkLabel();
            lblFSIS = new Label();
            SuspendLayout();
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnIniciarSesion.Location = new Point(144, 211);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(136, 48);
            btnIniciarSesion.TabIndex = 3;
            btnIniciarSesion.Text = "Iniciar Sesión";
            btnIniciarSesion.UseVisualStyleBackColor = true;
            // 
            // txtMailSesion
            // 
            txtMailSesion.Location = new Point(73, 112);
            txtMailSesion.Name = "txtMailSesion";
            txtMailSesion.Size = new Size(306, 23);
            txtMailSesion.TabIndex = 4;
            txtMailSesion.TextChanged += txtMailSesion_TextChanged;
            // 
            // txtContraSesion
            // 
            txtContraSesion.Location = new Point(73, 164);
            txtContraSesion.Name = "txtContraSesion";
            txtContraSesion.Size = new Size(306, 23);
            txtContraSesion.TabIndex = 5;
            // 
            // LlblCambContra
            // 
            LlblCambContra.AutoSize = true;
            LlblCambContra.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            LlblCambContra.Location = new Point(141, 281);
            LlblCambContra.Name = "LlblCambContra";
            LlblCambContra.Size = new Size(139, 17);
            LlblCambContra.TabIndex = 6;
            LlblCambContra.TabStop = true;
            LlblCambContra.Text = "¿Olvidó su Contraseña?";
            // 
            // lblFSIS
            // 
            lblFSIS.AutoSize = true;
            lblFSIS.FlatStyle = FlatStyle.Flat;
            lblFSIS.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblFSIS.ForeColor = Color.DarkCyan;
            lblFSIS.Location = new Point(110, 48);
            lblFSIS.Name = "lblFSIS";
            lblFSIS.Size = new Size(212, 30);
            lblFSIS.TabIndex = 7;
            lblFSIS.Text = "FORMAS STUDIO";
            // 
            // InicioSesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(446, 394);
            Controls.Add(lblFSIS);
            Controls.Add(LlblCambContra);
            Controls.Add(txtContraSesion);
            Controls.Add(txtMailSesion);
            Controls.Add(btnIniciarSesion);
            Name = "InicioSesion";
            Text = "InicioSesion";
            Load += InicioSesion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnIniciarSesion;
        private TextBox txtMailSesion;
        private TextBox txtContraSesion;
        private LinkLabel LlblCambContra;
        private Label lblFSIS;
    }
}