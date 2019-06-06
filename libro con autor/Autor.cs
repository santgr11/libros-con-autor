using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libro_con_autor
{
    class Autor
    {
        string nombre;
        int documento;
        bool sexo; // True hombre, false mujer
        DateTime fechaNacimiento;

        public Autor()
        {
            pNombre = "";
            pDocumento = 0;
            pSexo = true;
            pFechaNacimiento = DateTime.Today;
        }

        public Autor(string nombre, int documento, bool sexo, DateTime fechaNacimiento)
        {
            pNombre = nombre;
            pDocumento = documento;
            pSexo = sexo;
            pFechaNacimiento = fechaNacimiento;
        }

        public string pNombre {
            set { this.nombre = value; }
            get { return this.nombre; }
        }
        public int pDocumento {
            set { this.documento = value; }
            get { return this.documento; }
        }
        public bool pSexo {
            set { this.sexo = value; }
            get { return this.sexo; }
        }
        public DateTime pFechaNacimiento {
            set { this.fechaNacimiento = value; }
            get { return this.fechaNacimiento; }
        }

        public String sexoString()
        {
            if(pSexo)
            {
                return "Hombre";
            } else
            {
                return "Mujer";
            }
        }

        public String toString()
        {
            return pNombre + ", " + pDocumento + ", " + pFechaNacimiento.ToShortDateString() + ", " + sexoString();
        }

    }
}

