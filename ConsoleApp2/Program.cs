using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int area = 0;
            int perimetro = 0;
         
            Rectangulo rectangulo = new Rectangulo();

            rectangulo.Base = 10;
            rectangulo.Altura = 20;
            
            area = rectangulo.CalcularArea();
            perimetro = rectangulo.CalcularPerimetro();

            Console.WriteLine("El área es:");
            Console.WriteLine(area);
            Console.WriteLine("El perímetro es:");
            Console.WriteLine(perimetro);
            */

            string nombreCompleto = "" ;

            Persona persona = new Persona
            {
                Nombres = "Sebastian",
                Apellidos = "Beteta",

            };
      
            persona.AsignarNombresCompletos();


            Console.WriteLine(persona.NombresCompletos);

            Console.Read();



        }
    }
}
