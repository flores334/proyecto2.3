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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Recorre todos los controles del formulario
            foreach (Control control in this.Controls)
            {
                // Verifica si el control es un TextBox
                if (control is TextBox)
                {
                    TextBox textBox = control as TextBox;

                    // Elimina los espacios en blanco al inicio y al final
                    string campo = textBox.Text.Trim();

                    // Verifica si el campo está vacío
                    if (string.IsNullOrEmpty(campo))
                    {
                        MessageBox.Show("El campo " + textBox.Name + " no puede estar vacío");
                        return;
                    }
                }
            }
        }
    }
}
