namespace ClaseBase
{
    public class Disciplina
    {
        public int Dis_ID { get; set; }
        public string Dis_Nombre { get; set; }
        public string Dis_Descripcion { get; set; }

        public Disciplina() { }

        public Disciplina(int id, string nombre, string descripcion)
        {
            Dis_ID = id;
            Dis_Nombre = nombre;
            Dis_Descripcion = descripcion;
        }

        public override string ToString()
        {
            return this.Dis_Nombre;
        }
    }
}
