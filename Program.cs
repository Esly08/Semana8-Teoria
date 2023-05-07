using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

namespace Agenda
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Agenda agenda = new Agenda();

            agenda.nombre = "Introducción a la programación";
            agenda.salon = "T - 306";
            agenda.hora = "Martes y Jueves 8:00 - 9:50 am";
            agenda.catedratico = "Abraham Soto";

            Console.ReadKey();
            Console.WriteLine(agenda.Mostrarinfo());
        }
    }

    private int ZonaActual(double ZonaActual)
    {
        Random random = new Random();
        double valorAleatorio = random.NextDouble();
        return Convert.ToInt32(ZonaActual * (1 + valorAleatorio) * 100);
    }

    public class Agenda
    {
        public string? nombre;
        public string? salon;
        public string? hora;
        public string? catedratico;
    
    }

    public string Mostrarinfo(string nombre, string salon, int hora, string catedratico)
    {
        string datos = "Nombre del curso" + nombre;
        datos += "En el salón: " + salon;
        datos += "En horario matutino de: " + hora;
        datos += "Con el cátedrático: " + catedratico;
        return datos;
    }

}