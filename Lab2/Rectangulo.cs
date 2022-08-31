using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Rectangulo
    {
        public Vertice v1 { get; set; }
        public Vertice v2 { get; set; }
        public Vertice v3 { get; set; }
        public Vertice v4 { get; set; }
        //public int x1 { get; set; }
        //public int y1 { get; set; }
        //public int x2 { get; set; }
        //public int y2 { get; set; }
        //public int x3 { get; set; }
        //public int y3 { get; set; }
        //public int x4 { get; set; }
        //public int y4 { get; set; }

        public double GetArea()
        {
            double base1 = Math.Sqrt(Math.Pow(v4.x - v1.x,2) + (Math.Pow(v4.y - v1.y,2)));
            double altura = Math.Sqrt(Math.Pow(v2.x - v1.x, 2) + (Math.Pow(v2.y - v1.y, 2)));
            return base1 * altura;
        }
        public double GetPerimetro()
        {
            double base1 = Math.Sqrt(Math.Pow(v4.x - v1.x, 2) + (Math.Pow(v4.y - v1.y, 2)));
            double altura = Math.Sqrt(Math.Pow(v2.x - v1.x, 2) + (Math.Pow(v2.y - v1.y, 2)));
            return (base1 + altura)*2;
        }
    }

    
}
