 public class Persona
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set; }

        public string Genero { get; set; }

        public int Edad { get; set; }
        // Metodo Constructor
        /*
        1. se llama igual que la clase
        2. no tiene retorno de datos 
        3. se utiliza para inicializar atributos de la clase
        4. se ejecuta cuando se construye un objeto de la clase
        5. No se puede llamar por medio de la sintaxis de punto 
        */
        public Persona(string nombres, string apellidos, string genero, int edad)
        {
            Nombres = nombres;
            Apellidos = apellidos;
            Genero = genero;
            Edad = edad;
        }
    }