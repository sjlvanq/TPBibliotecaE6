namespace TPBibliotecaE6.Models

{
    public class Biblioteca
    {
        private List<Libro> libros;             // Lista privada de libros de la biblioteca
        private List<Lector> lectores;           // Lista privada  de lectores registrados

        public Biblioteca()                     //Constructor biblioteca
        {
            this.libros = new List<Libro>();
            this.lectores = new List<Lector>();
        }
        private Libro buscarLibro(string titulo)    // Busca un libro por su título dentro de la lista de libros ejemplo "Lestat el vampiro"
        {
            Libro libroBuscado = null;              // Si no encuentra el libro, queda en null osea no encontro nada
            int i = 0;                              // Busca desde la posicion 0
            while (i < libros.Count && !libros[i].getTitulo().Equals(titulo))       // Recorre la lista mientras no llegue al final y el título no coincida
                i++;
            if (i != libros.Count)                   // Si no llegó al final de la lista, significa que encontró el libro   
                libroBuscado = libros[i];
            return libroBuscado;                    // Devuelve libro encontrado o null
        }
        public bool agregarLibro(string titulo, string autor, string editorial)         // Basicamente agrega un libro a la lista si no se encuentra registrado
        {
            bool resultado = false;                 // Tira false como primer valor, como q no se agrego
            Libro libro;
            libro = buscarLibro(titulo);             // Busca si ya existe un libro con ese título ejemplo "Lestat el vampiro"
            if (libro == null)                       // Si devuelve null, el libro no existe y se puede agregar. 
            {
                libro = new Libro(titulo, autor, editorial);        // Crea el objeto Libro Ej:"Lestat el vampiro", "Anne Rice", "Zeta".
                libros.Add(libro);                                  // Lo agrego  a la lista libros
                resultado = true;                                   // Tira Ok
            }
            return resultado;
        }
        public void listarLibros()                                 // Lista todos los libros de la lista Ej: "Lestat el vampiro", "El santuario".
        {
            foreach (var libro in libros)
                Console.WriteLine(libro);                          // Lo escribe por consola, me retorna return "Titulo: " + titulo + "Autor: " + autor + " Editorial:" + editorial; (viene de libro.cs)
        }
        public bool eliminarLibro(string titulo)                    // Elimina un libro de la lista si se encuentra registrado
        {
            bool resultado = false;
            Libro libro;
            libro = buscarLibro(titulo);                            //Busca el libro por titulo
            if (libro != null)
            {
                libros.Remove(libro);                               // Si lo encuentra, lo elimina de la lista y tira True
                resultado = true;
            }
            return resultado;
        }
        private Lector buscarLectorRegistrado(string dni)               // Busca un lector registrado por su DNI
        {
            Lector lectorBuscado = null;                                // Si no encuentra el lector, queda en null
            int i = 0;                                                  // Busca desde la posicion 0    
            while (i < lectores.Count && !lectores[i].getDni().Equals(dni))      // Recorre la lista mientras no llegue al final y el DNI no coincida
                i++;
            if (i != lectores.Count)                                        // Si no llego al final, encuetra al lector
                lectorBuscado = lectores[i];
            return lectorBuscado;                                           // Devuelve el lector encontrado o null
        }
        public bool altaLector(string nombre, string dni)                   //agrego lector si no esta registrado
        {
            bool resultado = false;                                         // inicial no agregado 
            Lector lector;                                                  // variable > lector
            lector = buscarLectorRegistrado(dni);                           // busco dni
            if (lector == null)                                             // si no existe puedo registrarlo
            {
                lector = new Lector(nombre, dni);                           // Creo Objeto Lector
                lectores.Add(lector);                                       // Lo agrego a la lista lectores
                resultado = true;                                           // tira ok
            }
            return resultado;
        }

        public string prestarLibro(string titulo, string dni)            // Realiza el préstamo de un libro a un lector
        {
            Libro libro;
            Lector lector;

            libro = buscarLibro(titulo);                                // Busca el libro por título
            lector = buscarLectorRegistrado(dni);                       // Busca el lector por DNI            

            if (libro == null)                                          // Si no encuentra el libro
            {
                return "LIBRO INEXISTENTE";
            }
            if (lector == null)                                         // Si no encuentra el lector
            {
                return "LECTOR INEXISTENTE";
            }
            if (lector.cantidadPrestamos() >= 3)                        // Si ya tiene 3 préstamos
            {
                return "TOPE DE PRESTAMO ALCANZADO";
            }
            lector.agregarPrestamo(libro);    // Agrega el libro a los préstamos del lector
            libros.Remove(libro);              // Lo quita de los libros de la biblioteca
            return "PRESTAMO EXITOSO";
        }
    }
}