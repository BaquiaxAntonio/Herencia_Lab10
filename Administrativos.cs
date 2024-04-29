namespace Herencia_Lab10
{
    public class Administrativos:Persona
    {
        public string Profesion {  get; set; }
        public string NumIGS { get; set;}

        public Administrativos()
        {
            Profesion = string.Empty;
            NumIGS = string.Empty;
        }
    }
}
