using System;
using System.Collections.Generic;
using System.Linq;

namespace PiSeuratRandom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número para expresar el grado de aproximación a pi:");
            int radio = int.Parse(Console.ReadLine());

            int i = 0;
            List<ParNum> list1 = new List<ParNum>();
            List<ParNum> list2 = new List<ParNum>();
            Random random = new Random();

            while (i <= radio * (radio / 8))
            {
                int x = random.Next(0, radio);
                int y = random.Next(0, radio);
                ParNum punto = new ParNum(x, y);
                bool circulo = punto.Circulo(x, y, radio);
                list1.Add(punto);
                if (circulo == true)
                {
                    list2.Add(punto);
                }

                i++;
            }

            double square = list1.Count();
            double circle = list2.Count();

            double num = circle / square;

            double pi = 4 * num;

            Console.WriteLine($"Pi = {pi}");
        }

    }
    class ParNum
    {
        double i;
        double j;

        public ParNum(double num1, double num2)
        {
            i = num1;
            j = num2;
        }

        public bool Circulo(double num1, double num2, double radio)
        {
            double lado1 = num1 - radio;
            double lado2 = num2 - radio;
            double i = lado1 * lado1 + lado2 * lado2;
            double j = Math.Sqrt(i);
            if (j <= radio)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }    
}
