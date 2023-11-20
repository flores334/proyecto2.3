using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectParcial
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
            private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    // Si la tecla presionada no es un número, limpiar el TextBox
                    textBox1.Clear();

                    // Restablecer los elementos necesarios
                    // ...

                    // Indicar que se ha manejado el evento KeyPress
                    e.Handled = true;
                }
            }
            private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
            {
                if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    // Si la tecla presionada no es una letra, limpiar el TextBox
                    textBox2.Clear();

                    // Restablecer los elementos necesarios
                    // ...

                    // Indicar que se ha manejado el evento KeyPress
                    e.Handled = true;
                }
            }
            private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
            {
                if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    // Si la tecla presionada no es una letra, limpiar el TextBox
                    textBox3.Clear();

                    // Restablecer los elementos necesarios
                    // ...

                    // Indicar que se ha manejado el evento KeyPress
                    e.Handled = true;
                }
            }
            private void button1_Click(object sender, EventArgs e)
            {
                // Crear una instancia del formulario Form4
                Form4 form4 = new Form4();

                // Mostrar el formulario Form4
                form4.Show();

                // Opcionalmente, puedes ocultar el formulario actual si lo deseas
                this.Hide();
            }
        }
    }

