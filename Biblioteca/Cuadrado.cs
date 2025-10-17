using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Cuadrado
    {
        public void area (int lado) 
        {
            Console.WriteLine ("\nÁrea:"+lado*lado);
        }

        public void perimetro(int lado)
        {
            Console.WriteLine ("\nPerímetro:"+4*lado);
        }
    }
}
