using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace IPS
{
    public partial class IPS : Form
    {
        public IPS()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Interfaz.Menu menu = new Interfaz.Menu();
            menu.Show();
            this.Hide();
        }

        private void btnRegitro_Click(object sender, EventArgs e)
        {
            Interfaz.REmpleado empleado = new Interfaz.REmpleado();
            empleado.Show();
            this.Hide();
        }
    }
}
