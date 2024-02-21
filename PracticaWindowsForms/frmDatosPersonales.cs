using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaWindowsForms
{
    public partial class frmDatosPersonales : Form
    {
        public frmDatosPersonales()
        {
            InitializeComponent();
        }

        private void frmDatosPersonales_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {   
            bool hayVacio = false;

            if(txtApellido.Text == "")
            {
                txtApellido.BackColor = Color.Red;
                hayVacio = true;
            }                  
            if (txtNombre.Text == "")
            {
                txtNombre.BackColor = Color.Red;
                hayVacio = true;
            }             
            if (txtDireccion.Text == "")
            {
                txtDireccion.BackColor = Color.Red;
                hayVacio = true;
            }            
            if (txtEdad.Text == "" || !int.TryParse(txtEdad.Text, out _))
            {
                txtEdad.BackColor = Color.Red;
                hayVacio = true;
            }
            
            if (!hayVacio)
            {
                lvResultados.Items.Add("Apellido y Nombre: "+txtApellido.Text+" "+txtNombre.Text);
                lvResultados.Items.Add("Edad: "+txtEdad.Text);
                lvResultados.Items.Add("Direccion: "+txtDireccion.Text);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
