using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPS.Interfaz
{
    public partial class Menu : Form
    {
        RPaciente rpaciente = new RPaciente();
        RMedico rmedico = new RMedico();

        public Menu()
        {
            InitializeComponent();
        }

        private void medicoToolStripMenuItem_Click(object sender, EventArgs e)
        {     
            rpaciente.MdiParent = this;
            rpaciente.Show();
        }

        private void registroMédicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rmedico.MdiParent = this;
            rmedico.Show();
        }
    }
}
