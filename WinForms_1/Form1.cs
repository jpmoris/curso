using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string elem = txtNombre.Text;
            lwElementos.Items.Add(elem);
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVerPerfil_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            DateTime fecha = dtpFechaNacimiento.Value;
            string chocolate = ckbChocolate.Checked == true ? "Le gusta el chocolate" : "No le gusta el chocolate";
            string tipo;
            if (radioMuggle.Checked == true)
            {
                tipo = "Muggle";
            }
            else if (radioWizard.Checked == true)
            {
                tipo = "Wizard";
            }
            else tipo = radioSquize.Text;
            // operador ternario
            MessageBox.Show("Nombre: " + nombre + " | Fecha de Nacimiento: " + fecha + "\n"+ chocolate + " y es " + tipo);
            
        }
    }
}
