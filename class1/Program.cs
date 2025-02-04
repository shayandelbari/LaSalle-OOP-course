using System;

namespace class1
{
    class Program
    {
        static void Main(string[] args)
        {
            QuadraticEquation();
        }

        static void QuadraticEquation()
        {
            Console.WriteLine("Enter the value of a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the value of b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the value of c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            double d = b * b - 4 * a * c;
            double x1, x2;

            if (d > 0)
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("The roots are real and different.");
                Console.WriteLine("x1 = " + x1);
                Console.WriteLine("x2 = " + x2);
            }
            else if (d == 0)
            {
                x1 = -b / (2 * a);
                Console.WriteLine("The roots are real and same.");
                Console.WriteLine("x1 = x2 = " + x1);
            }
            else
            {
                Console.WriteLine("There is no answer.");
            }
        }


        static void Array() {
            Console.Write("Enter a number: ");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[size];

            for (int i = 0; i < array.Length; i++) {
                int num = Convert.ToInt32(Console.ReadLine());
                array[i] = 
            }
        }
    }
}