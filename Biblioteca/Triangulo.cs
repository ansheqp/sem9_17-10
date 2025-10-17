using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Triangulo
    {
        public void area()
        {
            Console.Write("\nIngrese la base:");
            int b = int.Parse(Console.ReadLine());
            Console.Write("\nIngrese la altura:");
            int h = int.Parse(Console.ReadLine());

            Console.WriteLine("\nÁrea:" + (b - h) / 2);
        }

        public void perimetro()
        {
            Console.Write("\nIngrese lado1:");
                int lado1 = int.Parse(Console.ReadLine());
            Console.Write("\nIngrese lado2:");
            int lado2 = int.Parse(Console.ReadLine());
            Console.Write("\nIngrese lado3:");
            int lado3 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nPerímetro:" + (lado1+lado2+lado3));
        }
    }
}
