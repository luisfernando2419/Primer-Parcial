namespace PrimerParcial
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Definir las películas en la base de conocimientos
            List<Pelicula> peliculas = new List<Pelicula>
            {
                new Pelicula("John Wick", "Acción", "Larga"),
                new Pelicula("Matrix", "Acción", "Media"),
                new Pelicula("El padrino", "Drama", "Larga"),
                new Pelicula("Interestelar", "Drama", "Media"),
                new Pelicula("Intensamente", "Animación", "Media"),
                new Pelicula("Toy Story", "Animación", "Corta"),
                new Pelicula("La isla sisniestra", "Suspenso", "Media"),
                new Pelicula("No respires", "Suspenso", "Corta"),
                new Pelicula("Siniestro", "Horror", "Larga"),
                new Pelicula("La La Land", "Musical", "Larga")
            };

            // Preguntar al usuario por sus preferencias
            Console.WriteLine("Bienvenido al sistema de recomendación de películas.");
            Console.Write("¿Qué género de películas prefieres? (Acción, Drama, Animación, Suspenso, Horror, Musical): ");
            string genero = Console.ReadLine().Trim();

            Console.Write("¿Qué duración prefieres? (Corta, Media, Larga): ");
            string duracion = Console.ReadLine().Trim();

            // Buscar una película que coincida con las preferencias del usuario
            Pelicula recomendacion = peliculas.Find(p => p.Genero.Equals(genero, StringComparison.OrdinalIgnoreCase)
                                                     && p.Duracion.Equals(duracion, StringComparison.OrdinalIgnoreCase));

            if (recomendacion != null)
            {
                Console.WriteLine($"\nTe recomendamos ver: {recomendacion.Nombre}");
            }
            else
            {
                Console.WriteLine("\nLo siento, no encontramos una película que coincida con tus preferencias.");
            }
        }
    }

    public class Pelicula
    {
        public string Nombre { get; set; }
        public string Genero { get; set; }
        public string Duracion { get; set; }

        public Pelicula(string nombre, string genero, string duracion)
        {
            Nombre = nombre;
            Genero = genero;
            Duracion = duracion;
        }
    }
}
