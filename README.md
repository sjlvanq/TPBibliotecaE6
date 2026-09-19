# TPBibliotecaE6

## Diagrama de clases UML

```mermaid
classDiagram
	class Biblioteca {
		-List~Libro~ libros
		-List~Lector~ lectores
		+Biblioteca()
		+Libro buscarLibro(string titulo)
		+bool agregarLibro(string titulo, string autor, string editorial)
		+bool eliminarLibro(string titulo)
		+void listarLibros()
		+bool altaLector(string nombre, string apellido, string dni)
		+Lector buscarLector(string dni)
		+string prestarLibro(string dni, string titulo)
	}

	class Libro {
		-string titulo
		-string autor
		-string editorial
		+Libro(string titulo, string autor, string editorial)
		+string getTitulo()
		+string ToString()
	}

	class Lector {
		-string nombre
		-string apellido
		-string dni
		-List~Libro~ prestamos
		+Lector(string nombre, string apellido, string dni)
		+string getDni()
		+int getPrestamosCantidad()
		+bool agregarPrestamo(Libro libro)
	}

	Biblioteca "1" *-- "0..*" Libro : libros
	Biblioteca "1" *-- "0..*" Lector : lectores
	Lector "0..*" --> "0..3" Libro : prestamos
```

- `Biblioteca` contiene una colección de `Libro` y otra de `Lector`.
- Un `Lector` puede tener hasta tres libros prestados, según la regla implementada en `prestarLibro`.
- Un `Libro` puede aparecer en los préstamos de varios lectores porque el código actual no controla la disponibilidad global del ejemplar.
