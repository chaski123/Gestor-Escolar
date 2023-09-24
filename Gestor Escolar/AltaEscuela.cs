using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestor_Escolar
{
    public partial class AltaEscuela : Form
    {
        public AltaEscuela()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            string nroEscuela = textEscuelaNro.Text;
            string nombreEscuela = textEscuelaNombre.Text;
            string direccionEscuela = textEscuelaDireccion.Text;
            string provEscuela = textEscuelaProv.Text;
            string locEscuela = textEscuelaLoc.Text;
            string telEscuela = textEscuelaTel.Text;
            string correoEscuela = textEscuelaCorreo.Text;

            if (!string.IsNullOrEmpty(nroEscuela) &&
                !string.IsNullOrEmpty(nombreEscuela) &&
                !string.IsNullOrEmpty(direccionEscuela) &&
                !string.IsNullOrEmpty(provEscuela) &&
                !string.IsNullOrEmpty(locEscuela) &&
                !string.IsNullOrEmpty(telEscuela) && 
                EsNumerico(telEscuela) &&
                !string.IsNullOrEmpty(correoEscuela) &&
                EsNumerico(nroEscuela) &&
                IsValidEmail(correoEscuela))
            {
                MessageBox.Show("Se agregaron con éxito los datos de la escuela");
            }
            else
            {
                MessageBox.Show("Los datos no pueden estar vacíos y/o el tipo de dato es incorrecto o el correo no es válido.");
            }

        }

        private bool EsNumerico(string input)
        {
            // Verificamos si la cadena contiene solo dígitos y no excede 8 caracteres.
            return System.Text.RegularExpressions.Regex.IsMatch(input, "^[0-9]{1,8}$");
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var mailAddress = new MailAddress(email);
                return mailAddress.Address == email;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            textEscuelaNro.Clear();
            textEscuelaNombre.Clear();
            textEscuelaDireccion.Clear();
            textEscuelaProv.Clear();
            textEscuelaLoc.Clear();
            textEscuelaTel.Clear();
            textEscuelaCorreo.Clear();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
