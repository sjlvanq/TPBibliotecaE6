namespace TPBibliotecaE6
{
/*-----------------------------------------------------------------------------------------------
 * 
 * BELEN
 *  
 -----------------------------------------------------------------------------------------------*/
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
        /*-----------------------------------------------------------------------------------------------
         * 
         * PAULA
         *  
         -----------------------------------------------------------------------------------------------*/

        public int agregarPrestamo(Libro libro)
        {
            /*
             * 0: Prestamo agregado correctamente
             * 1: Libro inexistente
             * 2: Límite de préstamos alcanzado
             */
            if ( libro == null)
            {
                return 1;
            }
            if (prestamos.Count >= 3)
            {
                return 2;
            }
            prestamos.Add(libro);
            return 0;
        }
    }
}