namespace GestionGimnasio.Forms.Menú
{
    partial class Clases
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
            btnMusculacion = new Button();
            lblFSIS = new Label();
            label1 = new Label();
            btnFuncional = new Button();
            btnDanza = new Button();
            btnRitmos = new Button();
            SuspendLayout();
            // 
            // btnMusculacion
            // 
            btnMusculacion.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnMusculacion.Location = new Point(53, 121);
            btnMusculacion.Name = "btnMusculacion";
            btnMusculacion.Size = new Size(136, 55);
            btnMusculacion.TabIndex = 12;
            btnMusculacion.Text = "Musculación";
            btnMusculacion.UseVisualStyleBackColor = true;
            // 
            // lblFSIS
            // 
            lblFSIS.AutoSize = true;
            lblFSIS.FlatStyle = FlatStyle.Flat;
            lblFSIS.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblFSIS.ForeColor = Color.Gray;
            lblFSIS.Location = new Point(109, 23);
            lblFSIS.Name = "lblFSIS";
            lblFSIS.Size = new Size(212, 30);
            lblFSIS.TabIndex = 16;
            lblFSIS.Text = "FORMAS STUDIO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(162, 66);
            label1.Name = "label1";
            label1.Size = new Size(98, 30);
            label1.TabIndex = 17;
            label1.Text = "Clases";
            // 
            // btnFuncional
            // 
            btnFuncional.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnFuncional.Location = new Point(255, 121);
            btnFuncional.Name = "btnFuncional";
            btnFuncional.Size = new Size(136, 55);
            btnFuncional.TabIndex = 18;
            btnFuncional.Text = "Funcional";
            btnFuncional.UseVisualStyleBackColor = true;
            // 
            // btnDanza
            // 
            btnDanza.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDanza.Location = new Point(53, 211);
            btnDanza.Name = "btnDanza";
            btnDanza.Size = new Size(136, 55);
            btnDanza.TabIndex = 19;
            btnDanza.Text = "Danza";
            btnDanza.UseVisualStyleBackColor = true;
            // 
            // btnRitmos
            // 
            btnRitmos.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRitmos.Location = new Point(255, 211);
            btnRitmos.Name = "btnRitmos";
            btnRitmos.Size = new Size(136, 55);
            btnRitmos.TabIndex = 20;
            btnRitmos.Text = "Ritmos";
            btnRitmos.UseVisualStyleBackColor = true;
            // 
            // Clases
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(425, 346);
            Controls.Add(btnRitmos);
            Controls.Add(btnDanza);
            Controls.Add(btnFuncional);
            Controls.Add(label1);
            Controls.Add(lblFSIS);
            Controls.Add(btnMusculacion);
            Name = "Clases";
            Text = "Clases";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMusculacion;
        private Label lblFSIS;
        private Label label1;
        private Button btnFuncional;
        private Button btnDanza;
        private Button btnRitmos;
    }
}