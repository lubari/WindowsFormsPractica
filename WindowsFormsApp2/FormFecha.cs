using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FormFecha : Form
    {
        public FormFecha()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnPrueba1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La fecha seleccionada es: " + dtpPrueba1.Value.ToString("dddd d 'de' MMMM 'del año' yyyy"));
        }
    }
}
