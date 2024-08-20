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

            Coordenada coordenada01 = new Coordenada { X = 0, Y  = 8};
            Coordenada coordenada02 = new Coordenada { X = 4, Y = 8 };
            Coordenada coordenada03 = new Coordenada { X = 4, Y = 0 };
            Coordenada coordenada04 = new Coordenada { X = 0, Y = 0 };

            Rectangulo rectangulo = new Rectangulo
            {
                coordenada01 = coordenada01,

                coordenada02 = coordenada02,

                coordenada03 = coordenada03,

                coordenada04 = coordenada04
            
            };

            rectangulo.CalcularBase();
            rectangulo.CalcularAltura();


            Console.WriteLine("El área es: " + rectangulo.CalcularArea());
            Console.WriteLine("El perímetro es :" + rectangulo.CalcularPerimetro());

            Console.Read();


        }
    }
}
