

namespace licoreria
{
    class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int NumeroCedula { get; set; }
        public int Edad { get; set; }
        public int Telefono { get; set; }
        public Persona(string nombre, int numeroCedula, int edad, int telefono)
        {
            this.Nombre = nombre;
            this.NumeroCedula = numeroCedula;
            this.Edad = edad;
            this.Telefono = telefono;
        }


    }

}
