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

            Console.WriteLine("--------------------------------");

            cargarLectores(10);
            cargarLectores(2);
            //biblioteca.listarLectores(); // No requerido; no implementado
            prestarLibro("DNI0", "LIBRO_INEXISTENTE"); // Output esperado: "LIBRO INEXISTENTE"
            prestarLibro("DNI_LECTOR_INEXISTENTE", "Libro 1"); // Output esperado: "LECTOR INEXISTENTE"
            prestarLibro("DNI0", "Libro 1"); // Output esperado: "PRESTAMO REALIZADO CON ÉXITO"
            // Libro 2 eliminado en línea 15
            prestarLibro("DNI0", "Libro 3"); // Output esperado: "PRESTAMO REALIZADO CON ÉXITO"
            prestarLibro("DNI0", "Libro 4"); // Output esperado: "PRESTAMO REALIZADO CON ÉXITO"
            prestarLibro("DNI0", "Libro 5"); // Output esperado: "TOPE DE PRÉSTAMOS ALCANZADO"

            void cargarLibros(int cantidad)
            {
                // Copiado literal de la bibliografía
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

            void cargarLectores(int cantidad)
            {
                bool pude;
                for (int i = 0; i < cantidad; i++)
                {
                    pude = biblioteca.altaLector("Nombre " + i, "Apellido " + i, "DNI" + i);
                    if (pude)
                        Console.WriteLine("lector " + i + " agregado correctamente.");
                    else
                        Console.WriteLine("lector " + i + " ya existe en la biblioteca.");
                }
            }

            void prestarLibro(string dni, string titulo)
            {
                string resultado;
                resultado = biblioteca.prestarLibro(dni, titulo);
                Console.WriteLine(resultado);
            }
        }
    }
}