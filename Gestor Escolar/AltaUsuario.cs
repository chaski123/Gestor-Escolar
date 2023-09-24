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
    public partial class AltaUsuario : Form
    {
        public AltaUsuario()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            string password = textBox2.Text;
            if ((textBox1.Text.Length > 0 && textBox1.Text.Length <= 8 && int.TryParse(textBox1.Text, out _) && EsPasswordNumerico(password)))
            {
                // El contenido del TextBox es un número válido con hasta 8 dígitos.
                MessageBox.Show("El nro de DNI es valido y la pass es numerica");
            }
            else
            {
                MessageBox.Show("Número DNI y/o pass no válidos.");
            }
        }
        static bool EsPasswordNumerico(string password)
        {
            string patron = @"^\d+$";

            // Utiliza el método Regex.IsMatch para verificar si la contraseña coincide con el patrón.
            return System.Text.RegularExpressions.Regex.IsMatch(password, patron);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                pictureBox1.Image = Properties.Resources.jefe; // Cambia "mujer" por el nombre de tu imagen de mujer.
            }
            else
            {
                pictureBox1.Image = Properties.Resources.mujertp5;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
