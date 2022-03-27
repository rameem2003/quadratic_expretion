using System;

namespace quadrantic_expretion
{
    class app
    {
        public static void Main()
        {
            Console.Write("Enter the value of a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value of b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value of c: ");
            int c = Convert.ToInt32(Console.ReadLine());

            int d = b * b - 4 * a * c;

            if(d >= 0)
            {
                double x1 = (-b + Math.Sqrt(d))/(2*a);
                double x2 = (-b - Math.Sqrt(d))/(2*a);

                Console.WriteLine("The value of x1 is {0}", x1);
                Console.WriteLine("The value of x2 is {0}", x2);
            }
            else if (d == 0)
            {
                double x = -b / 2 * a;
            }

            else
            {
                Console.WriteLine("Root are imeginary");
            }
        }
    }
}