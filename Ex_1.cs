//выяснить, имеет ли квадратное ур-ние
//действительные корни. Если корни есть, то найти их.
using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {

            double a, b, c;
            Console.WriteLine("Input 3 coefficients-->");
            a=Double.Parse(Console.ReadLine());
            b = Double.Parse(Console.ReadLine());
            c = Double.Parse(Console.ReadLine());
            double d = b * b - 4 * a * c;
            if (d < 0)
                Console.WriteLine("The roots of an equation are not a real\n");
            else
            {
                double x1 = (-b + Math.Sqrt(d)) / (2 * a); //вычисляем корни
                double x2 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("The roots of an equation are a real. They are:\nx1=" + x1 + "\tx2=" + x2 + "\n");
            }

        }
    }
}

     