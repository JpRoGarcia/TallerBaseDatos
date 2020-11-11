using IPS.Modelo;
using IPS.Usuarios;
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
    public partial class REmpleado : Form
    {
        public REmpleado()
        {
            InitializeComponent();
       
        }

        private void btnRegE_Click(object sender, EventArgs e)
        {
            EmpleadoDao empleadoDao = new EmpleadoDao();
            int Cedula = Convert.ToInt32(txtCedE.Text);
            String Nombre = txtNomE.Text;
            String Apellido = txtApeE.Text;
            String Contraseña = txtConE.Text;
            String RContraseña = txtConRE.Text;

            if(Contraseña == RContraseña)
            {
                Empleado emp = new Empleado(Cedula, Nombre, Apellido, Contraseña);
                int reg = empleadoDao.RegistrarEmpleado(emp);

                if(reg == 1)
                {
                    MessageBox.Show("Se ingresaron correctamente los datos del cliente");
                }
                else
                {
                    MessageBox.Show("No se logro ingresar la información del cliente");
                }
            }
            else
            {
                //MessageBox.Show("Contraseña Invalida como Ud Pirobo");
            }
        }
    }
}
