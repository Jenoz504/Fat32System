using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Fat32System
{
    public partial class crear : Form
    {
        private string direccion;
        public crear(string direccion)
        {
            InitializeComponent();
            this.direccion = direccion;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void crear_Load(object sender, EventArgs e)
        {
            txtNombre.Select();
            lblDireccion.Text = direccion;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                TextWriter archivo;

                //crear un archivo de la extension querida
                archivo = new StreamWriter(direccion+txtNombre.Text+"."+txtExtension.Text);
                MessageBox.Show("Se ha creado " + txtNombre.Text + "." + txtExtension.Text);
                archivo.Close();
                this.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
           
        }
    }
}
