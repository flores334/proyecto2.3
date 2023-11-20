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
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            if(!string.IsNullOrEmpty (txbidmedico.Text));
                string.IsNullOrEmpty(txbpaciente.Text);
                string.IsNullOrEmpty(txbduipaciente.Text);
                string.IsNullOrEmpty(txbfechacita.Text);
            
            {
                button1.Enabled = true;
            }
        }

        private void txbpaciente_TextChanged(object sender, EventArgs e)
        {

        }
    }  
}