using TPBibliotecaE6.Models;

namespace TPBibliotecaE6
{
    public partial class Form1 : Form
    {
        private readonly Biblioteca biblioteca;

        public Form1(Biblioteca biblioteca)
        {
            InitializeComponent();
            this.biblioteca = biblioteca;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.biblioteca.agregarLibro(textBox1.Text);
            label1.Text = "Libro agregado: " + textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            foreach (Libro libro in this.biblioteca.obtenerLibros())
            {
                label2.Text += libro.ToString() + "\n";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
