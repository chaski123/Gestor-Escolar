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
    public partial class AltaGrado : Form
    {
        public AltaGrado()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            string input2 = textBox2.Text;

            // Verifica que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(input) || string.IsNullOrWhiteSpace(input2))
            {
                MessageBox.Show("El campo curso y/o division no pueden estar vacíos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verifica que los campos tengan un solo dígito numérico
            if ( input.Length != 1 || !char.IsDigit(input[0]) || (input2.Length != 1 || !char.IsDigit(input2[0])))
            {
                MessageBox.Show("El campo curso y/o division solo pueden contener un solo dígito numérico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Los campos son validos, se ha dado de alta con exito el grado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
