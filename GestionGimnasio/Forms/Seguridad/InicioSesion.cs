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
            SetPlaceholder (txtMailSesion, "Email");
            SetPlaceholder (txtContraSesion, "contraseña"); 
        }

        private void SetPlaceholder (TextBox textbox, string placeholder)
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

        private void InicioSesion_Load(object sender, EventArgs e)
        {

        }

        private void txtMailSesion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
