using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libro_con_autor
{
    class Libro
    {
        private int isbn;
        private String titulo;
        private String genero;
        private Autor autor;

        public Libro()
        {
            pIsbn = 0;
            pTitulo = "";
            pGenero = "";
            pAutor = new Autor();
        }

        public Libro(int isbn, String titulo, String genero, Autor autor)
        {
            this.isbn = isbn;
            this.titulo = titulo;
            this.genero = genero;
            this.autor = autor;
        }

        public int pIsbn {
            set { this.isbn = value; }
            get { return this.isbn; }
        }
        public String pTitulo {
            set { this.titulo = value; }
            get { return this.titulo; }
        }
        public String pGenero {
            set { this.genero = value; }
            get { return this.genero; }
        }
        public Autor pAutor {
            set { this.autor = value; }
            get { return this.autor; }
        }

        public String toString()
        {
            return "Titulo: " + pTitulo +
                   "\nGenero: " + pGenero +
                   "\nAutor: " + pAutor.toString() +
                   "\nISBN: " + pIsbn;
        }
    }
}
