using System;
using System.Collections.Generic;
using System.Text;

namespace TPBibliotecaE6
{
    internal class Lector
    {
        private string nombre;
        private string apellido;
        private string dni;
        private List<Libro> prestamos;
        public Lector(string nombre, string apellido, string dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.prestamos = new List<Libro>();
        }
        public string getDni()
        {
            return dni;
        }

        public int getPrestamosCantidad()
        {
            return prestamos.Count;
        }

        public bool agregarPrestamo(Libro libro)
        {
            bool resultado = false;
            if (libro != null && !prestamos.Contains(libro))
            {
                prestamos.Add(libro);
                resultado = true;
            }
            return resultado;
        }
    }
}
