using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Fat32System
{
    public partial class crearCarpeta : Form
    {
        private string direccion;
        public crearCarpeta(string direccion)
        {
            InitializeComponent();
            this.direccion = direccion;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            string carpeta = Application.StartupPath + nombre + @"\";

            try
            {
                if (Directory.Exists(carpeta))
                {
                    MessageBox.Show("Carpeta ya existe");
                }
                else
                {
                    MessageBox.Show("Carpeta no existe, Se esta creando ..... ");
                    Directory.CreateDirectory(carpeta);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void crearCarpeta_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            string carpeta = Application.StartupPath + nombre + @"\";

            try
            {
                if (Directory.Exists(carpeta))
                {
                    MessageBox.Show("Carpeta ya existe");
                }
                else
                {
                    MessageBox.Show("Carpeta no existe, Se esta creando ..... ");
                    Directory.CreateDirectory(carpeta);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }
    }
}
