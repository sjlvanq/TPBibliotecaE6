using System;
using System.Collections.Generic;
using System.Text;

namespace TPBibliotecaE6
{
    internal class Test
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca();
            cargarLibros(10);
            cargarLibros(2);
            biblioteca.listarLibros();
            biblioteca.eliminarLibro("Libro 2");
            biblioteca.listarLibros();
            void cargarLibros(int cantidad)
            {
                bool pude;
                for (int i = 0; i < cantidad; i++)
                {
                    pude = biblioteca.agregarLibro("Libro " + i, "Autor " + i, "Editorial " + i);
                    if (pude)
                        Console.WriteLine("libro " + i + " agregado correctamente.");
                    else
                        Console.WriteLine("libro " + i + " ya existe en la biblioteca.");
                }
            }
        }
    }
}
