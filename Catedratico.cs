namespace Herencia_Lab10
{
    public class Catedratico:Persona
    {
        public string Titulo { get; set; }
        public string NumColegeliago { get; set; }

        public Catedratico()
        {
            Titulo = string.Empty;
            NumColegeliago = string.Empty;
        }

    }
}
