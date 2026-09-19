using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace TPBibliotecaE6
{
    internal class Biblioteca
    {
        private List<Libro> libros;
        private List<Lector> lectores;
        public Biblioteca() {
            this.libros = new List<Libro>();
            this.lectores = new List<Lector>();
        }
        public Libro buscarLibro(string titulo)
        {
            // Copiado literal del código en la bibliografía
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
            // Copiado literal del código en la bibliografía
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
        public bool eliminarLibro(string titulo)
        {
            // Copiado literal del código en la bibliografía
            bool resultado = false;
            Libro libro;
            libro = buscarLibro(titulo);
            if (libro != null)
            {
                libros.Remove(libro);
                resultado=true;
            }
            return resultado;
        }
        public void listarLibros()
        {
            foreach (var libro in libros)
                Console.WriteLine(libro);
        }

        public bool altaLector(string nombre, string apellido, string dni)
        {
            bool resultado = false;
            Lector lector;
            lector = buscarLector(dni);
            if (lector == null)
            {
                lector = new Lector(nombre, apellido, dni);
                lectores.Add(lector);
                resultado = true;
            }
            return resultado;
        }

        public Lector buscarLector(string dni)
        {
            // Sigue el ejemplo de buscarLibro
            Lector lectorBuscado = null;
            int i = 0;
            while (i < lectores.Count && !lectores[i].getDni().Equals(dni))
                i++;
            if (i != lectores.Count)
                lectorBuscado = lectores[i];
            return lectorBuscado;
        }

        public string prestarLibro(string dni, string titulo)
        {
            bool resultado = false;
            Lector lector;
            Libro libro;

            lector = buscarLector(dni);
            if (lector == null)
                return "LECTOR INEXISTENTE";

            if (lector.getPrestamosCantidad() >= 3)
                return "TOPE DE PRÉSTAMOS ALCANZADO";

            libro = buscarLibro(titulo);
            if (libro==null)
                return "LIBRO INEXISTENTE";

            resultado = lector.agregarPrestamo(libro);
            if (resultado)
                return "PRÉSTAMO REALIZADO CON ÉXITO";
            else
                return "NO SE PUDO REALIZAR EL PRÉSTAMO";
        }
    }
}
