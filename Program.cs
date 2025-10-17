using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace Ejer1_sem9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo t=new Triangulo(); //instancia
            Cuadrado c=new Cuadrado();

            string continuar;
            int opcion2, opcion3;
            do
            {
                menu1();
                do
                {
                    Console.WriteLine("Ingrese una opción:");
                    opcion2 = int.Parse(Console.ReadLine());

                    if (opcion2 < 0 || opcion2 > 4)
                        Console.WriteLine("ERROR.Ingrese una opción valida.\n");
                    else break;
                } while(true);

                switch(opcion2)
                {
                    case 0:return;
                    case 1:
                        opcion3 = menu2();

                        switch(opcion3)
                        {
                            case 1:t.area(); break;
                            case 2:t.perimetro(); break;
                        }
                        break;
                    case 2:
                        opcion3 = menu2();

                        Console.WriteLine("\nIngrese lado:");
                        int lado=int.Parse(Console.ReadLine());
                        switch (opcion3)
                        {
                            case 1: c.area(lado); break;
                            case 2: c.perimetro(lado); break;
                        }
                        break;
                    case 3:break;
                    case 4:break;
                }
                do
                {
                    Console.WriteLine("¿Desea continuar? (s/n):");
                    continuar = Console.ReadLine();

                    if (continuar != "n" && continuar != "s")
                        Console.WriteLine("ERROR.Ingrese solo 's' o 'n'.\n");
                    else break;
                } while (true);
            }while (continuar=="s");
        }

        static void menu1()
        {
            Console.WriteLine("BIENVENIDOS AL SISTEMA DE CALCULO DE ÁREAS Y PERÍMETROS");
            Console.WriteLine("*            Menú de opciones       *");
            Console.WriteLine("*             1.Triángulo           *");
            Console.WriteLine("*             2.Cuadrado            *");
            Console.WriteLine("*             3.Rectángulo          *");
            Console.WriteLine("*             4.Trapecio            *");
            Console.WriteLine("*             0.Salir               *");
            Console.WriteLine("*************************************\n");
        }
        static int menu2()
        {
            Console.WriteLine("\n****Seleccione cálculo****");
            Console.WriteLine("*     1.Área     *");
            Console.WriteLine("*   2.Perímetro  *");
            Console.WriteLine("******************");

            Console.WriteLine("\nIngrese una opción:");
            int opcion=int.Parse(Console.ReadLine());

            return opcion;
        }
    }
}
