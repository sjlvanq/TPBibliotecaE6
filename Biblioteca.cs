/*-----------------------------------------------------------------------------------------------
* 
* SILVANO
*  
-----------------------------------------------------------------------------------------------*/
namespace TPBibliotecaE6

{
    internal class Biblioteca
    {
        private List<Libro> libros;
        private List<Lector> lectores;

        public Biblioteca()
        {
            this.libros = new List<Libro>();
            this.lectores = new List<Lector>();
        }
        /*-----------------------------------------------------------------------------------------------
        * 
        * JUAN
        *  
        -----------------------------------------------------------------------------------------------*/
        private Libro buscarLibro(string titulo)
        {
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
        /*-----------------------------------------------------------------------------------------------
        * 
        * BELEN
        *  
        -----------------------------------------------------------------------------------------------*/
        public void listarLibros()
        {
            foreach (var libro in libros)
                Console.WriteLine(libro);
        }
        public bool eliminarLibro(string titulo)
        {
            bool resultado = false;
            Libro libro;
            libro = buscarLibro(titulo);
            if (libro != null)
            {
                libros.Remove(libro);
                resultado = true;
            }
            return resultado;
        }
        /*-----------------------------------------------------------------------------------------------
        * 
        * JUAN
        *  
        -----------------------------------------------------------------------------------------------*/
        private Lector buscarLectorRegistrado(string dni)
        {
            Lector lectorBuscado = null;
            int i = 0;
            while (i < lectores.Count && !lectores[i].getDni().Equals(dni))
                i++;
            if (i != lectores.Count)
                lectorBuscado = lectores[i];
            return lectorBuscado;
        }
        public bool altaLector(string nombre, string dni)
        {
            bool resultado = false;
            Lector lector;
            lector = buscarLectorRegistrado(dni);
            if (lector == null)
            {
                lector = new Lector(nombre, dni);
                lectores.Add(lector);
                resultado = true;
            }
            return resultado;
        }
        /*-----------------------------------------------------------------------------------------------
         * 
         * PAULA
         *  
         -----------------------------------------------------------------------------------------------*/
        public string prestarLibro(string titulo, string dni)
        {
            Libro libro = buscarLibro(titulo);
            Lector lector = buscarLectorRegistrado(dni);

            if (lector == null)
            {
                return "LECTOR INEXISTENTE";
            }
            if (libro == null)
            {
                return "LIBRO INEXISTENTE";
            }
            if (!lector.agregarPrestamo(libro))
            {
                return "TOPE DE PRESTAMO ALCANZADO";
            }

            libros.Remove(libro);
            return "PRESTAMO EXITOSO";
        }

    }
}