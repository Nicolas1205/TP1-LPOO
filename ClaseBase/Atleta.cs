namespace ClaseBase
{

    public class Atleta
    {
        public int Atl_ID { get; set; }
        public string Atl_DNI { get; set; }
        public string Atl_Apellido { get; set; }
        public string Atl_Nombre { get; set; }
        public string Atl_Nacionalidad { get; set; }
        public string Atl_Entrenador { get; set; }
        public string Atl_Genero { get; set; } // Puede cambiar a char dependiendo de la necesidad
        public double Atl_Altura { get; set; }
        public double Atl_Peso { get; set; }
        public DateTime Atl_FechaNac { get; set; }
        public string Atl_Dirección { get; set; }
        public string Atl_Email { get; set; }

        // Constructor vacío
        public Atleta()
        {
        }

        // Constructor con argumentos
        public Atleta(int id, string dni, string apellido, string nombre, string nacionalidad,
                      string entrenador, string genero, double altura, double peso, DateTime fechaNac,
                      string dirección, string email)
        {
            Atl_ID = id;
            Atl_DNI = dni;
            Atl_Apellido = apellido;
            Atl_Nombre = nombre;
            Atl_Nacionalidad = nacionalidad;
            Atl_Entrenador = entrenador;
            Atl_Genero = genero;
            Atl_Altura = altura;
            Atl_Peso = peso;
            Atl_FechaNac = fechaNac;
            Atl_Dirección = dirección;
            Atl_Email = email;
        }
        public override string ToString()
        {
            return this.Atl_Nombre;

        }
    }

}