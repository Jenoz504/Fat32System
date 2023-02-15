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
    public partial class frmConfiguracionOS : Form
    {
        //variable para lo limites
        LimiteRecursos limites = new LimiteRecursos();
        public frmConfiguracionOS()
        {
            InitializeComponent();
        }

        private void frmConfiguracionOS_Load(object sender, EventArgs e)
        {
           
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            //Se oculta, pero el proceso de verificacion sigue funcionando
            Hide();
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            long limiteCPU = (long)Convert.ToDecimal(txtLimiteCPU.Text);
            long limiteRAM = (long)Convert.ToDecimal(txtLimiteRAM.Text);
            //asignar nuevos valores
            limites.LimiteRam = limiteRAM;
            limites.LimiteTiempoCPU = limiteCPU;
        }
    }
}
