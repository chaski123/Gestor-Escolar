using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestor_Escolar
{
    public partial class AltaPersonal : Form
    {
        public AltaPersonal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validar el campo de DNI
            if (textBox1.Text.Length != 8 || !EsNumero(textBox1.Text))
            {
                MessageBox.Show("El DNI debe tener exactamente 8 números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar campos de texto (nombre y apellido)
            if (string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("Los campos de nombre y apellido no pueden estar vacíos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar la dirección
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("El campo de dirección no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string telefono = textBox5.Text;
            // Validar el número de teléfono
            if (!EsNumero(telefono) || string.IsNullOrWhiteSpace(telefono))
            {
                MessageBox.Show("El número de teléfono no es válido y/o esta vacio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string correo = textBox6.Text;
            if (!EsCorreoElectronicoValido(correo) || string.IsNullOrWhiteSpace(correo))
            {
                MessageBox.Show("El correo no es válido y/o esta vacio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Si llegamos aquí, todos los campos son válidos
            MessageBox.Show("Todos los campos son válidos.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool EsNumero(string valor)
        {
            return int.TryParse(valor, out _);
        }

        static bool EsCorreoElectronicoValido(string correo)
        {
            // Define el patrón de la expresión regular para validar una dirección de correo electrónico básica
            string patron = @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";

            // Utiliza el método Regex.IsMatch para verificar si el correo electrónico coincide con el patrón
            return Regex.IsMatch(correo, patron);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }
    }
}
