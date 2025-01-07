namespace GestionGimnasio.Forms.Admin
{
    partial class MenuAdmin
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
            label1 = new Label();
            lblFSIS = new Label();
            btnCobrosAdm = new Button();
            btnClasesAdm = new Button();
            btnProductosAdm = new Button();
            btnAlumnadoAdm = new Button();
            btnUsuariosAdm = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(137, 78);
            label1.Name = "label1";
            label1.Size = new Size(161, 30);
            label1.TabIndex = 16;
            label1.Text = "BIENVENIDO";
            // 
            // lblFSIS
            // 
            lblFSIS.AutoSize = true;
            lblFSIS.FlatStyle = FlatStyle.Flat;
            lblFSIS.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblFSIS.ForeColor = Color.Gray;
            lblFSIS.Location = new Point(109, 32);
            lblFSIS.Name = "lblFSIS";
            lblFSIS.Size = new Size(212, 30);
            lblFSIS.TabIndex = 15;
            lblFSIS.Text = "FORMAS STUDIO";
            // 
            // btnCobrosAdm
            // 
            btnCobrosAdm.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCobrosAdm.Location = new Point(243, 155);
            btnCobrosAdm.Name = "btnCobrosAdm";
            btnCobrosAdm.Size = new Size(138, 48);
            btnCobrosAdm.TabIndex = 14;
            btnCobrosAdm.Text = "Cobros pendientes";
            btnCobrosAdm.UseVisualStyleBackColor = true;
            // 
            // btnClasesAdm
            // 
            btnClasesAdm.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnClasesAdm.Location = new Point(58, 243);
            btnClasesAdm.Name = "btnClasesAdm";
            btnClasesAdm.Size = new Size(138, 48);
            btnClasesAdm.TabIndex = 13;
            btnClasesAdm.Text = "Clases";
            btnClasesAdm.UseVisualStyleBackColor = true;
            // 
            // btnProductosAdm
            // 
            btnProductosAdm.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnProductosAdm.Location = new Point(243, 243);
            btnProductosAdm.Name = "btnProductosAdm";
            btnProductosAdm.Size = new Size(136, 48);
            btnProductosAdm.TabIndex = 12;
            btnProductosAdm.Text = "Productos";
            btnProductosAdm.UseVisualStyleBackColor = true;
            // 
            // btnAlumnadoAdm
            // 
            btnAlumnadoAdm.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAlumnadoAdm.Location = new Point(60, 155);
            btnAlumnadoAdm.Name = "btnAlumnadoAdm";
            btnAlumnadoAdm.Size = new Size(136, 48);
            btnAlumnadoAdm.TabIndex = 11;
            btnAlumnadoAdm.Text = "Alumnado";
            btnAlumnadoAdm.UseVisualStyleBackColor = true;
            // 
            // btnUsuariosAdm
            // 
            btnUsuariosAdm.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUsuariosAdm.Location = new Point(146, 322);
            btnUsuariosAdm.Name = "btnUsuariosAdm";
            btnUsuariosAdm.Size = new Size(136, 48);
            btnUsuariosAdm.TabIndex = 17;
            btnUsuariosAdm.Text = "Usuarios";
            btnUsuariosAdm.UseVisualStyleBackColor = true;
            // 
            // MenuAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(440, 418);
            Controls.Add(btnUsuariosAdm);
            Controls.Add(label1);
            Controls.Add(lblFSIS);
            Controls.Add(btnCobrosAdm);
            Controls.Add(btnClasesAdm);
            Controls.Add(btnProductosAdm);
            Controls.Add(btnAlumnadoAdm);
            Name = "MenuAdmin";
            Text = "MenuAdmin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblFSIS;
        private Button btnCobrosAdm;
        private Button btnClasesAdm;
        private Button btnProductosAdm;
        private Button btnAlumnadoAdm;
        private Button btnUsuariosAdm;
    }
}