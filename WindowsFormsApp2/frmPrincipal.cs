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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void perfilPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
                if (item.GetType() == typeof(Form1))
                {
                    MessageBox.Show("Ya existe una ventana Perfil abierta, termine de trabajar allí.");
                    return;
                }
                    
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void tsbPerfilPersona_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
                if (item.GetType() == typeof(Form1))
                    return;

            Form1 form1 = new Form1();
            form1.MdiParent = this;
            form1.Show();
        }
    }
}
