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
            this.direccion=direccion;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form crear = new crear(direccion);  
            crear.ShowDialog();

        }
    }
}
