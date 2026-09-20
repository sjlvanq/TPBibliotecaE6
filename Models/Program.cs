using TPBibliotecaE6.Models;

namespace TPBibliotecaE6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca();

            cargarLibros(10);
            cargarLibros(2);
            biblioteca.listarLibros();
            biblioteca.eliminarLibro("Libro5");
            biblioteca.listarLibros();

            cargarLectores(3);
            cargarLectores(1);


            void cargarLibros(int cantidad)
            {
                bool pude;
                for (int i = 1; i <= cantidad; i++)
                {
                    pude = biblioteca.agregarLibro("Libro " + i, "Autor " + i, "Editorial " + i);
                    if (pude)
                        Console.WriteLine("Libro " + i + " agregado correctamente.");
                    else
                        Console.WriteLine("Libro " + i + " Ya existe en la biblioteca");
                }
            }

            void cargarLectores(int cantidad)
            {
                bool pude;
                for (int i = 1; i <= cantidad; i++)
                {
                    pude = biblioteca.altaLector("Lector " + i, "DNI " + i);
                    if (pude)
                        Console.WriteLine("Lector " + i + " dado de alta correctamente.");
                    else
                        Console.WriteLine("Lector " + i + " Ya existe en la biblioteca.");
                }
            }
        }
    }
}