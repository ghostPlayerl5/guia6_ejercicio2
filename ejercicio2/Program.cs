using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la cantidad de coordenadas que se le pidan (x,y)");
            int x;

            for (x = 1; x <= 3; x = x + 1)
            {
                Console.WriteLine("=================================");
                Console.WriteLine("ingrese el primer par de cordenadas");
                Console.WriteLine("ingrese la primera coordenada x");
                int x1= Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("ingrese la primera coordenada y");
                int y1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("=================================");
                Console.WriteLine("ingrese el segundo par de cordenadas");
                Console.WriteLine("ingrese la primera coordenada x");
                int x2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("ingrese la primera coordenada y");
                int y2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("=================================");
                Console.WriteLine("ingrese el tercer par de cordenadas");
                Console.WriteLine("ingrese la primera coordenada x");
                int x3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("ingrese la primera coordenada y");
                int y3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("=================================");

                Console.WriteLine("(" + x1 + "," + y1 + ")");
                if (x1 >= 0 && y1 >= 0)
                {
                    Console.WriteLine("este pertenece al cuadrante 2");
                }
                else if (x1 >= 0 && y1 <= 0)
                {
                    Console.WriteLine("este pertenece al cuadrante 3");
                }
                else if (x1 <= 0 && y1 >= 0)
                {
                    Console.WriteLine("este pertenece al cuadrante 1");
                }
                else if (x1 <= 0 && y1 <= 0)
                {
                    Console.WriteLine("este pertenece al cuadrante 4");
                }

                Console.WriteLine("(" + x2 + "," + y2 + ")");
                if (x2 >= 0 && y2 >= 0)
                {
                    Console.WriteLine("este pertenece al cuadrante 2");
                }
                else if (x2 >= 0 && y2 <= 0)
                {
                    Console.WriteLine("este pertenece al cuadrante 3");
                }
                else if (x2 <= 0 && y2 >= 0)
                {
                    Console.WriteLine("este pertenece al cuadrante 1");
                }
                else if (x2 <= 0 == y2 <= 0)
                {
                    Console.WriteLine("este pertenece al cuadrante 4");
                }

                Console.WriteLine("(" + x3 + "," + y3 + ")");
                if (x3 >= 0 && y3 >= 0)
                {
                    Console.WriteLine("este pertenece al cuadrante 2");
                }
                else if (x3 >= 0 && y3 <= 0)
                {
                    Console.WriteLine("este pertenece al cuadrante 3");
                }
                else if (x3 <= 0 && y3 >= 0)
                {
                    Console.WriteLine("este pertenece al cuadrante 1");
                }
                else if (x3 <= 0 && y3 <= 0)
                {
                    Console.WriteLine("este pertenece al cuadrante 4");
                }

             
            }
            Console.WriteLine("saliendo del programa......");
            Console.ReadKey();
        }
    }
}
