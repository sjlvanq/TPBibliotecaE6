/*-----------------------------------------------------------------------------------------------
* 
* SILVANO
*  
-----------------------------------------------------------------------------------------------*/

using TPBibliotecaE6.Models;
namespace TPBibliotecaE6
{
    internal static class Program
    {
        static void Main()
        {
            Biblioteca biblioteca = new Biblioteca();
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("* TP BIBLIOTECA                                                  *");
            Console.WriteLine("* Programa iniciado correctamente.                               *");
            Console.WriteLine("* Casos de Prueba.                                               *");
            Console.WriteLine("------------------------------------------------------------------");
            bool resultado;

            Console.WriteLine("\nINTENTOS DE AGREGADO LIBRO");
            Console.WriteLine("------------------------------------------------------------------");
            //Agrego Libro nuevo
            resultado = biblioteca.agregarLibro("Lestat el vampiro","Anne Rice","Zeta");
            Console.WriteLine("Libro agregado: " + resultado);
            
            //Intento agregar mismo Libro
            resultado = biblioteca.agregarLibro("Lestat el vampiro","Anne Rice","Zeta");
            Console.WriteLine("Mismo libro agregado nuevamente: " + resultado);

            Console.WriteLine("\nINTENTOS DE AGREGADO LECTOR");
            Console.WriteLine("------------------------------------------------------------------");
            //Agrego Lector
            resultado = biblioteca.altaLector("Juan Manuel Rojas", "28860452");
            Console.WriteLine("Lector agregado: " + resultado);

            //Intento agregar mismo Lector (DNI)
            resultado = biblioteca.altaLector("Silvano", "28860452");
            Console.WriteLine("Lector con mismo DNI agregado nuevamente: " + resultado);
            
            //Agrego libros
            biblioteca.agregarLibro("Menoch el demonio", "Anne Rice", "Zeta");
            biblioteca.agregarLibro("Sangre y Oro", "Anne Rice", "Zeta");
            biblioteca.agregarLibro("El ladrón de cuerpos", "Anne Rice", "Zeta");
            biblioteca.agregarLibro("Entrevista con el vampiro", "Anne Rice", "Zeta");
            biblioteca.agregarLibro("Pandora", "Anne Rice", "Zeta");
            biblioteca.agregarLibro("La comunidad de la sangre", "Anne Rice", "Zeta");

            Console.WriteLine("\nINTENTOS DE PRÉSTAMOS");
            Console.WriteLine("------------------------------------------------------------------");
            string prestamo;

            //Préstamo Falla LIBRO INEXISTENTE
            prestamo = biblioteca.prestarLibro("La reina de los condenados", "28860452");
            Console.WriteLine("Intento de Préstamo: " + prestamo);

            //Préstamo Falla LECTOR INEXISTENTE
            prestamo = biblioteca.prestarLibro("Entrevista con el vampiro", "66666666");
            Console.WriteLine("\nIntento de Préstamo: " + prestamo);

            // Primer préstamo PRÉSTAMO EXITOSO
            prestamo = biblioteca.prestarLibro("Lestat el vampiro", "28860452");
            Console.WriteLine("\nIntento de Préstamo 1: " + prestamo);

            // Segundo préstamo PRÉSTAMO EXITOSO
            prestamo = biblioteca.prestarLibro("Menoch el demonio", "28860452");
            Console.WriteLine("Intento de Préstamo 2: " + prestamo);

            // Tercer préstamo PRÉSTAMO EXITOSO
            prestamo = biblioteca.prestarLibro("Sangre y Oro", "28860452");
            Console.WriteLine("Intento de Préstamo 3: " + prestamo);

            // Intento cuarto préstamo TOPE DE PRÉSTAMO ALCANZADO
            prestamo = biblioteca.prestarLibro("El ladrón de cuerpos", "28860452");
            Console.WriteLine("\nIntento de Préstamo 4: " + prestamo);

            // Listo los libros disponibles
            Console.WriteLine("\nLISTAR LIBROS DISPONIBLES:");
            Console.WriteLine("-----------------------");
            biblioteca.listarLibros();

            // Elimino un libro
            Console.WriteLine("\nLIBRO ELIMINADO:");
            Console.WriteLine("-----------------------");
            resultado = biblioteca.eliminarLibro("El ladrón de cuerpos");
            Console.WriteLine("Título: El ladrón de cuerpos");
            Console.WriteLine("Libro eliminado: " + resultado);



            // Vuelvo a listar para comprobar que se eliminó
            Console.WriteLine("\nLISTAR LIBROS DESPUÉS DE ELIMINAR:");
            Console.WriteLine("-----------------------");
            biblioteca.listarLibros();

            Console.ReadKey();
        }
    }
}