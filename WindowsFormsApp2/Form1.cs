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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string elemento = textNombre.Text;
            elementos.Items.Add(elemento);  
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboColorFavorito.Items.Add("Rojo");
            cboColorFavorito.Items.Add("Negro");
            cboColorFavorito.Items.Add("Rosa");
            cboColorFavorito.Items.Add("Azul");
        }

        private void btnVerPerfil_Click(object sender, EventArgs e)
        {
            string nombre = textNombre.Text;
            DateTime fecha = dtpFechaNacimiento.Value;
            string chocolate = ckbChocolate.Checked == true ? "Le gusta el chocolate" : "No le gusta el chocolate";
            string tipo;

            if (rbtMuggle.Checked == true)
                tipo = "Muggle";
            
            else if (rbtWizard.Checked == true)
                tipo = "Wizard";
            else
                tipo = "Squib";

            string colorFavorito = cboColorFavorito.SelectedItem.ToString();
            string numeroFavorito = nudNumeroFavorito.Value.ToString();

            string mensaje = "Fecha: "+fecha+" "+chocolate+" Tipo: " + tipo + " Numero Favorito: " + numeroFavorito;
            MessageBox.Show("Nombre: " + nombre+mensaje);
        }   
       
    }
}
