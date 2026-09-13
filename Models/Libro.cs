using System;
using System.Collections.Generic;
using System.Text;

namespace TPBibliotecaE6.Models
{
    public class Libro
    {
        //private int id;
        private string titulo;
        public Libro(string titulo) {
            this.titulo = titulo;
        }
        public override string ToString()
        {
            return this.titulo;
        }
    }
}
