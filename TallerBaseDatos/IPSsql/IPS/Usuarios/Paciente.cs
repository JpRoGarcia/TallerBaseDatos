using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPS.Usuarios
{
    public class Paciente
    {
        private String pNumeroID;
        private String pNombre;
        private String pApellido;
        private String pFechaNacimiento;
        private String pDireccion;
        private String pTelefono;
        private String pEmail;
        private String pRegistro;

        public Paciente(string pNumeroID, string pNombre, string pApellido, string pFechaNacimiento, string pDireccion, string pTelefono, string pEmail, string pRegistro)
        {
            this.pNumeroID = pNumeroID;
            this.pNombre = pNombre;
            this.pApellido = pApellido;
            this.pFechaNacimiento = pFechaNacimiento;
            this.pDireccion = pDireccion;
            this.pTelefono = pTelefono;
            this.pEmail = pEmail;
            this.pRegistro = pRegistro;
        }

        public string PNumeroID { get => pNumeroID; set => pNumeroID = value; }
        public string PNombre { get => pNombre; set => pNombre = value; }
        public string PApellido { get => pApellido; set => pApellido = value; }
        public string PFechaNacimiento { get => pFechaNacimiento; set => pFechaNacimiento = value; }
        public string PDireccion { get => pDireccion; set => pDireccion = value; }
        public string PTelefono { get => pTelefono; set => pTelefono = value; }
        public string PEmail { get => pEmail; set => pEmail = value; }
        public string PRegistro { get => pRegistro; set => pRegistro = value; }
    }


}
