using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace libro_con_autor
{
    public partial class Form1 : Form
    {
        private int libTotal = 0;
        private int libAutH = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblGenero_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            // Datos del libro
            int isbn = Convert.ToInt32(txtISBN.Text);
            string titulo = txtLibrTitulo.Text;
            string genero = cbLibrGenero.Text;

            // Datos del autor
            string autorNombre = txtAutNombre.Text;
            int documento = Convert.ToInt32(txtDocumento.Text);
            bool sexo = rbAutSexoM.Checked;
            DateTime fechaNacimiento = dtpFechaNac.Value;

            // Creacion de los objetos
            Autor autor = new Autor(autorNombre, documento, sexo, fechaNacimiento);
            Libro libro = new Libro(isbn, titulo, genero, autor);

            Console.WriteLine(libro.toString());
            Console.ReadLine();

            this.libTotal++;

            if (autor.pSexo)
            {
                this.libAutH++;
            }

            lblTotalH.Text = "" + this.libAutH;
            lblTotalF.Text = "" + (this.libTotal - this.libAutH);

            MessageBox.Show(libro.toString());

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
