namespace GestionGimnasio.Forms.Menú
{
    partial class Alumnado
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
            dgvAlumnado = new DataGridView();
            txtDirecAl = new TextBox();
            txtNombreAl = new TextBox();
            txtApellidoAl = new TextBox();
            txtEdadAl = new TextBox();
            txtCelularAl = new TextBox();
            txtMailAl = new TextBox();
            txtDNIAl = new TextBox();
            cbPCuotaAl = new ComboBox();
            lblFSIS = new Label();
            cbTipoClaseAl = new ComboBox();
            btnAgregarAl = new Button();
            btnEditarAl = new Button();
            btnEliminarAl = new Button();
            lblNombre = new Label();
            lblApellido = new Label();
            lblEdad = new Label();
            lblCelular = new Label();
            lblMail = new Label();
            lblDNI = new Label();
            lblDireccion = new Label();
            lblPagoCuota = new Label();
            lblTipoClase = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnado).BeginInit();
            SuspendLayout();
            // 
            // dgvAlumnado
            // 
            dgvAlumnado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlumnado.Location = new Point(347, 68);
            dgvAlumnado.Name = "dgvAlumnado";
            dgvAlumnado.RowTemplate.Height = 25;
            dgvAlumnado.Size = new Size(604, 446);
            dgvAlumnado.TabIndex = 0;
            // 
            // txtDirecAl
            // 
            txtDirecAl.Location = new Point(77, 353);
            txtDirecAl.Name = "txtDirecAl";
            txtDirecAl.Size = new Size(237, 23);
            txtDirecAl.TabIndex = 1;
            // 
            // txtNombreAl
            // 
            txtNombreAl.Location = new Point(77, 68);
            txtNombreAl.Name = "txtNombreAl";
            txtNombreAl.Size = new Size(237, 23);
            txtNombreAl.TabIndex = 2;
            // 
            // txtApellidoAl
            // 
            txtApellidoAl.Location = new Point(77, 114);
            txtApellidoAl.Name = "txtApellidoAl";
            txtApellidoAl.Size = new Size(237, 23);
            txtApellidoAl.TabIndex = 3;
            // 
            // txtEdadAl
            // 
            txtEdadAl.Location = new Point(77, 161);
            txtEdadAl.Name = "txtEdadAl";
            txtEdadAl.Size = new Size(237, 23);
            txtEdadAl.TabIndex = 4;
            // 
            // txtCelularAl
            // 
            txtCelularAl.Location = new Point(77, 208);
            txtCelularAl.Name = "txtCelularAl";
            txtCelularAl.Size = new Size(237, 23);
            txtCelularAl.TabIndex = 5;
            // 
            // txtMailAl
            // 
            txtMailAl.Location = new Point(77, 255);
            txtMailAl.Name = "txtMailAl";
            txtMailAl.Size = new Size(237, 23);
            txtMailAl.TabIndex = 6;
            // 
            // txtDNIAl
            // 
            txtDNIAl.Location = new Point(77, 302);
            txtDNIAl.Name = "txtDNIAl";
            txtDNIAl.Size = new Size(237, 23);
            txtDNIAl.TabIndex = 7;
            // 
            // cbPCuotaAl
            // 
            cbPCuotaAl.FormattingEnabled = true;
            cbPCuotaAl.Location = new Point(97, 399);
            cbPCuotaAl.Name = "cbPCuotaAl";
            cbPCuotaAl.Size = new Size(132, 23);
            cbPCuotaAl.TabIndex = 8;
            // 
            // lblFSIS
            // 
            lblFSIS.AutoSize = true;
            lblFSIS.FlatStyle = FlatStyle.Flat;
            lblFSIS.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblFSIS.ForeColor = Color.Gray;
            lblFSIS.Location = new Point(41, 9);
            lblFSIS.Name = "lblFSIS";
            lblFSIS.Size = new Size(212, 30);
            lblFSIS.TabIndex = 16;
            lblFSIS.Text = "FORMAS STUDIO";
            // 
            // cbTipoClaseAl
            // 
            cbTipoClaseAl.FormattingEnabled = true;
            cbTipoClaseAl.Location = new Point(97, 443);
            cbTipoClaseAl.Name = "cbTipoClaseAl";
            cbTipoClaseAl.Size = new Size(132, 23);
            cbTipoClaseAl.TabIndex = 17;
            // 
            // btnAgregarAl
            // 
            btnAgregarAl.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregarAl.Location = new Point(178, 485);
            btnAgregarAl.Name = "btnAgregarAl";
            btnAgregarAl.Size = new Size(136, 48);
            btnAgregarAl.TabIndex = 18;
            btnAgregarAl.Text = "Agregar Alumno";
            btnAgregarAl.UseVisualStyleBackColor = true;
            // 
            // btnEditarAl
            // 
            btnEditarAl.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEditarAl.Location = new Point(987, 43);
            btnEditarAl.Name = "btnEditarAl";
            btnEditarAl.Size = new Size(136, 48);
            btnEditarAl.TabIndex = 19;
            btnEditarAl.Text = "Editar Alumno";
            btnEditarAl.UseVisualStyleBackColor = true;
            // 
            // btnEliminarAl
            // 
            btnEliminarAl.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminarAl.Location = new Point(987, 485);
            btnEliminarAl.Name = "btnEliminarAl";
            btnEliminarAl.Size = new Size(136, 48);
            btnEliminarAl.TabIndex = 20;
            btnEliminarAl.Text = "Eliminar Alumno";
            btnEliminarAl.UseVisualStyleBackColor = true;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(12, 71);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 21;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(12, 117);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 22;
            lblApellido.Text = "Apellido";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(12, 169);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(33, 15);
            lblEdad.TabIndex = 23;
            lblEdad.Text = "Edad";
            // 
            // lblCelular
            // 
            lblCelular.AutoSize = true;
            lblCelular.Location = new Point(12, 216);
            lblCelular.Name = "lblCelular";
            lblCelular.Size = new Size(44, 15);
            lblCelular.TabIndex = 24;
            lblCelular.Text = "Celular";
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.Location = new Point(12, 263);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(30, 15);
            lblMail.TabIndex = 25;
            lblMail.Text = "Mail";
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Location = new Point(12, 310);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(27, 15);
            lblDNI.TabIndex = 26;
            lblDNI.Text = "DNI";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(12, 356);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(57, 15);
            lblDireccion.TabIndex = 27;
            lblDireccion.Text = "Dirección";
            // 
            // lblPagoCuota
            // 
            lblPagoCuota.AutoSize = true;
            lblPagoCuota.Location = new Point(12, 402);
            lblPagoCuota.Name = "lblPagoCuota";
            lblPagoCuota.Size = new Size(69, 15);
            lblPagoCuota.TabIndex = 28;
            lblPagoCuota.Text = "Pago Cuota";
            // 
            // lblTipoClase
            // 
            lblTipoClase.AutoSize = true;
            lblTipoClase.Location = new Point(12, 446);
            lblTipoClase.Name = "lblTipoClase";
            lblTipoClase.Size = new Size(75, 15);
            lblTipoClase.TabIndex = 29;
            lblTipoClase.Text = "Tipo de clase";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Tahoma", 18F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(538, 20);
            label1.Name = "label1";
            label1.Size = new Size(255, 29);
            label1.TabIndex = 30;
            label1.Text = "Alumnado Completo";
            // 
            // Alumnado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1135, 545);
            Controls.Add(label1);
            Controls.Add(lblTipoClase);
            Controls.Add(lblPagoCuota);
            Controls.Add(lblDireccion);
            Controls.Add(lblDNI);
            Controls.Add(lblMail);
            Controls.Add(lblCelular);
            Controls.Add(lblEdad);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(btnEliminarAl);
            Controls.Add(btnEditarAl);
            Controls.Add(btnAgregarAl);
            Controls.Add(cbTipoClaseAl);
            Controls.Add(lblFSIS);
            Controls.Add(cbPCuotaAl);
            Controls.Add(txtDNIAl);
            Controls.Add(txtMailAl);
            Controls.Add(txtCelularAl);
            Controls.Add(txtEdadAl);
            Controls.Add(txtApellidoAl);
            Controls.Add(txtNombreAl);
            Controls.Add(txtDirecAl);
            Controls.Add(dgvAlumnado);
            Name = "Alumnado";
            Text = "Alumnado";
            ((System.ComponentModel.ISupportInitialize)dgvAlumnado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvAlumnado;
        private TextBox txtDirecAl;
        private TextBox txtNombreAl;
        private TextBox txtApellidoAl;
        private TextBox txtEdadAl;
        private TextBox txtCelularAl;
        private TextBox txtMailAl;
        private TextBox txtDNIAl;
        private ComboBox cbPCuotaAl;
        private Label lblFSIS;
        private ComboBox cbTipoClaseAl;
        private Button btnAgregarAl;
        private Button btnEditarAl;
        private Button btnEliminarAl;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblEdad;
        private Label lblCelular;
        private Label lblMail;
        private Label lblDNI;
        private Label lblDireccion;
        private Label lblPagoCuota;
        private Label lblTipoClase;
        private Label label1;
    }
}