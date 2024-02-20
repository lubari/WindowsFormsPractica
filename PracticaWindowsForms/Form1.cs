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
    public partial class frm : Form
    {
        public frm()
        {
            InitializeComponent();
        }

        private void frm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido a C#");
        }

        private void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Chau chau ...");
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se disparo el evento Click", "Atención");
            if (this.BackColor == Color.Beige)
              this.BackColor = Color.MistyRose;
            else
              this.BackColor = Color.Beige;

            if (textApellido.Text == "")
                textApellido.BackColor = Color.Red;
            else
                textApellido.BackColor = System.Drawing.SystemColors.Control;
        }

        private void frm_Click(object sender, EventArgs e)
        {
            //MouseEventArgs click = (MouseEventArgs)e;

            //if (click.Button == MouseButtons.Left)
                //MessageBox.Show("Presiono el botón Izquierdo", "Atencion");
            //else if (click.Button == MouseButtons.Right)
                //MessageBox.Show("Presiono el botón Derecho", "Atencion");
            //else if (click.Button == MouseButtons.Middle)
              //  MessageBox.Show("Presiono el botón del Medio", "Atencion");
        }

        private void lblName_MouseMove(object sender, MouseEventArgs e)
        {
            lblName.BackColor = Color.Thistle;
            lblName.Cursor = Cursors.Hand;
        }

        private void lblName_MouseLeave(object sender, EventArgs e)
        {   
            lblName.BackColor = System.Drawing.SystemColors.Control;
            lblName.Cursor = Cursor.Current;
        }

        private void textApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void tbName_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("Tiene " + tbName.Text.Length + "Caracteres");
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textApellido_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
