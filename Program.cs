using TPBibliotecaE6.Models;

namespace TPBibliotecaE6
{
    internal static class Program
    {
        static void Main()
        {
            Biblioteca biblioteca = new Biblioteca();

            Console.WriteLine("TP Biblioteca");
            Console.WriteLine("Programa iniciado correctamente.\n");
            Console.WriteLine("------------------------------------------------------------------");
            bool resultado;
            //Agrego Libro
            resultado = biblioteca.agregarLibro("Lestat el vampiro","Anne Rice","Zeta");
            Console.WriteLine("Libro agregado: " + resultado);
            
            //Intento agregar mismo Libro
            resultado = biblioteca.agregarLibro("Lestat el vampiro","Anne Rice","Zeta");

            Console.WriteLine("Mismo libro agregado nuevamente: " + resultado);

            //Agrego Lector
            bool resultadoLector;
            resultadoLector = biblioteca.altaLector("Juan Manuel Rojas", "28860452");
            Console.WriteLine("Lector agregado: " + resultadoLector);

            //Intento agregar mismo Lector (DNI)
            resultadoLector = biblioteca.altaLector("Silvano", "28860452");

            Console.WriteLine("Lector con mismo DNI agregado nuevamente: " + resultadoLector);



            biblioteca.agregarLibro("Menoch el demonio", "Anne Rice", "Zeta");
            biblioteca.agregarLibro("Sangre y Oro", "Anne Rice", "Zeta");
            biblioteca.agregarLibro("El ladron de cuerpos", "Anne Rice", "Zeta");
            biblioteca.agregarLibro("Entrevista con el vampiro", "Anne Rice", "Zeta");
            biblioteca.agregarLibro("Pandora", "Anne Rice", "Zeta");
            biblioteca.agregarLibro("La comunidad de la sangre", "Anne Rice", "Zeta");


            Console.WriteLine("\nPréstamos");
            Console.WriteLine("------------------------------------------------------------------");
            // Primer préstamo PRESTAMO EXITOSO
            string prestamo;

            prestamo = biblioteca.prestarLibro("Lestat el vampiro", "28860452");
            Console.WriteLine("\nPréstamo 1: " + prestamo);

            // Segundo préstamo PRESTAMO EXITOSO
            prestamo = biblioteca.prestarLibro("Menoch el demonio", "28860452");
            Console.WriteLine("Préstamo 2: " + prestamo);

            // Tercer préstamo PRESTAMO EXITOSO
            prestamo = biblioteca.prestarLibro("Sangre y Oro", "28860452");
            Console.WriteLine("Préstamo 3: " + prestamo);

            // Intento cuarto préstamo TOPE DE PRESTAMO ALCANZADO
            prestamo = biblioteca.prestarLibro("El ladron de cuerpos", "28860452");
            Console.WriteLine("\nPréstamo 4: " + prestamo);

            //Prestamo Falla LIBRO INEXISTENTE
            prestamo = biblioteca.prestarLibro("La reyna de los condenados", "28860452");
            Console.WriteLine("\nPréstamo: " + prestamo);

            //Prestamo Falla LECTOR INEXISTENTE
            prestamo = biblioteca.prestarLibro("Entrevista con el vampiro", "66666666");
            Console.WriteLine("\nPréstamo: " + prestamo);

            Console.WriteLine("\nListar");
            Console.WriteLine("------------------------------------------------------------------");
            // Listo los libros disponibles
            Console.WriteLine("\nLIBROS DISPONIBLES:");
            biblioteca.listarLibros();

            // Elimino un libro
            resultado = biblioteca.eliminarLibro("El ladron de cuerpos");
            Console.WriteLine("\nLibro eliminado: " + resultado);

            // Vuelvo a listar para comprobar que se eliminó
            Console.WriteLine("\nLIBROS DESPUÉS DE ELIMINAR:");
            biblioteca.listarLibros();




            Console.ReadKey();
        }
    }
}