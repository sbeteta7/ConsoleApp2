using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Rectangulo
    {
        public Double Base { get; set; }
        public Double Altura { get; set; }

        public Coordenada coordenada01 { get; set; }

        public Coordenada coordenada02 { get; set; }

        public Coordenada coordenada03 { get; set; }

        public Coordenada coordenada04 { get; set; }


        public void CalcularBase()
        {
            Base = Math.Sqrt(Math.Pow(coordenada02.X-coordenada01.X, 2) + Math.Pow(coordenada02.Y-coordenada01.Y,2));
       
        }

        public void CalcularAltura()
        {
 

            Altura = Math.Sqrt(Math.Pow(coordenada04.X - coordenada01.X, 2) + Math.Pow(coordenada04.Y - coordenada01.Y, 2));


        }

        public double CalcularArea()
        {
            return Base * Altura;
        }

        public double CalcularPerimetro()
        {
            return (Base + Altura) *2 ;
        }





    }
}
