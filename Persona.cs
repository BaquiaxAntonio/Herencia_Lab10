namespace Herencia_Lab10
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set;}
        public string Direcion { get; set;}
        public DateTime FechaNacimiento { get; set;}
        public int Edad {  get; set;}

        public Persona()
        {
            Edad = 0;
            Nombre = string.Empty;
            Apellido = string.Empty;
            Direcion = string.Empty;
        }

        public int CalcularEdad()
        {
            int edad = 0;

            int mesNacimiento = FechaNacimiento.Month;
            int añoNacimiento = FechaNacimiento.Year;
            int diaNacimiento = FechaNacimiento.Day;

            int mesActual = DateTime.Now.Month;
            int añoActual = DateTime.Now.Year;
            int diaActual = DateTime.Now.Day;

            if (mesActual > mesNacimiento)
            {
                edad = (añoActual - añoNacimiento);
            }
            else if ((mesActual >= mesNacimiento) && (diaActual >= diaNacimiento))
            {
                edad = (añoActual - añoNacimiento);
            }
            else
            {
                edad = (añoActual - añoNacimiento) - 1;
            }
            return edad;
        }
    }
}
