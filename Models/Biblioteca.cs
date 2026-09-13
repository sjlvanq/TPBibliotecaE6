using System;
using System.Collections.Generic;
using System.Text;

namespace TPBibliotecaE6.Models
{
    public class Biblioteca
    {
        private List<Libro> libros;

        public Biblioteca()
        {
            this.libros = new List<Libro>();
        }
        public Libro agregarLibro(string titulo)
        {
            Libro libro = new Libro(titulo);
            this.libros.Add(libro);
            return libro;
        }
        public List<Libro> obtenerLibros()
        {
            return this.libros;
        }
    }
}
