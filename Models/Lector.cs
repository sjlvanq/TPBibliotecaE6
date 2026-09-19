using System.Collections.Generic;
namespace TPBibliotecaE6.Models
{ 
    public class Lector
    {
        private string nombre;
        private string dni;
        private List<Libro> prestamos;

        public Lector(string nombre, string dni)        // Contructor Lector
        {
            this.nombre = nombre;                       // guarda nombre, dni y lista vacia prestamos
            this.dni = dni;
            this.prestamos = new List<Libro>();
        }

        public string getDni()                           // Obtengo DNI del lector (privado) con metodo publico
        {
            return dni;
        }
        public bool agregarPrestamo(Libro libro)        // Agrega un libro si no alcanzó el máximo de préstamos
        {
            bool resultado = false;                    // Inicialmente no se agregó
            if (prestamos.Count < 3)                   // Si tiene menos de 3 préstamos
            {
                prestamos.Add(libro);                  // Lo agrego  a la lista prestamos
                resultado = true;                      // Me tira Ok
            }
            return resultado;                          // Devuelve true o false
        }
        public int cantidadPrestamos()                  // Devuelve la cantidad de libros en préstamo
        {
            return prestamos.Count;
        }
    }
}