using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fat32System
{
    public partial class eleccion : Form

    {
        private string direccion;
        public eleccion(string direccion)
        {
            InitializeComponent();
            this.direccion = direccion;
        }

        private void file_Click(object sender, EventArgs e)
        {
            Form crear = new crear(direccion);
            crear.Show();

            this.Hide();

        }

        private void eleccion_Load(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Folder_Click(object sender, EventArgs e)
        {
            Form crearCarpeta = new crearCarpeta(direccion);
            crearCarpeta.Show();
            this.Hide();
        }

        private void Folder_Click_1(object sender, EventArgs e)
        {
            Form frmCarpeta = new crearCarpeta(direccion);
            frmCarpeta.Show();
            this.Hide();
        }
    }
}
