using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionGimnasio.Forms.Seguridad
{
    public partial class CambiarContra : Form
    {
        public CambiarContra()
        {
            InitializeComponent();

            //letras en gris dentro de los textbox// 
            SetPlaceholder(txtMailCambContra, "Email");
            SetPlaceholder(txtCod, "Código");
            SetPlaceholder(txtNuevaContra, "Contraseña");
            SetPlaceholder(txtConfirmarNuevaContra, "Confirmar contraseña");

            // configurar botón de flecha// 
            btnFlechaCambContra.Click += BtnFechaCambContra_Click;
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


        //botón de flecha// 
        private void BtnFechaCambContra_Click(object sender, EventArgs e)
        {
            InicioSesion inicioSesion = new InicioSesion();
            inicioSesion.Show();
            this.Close();
        }


        private void CambiarContra_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
