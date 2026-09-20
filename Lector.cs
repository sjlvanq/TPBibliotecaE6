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