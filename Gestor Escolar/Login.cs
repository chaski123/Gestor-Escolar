using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestor_Escolar
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            string usuario = textUsuario.Text;
            string password = textPassword.Text;
            if (!string.IsNullOrEmpty(usuario) && !string.IsNullOrEmpty(password) && EsPasswordNumerico(password))
            {
                if (EsTexto(usuario))
                {
                    // El contenido del primer TextBox es texto y el segundo es un número válido con hasta 8 dígitos.
                    MessageBox.Show("Los campos son correctos");
                    Inicio form = new Inicio();
                    form.Show();
                    this.Hide();
                    form.FormClosing += form_close;
                }
                else
                {
                    MessageBox.Show("El campo de usuario debe contener solo texto.");
                }
            }
            else
            {
                MessageBox.Show("Nombre de usuario y/o contraseña no son validos");
            }
        }
        static bool EsPasswordNumerico(string password)
        {
            string patron = @"^\d+$";

            // Utiliza el método Regex.IsMatch para verificar si la contraseña coincide con el patrón.
            return System.Text.RegularExpressions.Regex.IsMatch(password, patron);
        }

        private bool EsTexto(string input)
        {
            // Utilizamos una expresión regular para verificar si el input contiene solo letras.
            return System.Text.RegularExpressions.Regex.IsMatch(input, "^[a-zA-Z]+$");
        }

        private void form_close(object sender, FormClosingEventArgs e)
        {
            textUsuario.Text = "";
            textPassword.Text = "";
            this.Show();
        }
    }
}
