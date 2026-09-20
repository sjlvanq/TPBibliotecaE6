using System;
using System.Collections.Generic;
using System.Text;

namespace TPBibliotecaE6.Models
{
    internal class Biblioteca
    {
        private List<Libro> libros;
        private List<Lector> lectores;

        public Biblioteca()
        {
            this.libros = new List<Libro>();
            this.lectores = new List<Lector>();
        }

        private Libro buscarLibro(string titulo)
        {
            Libro libroBuscado = null;
            int i = 0;
            while (i < libros.Count && !libros[i].getTitulo().Equals(titulo))
                i++;
            if (i != libros.Count)
                libroBuscado = libros[i];
            return libroBuscado;
        }

        public bool agregarLibro(string titulo, string autor, string editorial)
        {
            bool resultado = false;
            Libro libro;
            libro = buscarLibro(titulo);
            if (libro == null)
            {
                libro = new Libro(titulo, autor, editorial);
                libros.Add(libro);
                resultado = true;
            }
            return resultado;
        }

        public void listarLibros()
        {
            foreach (var libro in libros)
                Console.WriteLine(libro);
        }

        public bool eliminarLibro(string titulo)
        {
            bool resultado = false;
            Libro libro;
            libro = buscarLibro(titulo);
            if (libro != null)
            {
                libros.Remove(libro);
                resultado = true;
            }
            return resultado;
        }

        private Lector buscarLector(string dni)
        {
            Lector lectorBuscado = null;
            int i = 0;
            while (i < lectores.Count && !lectores[i].getDni().Equals(dni))
                i++;
            if (i != lectores.Count)
                lectorBuscado = lectores[i];
            return lectorBuscado;
        }

        public bool altaLector(string nombre, string dni)
        {
            bool resultado = false;
            Lector lector = buscarLector(dni);
            if (lector == null)
            {
                lector = new Lector(nombre, dni);
                lectores.Add(lector);
                resultado = true;
            }
            return resultado;
        }

        public string prestarLibro(string titulo, string dni)
        {
            Lector lector = buscarLector(dni);
            if (lector == null)
            {
                return "LECTOR INEXISTENTE";
            }

            Libro libro = buscarLibro(titulo);
            if (libro == null)
            {
                return "LIBRO INEXISTENTE";
            }

            if (!lector.agregarPrestamo(libro))
            {
                return "TOPE DE PRESTAMO ALCANZADO";
            }

            libros.Remove(libro);
            return "PRESTAMO EXITOSO";
        }
    }
}
