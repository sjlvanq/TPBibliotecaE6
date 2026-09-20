using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPBibliotecaE6.Models
{
    internal class Lector
    {
        private string nombre;
        private string dni;
        private List<Libro> prestamos;

        public Lector(string nombre, string dni)
        {
            this.nombre = nombre;
            this.dni = dni;
            this.prestamos = new List<Libro>();
        }

        public string getDni()
        {
            return dni;
        }

        public string getNombre()
        {
            return nombre;
        }

        public int cantidadPrestamos()
        {
            return prestamos.Count;
        }

        public bool agregarPrestamo(Libro libro)
        {
            if (prestamos.Count < 3)
            {
                prestamos.Add(libro);
                return true;
            }
            return false;
        }
    }
}
