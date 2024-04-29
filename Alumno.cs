namespace Herencia_Lab10
{
    public class Alumno:Persona
    {
        public string Numcarnet { get; set; }
        public int[] Notas { get; set;}

        public Alumno()
        {
            Numcarnet = string.Empty;
            Notas = new int[0];

        }
    }


}
