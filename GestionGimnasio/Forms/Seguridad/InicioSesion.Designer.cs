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
            LlbCambContra = new LinkLabel();
            lblFSIS = new Label();
            label1 = new Label();
            btnCrearUsuario = new Button();
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
            txtMailSesion.BackColor = SystemColors.Window;
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
            // LlbCambContra
            // 
            LlbCambContra.AutoSize = true;
            LlbCambContra.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            LlbCambContra.Location = new Point(141, 281);
            LlbCambContra.Name = "LlbCambContra";
            LlbCambContra.Size = new Size(139, 17);
            LlbCambContra.TabIndex = 6;
            LlbCambContra.TabStop = true;
            LlbCambContra.Text = "¿Olvidó su Contraseña?";
            // 
            // lblFSIS
            // 
            lblFSIS.AutoSize = true;
            lblFSIS.FlatStyle = FlatStyle.Flat;
            lblFSIS.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblFSIS.ForeColor = Color.Gray;
            lblFSIS.Location = new Point(110, 48);
            lblFSIS.Name = "lblFSIS";
            lblFSIS.Size = new Size(212, 30);
            lblFSIS.TabIndex = 7;
            lblFSIS.Text = "FORMAS STUDIO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(24, 319);
            label1.Name = "label1";
            label1.Size = new Size(114, 17);
            label1.TabIndex = 8;
            label1.Text = "¿No tenes usuario?";
            // 
            // btnCrearUsuario
            // 
            btnCrearUsuario.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCrearUsuario.Location = new Point(144, 319);
            btnCrearUsuario.Name = "btnCrearUsuario";
            btnCrearUsuario.Size = new Size(136, 48);
            btnCrearUsuario.TabIndex = 9;
            btnCrearUsuario.Text = "Crear Usuario";
            btnCrearUsuario.UseVisualStyleBackColor = true;
            // 
            // InicioSesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(446, 394);
            Controls.Add(btnCrearUsuario);
            Controls.Add(label1);
            Controls.Add(lblFSIS);
            Controls.Add(LlbCambContra);
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
        private LinkLabel LlbCambContra;
        private Label lblFSIS;
        private Label label1;
        private Button btnCrearUsuario;
    }
}