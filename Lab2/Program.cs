using Lab2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicoCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangulo rectangulo = new Rectangulo();
            

            Vertice v1 = new Vertice { x = 1, y = 2 };
            Vertice v2 = new Vertice { x = 1, y = 4 };
            Vertice v3 = new Vertice { x = 5, y = 4 };
            Vertice v4 = new Vertice { x = 5, y = 2 };

            rectangulo.v1 = v1;
            rectangulo.v2 = v2;
            rectangulo.v3 = v3;
            rectangulo.v4 = v4;
            Console.WriteLine("//////////////////////////////////////");
            Console.WriteLine("El Área es: "+rectangulo.GetArea());
            Console.WriteLine("El Perímetro es: "+rectangulo.GetPerimetro());
            Console.WriteLine("//////////////////////////////////////");

            Console.Read();



        }
    }
}