using GestionGimnasio.Forms.Seguridad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace GestionGimnasio
{
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
            SetPlaceholder(txtMailSesion, "Email");
            SetPlaceholder(txtContraSesion, "Contraseña");

            // manejadores de eventos
            btnCrearUsuario.Click += BtnCrearUsuario_Click;
            LlbCambContra.Click += LlbCambContra_Click;
        }

        //letras en gris dentro de los textbox// 

        private void SetPlaceholder(TextBox textbox, string placeholder)
        {
            textbox.ForeColor = Color.Gray;
            textbox.Text = placeholder;

            textbox.Enter += (sender, e) =>
            {
                if (textbox.Text == placeholder)
                {
                    textbox.Text = "";
                    textbox.ForeColor = Color.Black;
                }
            };

            textbox.Leave += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(textbox.Text))
                {
                    textbox.Text = placeholder;
                    textbox.ForeColor = Color.Gray;
                }
            };

        }


        //cerrar form y abrir form para crear usuario o cambiar contraseña//
        private void BtnCrearUsuario_Click(object sender, EventArgs e)
        {
            CambiarContra CambiarContra = new CambiarContra();
            CambiarContra.Show();
            this.Hide();
        }

        private void LlbCambContra_Click(object sender, EventArgs e)
        {
            CambiarContra CambiarContra = new CambiarContra();
            CambiarContra.Show();
            this.Hide();
        }


        //validaciones// 





        private void InicioSesion_Load(object sender, EventArgs e)
        {

        }

        private void txtMailSesion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
