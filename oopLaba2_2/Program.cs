using System;

namespace oopLaba2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("|x    |    y=f(x)|");
            double x=-6, b = 3;
            double y;
            double x=a;
            while(x<b)
            {
                y = Math.Pow(x,4) - 12*x+Math.Exp(x);
             
                x=x+0.75;
                Console.WriteLine( x +"\t"+ Math.Round(y));
            }
        }
    }
}
