namespace GestionGimnasio.Forms
{
    partial class Menu
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
            btnAlumnado = new Button();
            btnProductos = new Button();
            btnClases = new Button();
            btnCobros = new Button();
            lblFSIS = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnAlumnado
            // 
            btnAlumnado.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAlumnado.Location = new Point(50, 141);
            btnAlumnado.Name = "btnAlumnado";
            btnAlumnado.Size = new Size(136, 48);
            btnAlumnado.TabIndex = 4;
            btnAlumnado.Text = "Alumnado";
            btnAlumnado.UseVisualStyleBackColor = true;
            // 
            // btnProductos
            // 
            btnProductos.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnProductos.Location = new Point(233, 229);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(136, 48);
            btnProductos.TabIndex = 5;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = true;
            // 
            // btnClases
            // 
            btnClases.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnClases.Location = new Point(48, 229);
            btnClases.Name = "btnClases";
            btnClases.Size = new Size(138, 48);
            btnClases.TabIndex = 6;
            btnClases.Text = "Clases";
            btnClases.UseVisualStyleBackColor = true;
            // 
            // btnCobros
            // 
            btnCobros.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCobros.Location = new Point(233, 141);
            btnCobros.Name = "btnCobros";
            btnCobros.Size = new Size(138, 48);
            btnCobros.TabIndex = 7;
            btnCobros.Text = "Cobros pendientes";
            btnCobros.UseVisualStyleBackColor = true;
            // 
            // lblFSIS
            // 
            lblFSIS.AutoSize = true;
            lblFSIS.FlatStyle = FlatStyle.Flat;
            lblFSIS.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblFSIS.ForeColor = Color.Gray;
            lblFSIS.Location = new Point(99, 18);
            lblFSIS.Name = "lblFSIS";
            lblFSIS.Size = new Size(212, 30);
            lblFSIS.TabIndex = 9;
            lblFSIS.Text = "FORMAS STUDIO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(127, 64);
            label1.Name = "label1";
            label1.Size = new Size(161, 30);
            label1.TabIndex = 10;
            label1.Text = "BIENVENIDO";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(437, 374);
            Controls.Add(label1);
            Controls.Add(lblFSIS);
            Controls.Add(btnCobros);
            Controls.Add(btnClases);
            Controls.Add(btnProductos);
            Controls.Add(btnAlumnado);
            Name = "Menu";
            Text = "Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAlumnado;
        private Button btnProductos;
        private Button btnClases;
        private Button btnCobros;
        private Label lblFSIS;
        private Label label1;
    }
}