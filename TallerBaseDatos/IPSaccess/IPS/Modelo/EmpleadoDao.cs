using IPS.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace IPS.Modelo
{
    public class EmpleadoDao
    {
        DataBase conectar = new DataBase();

        public int RegistrarEmpleado(Empleado empleado)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(conectar.conexion);

                String query = "INSERT INTO tbEmpleado (Cedula, Nombre, Apellido, Contraseña) VALUES ( "+
                    empleado.ECedula + ", '" + empleado.ENombre + "', '" +
                    empleado.EApellido + "', '" + empleado.EContraseña + "')";

                sqlConnection.Open();
                SqlCommand command = new SqlCommand(query, sqlConnection);
                int registros;

                registros = command.ExecuteNonQuery();

                sqlConnection.Close();

                return 1;

            }
            catch (SqlException xxx)
            {
                MessageBox.Show("Probando Vareta " + xxx.Message);
            }

            return 1;

        }
    }
}
