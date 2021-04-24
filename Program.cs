using System;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            double N = double.Parse(Console.ReadLine());
            double I = double.Parse(Console.ReadLine());
            while (true)
            {
                string sym = Console.ReadLine();
                if (sym == "+")
                {
                    double c = double.Parse(Console.ReadLine());
                    double d = double.Parse(Console.ReadLine());
                    N = N + c;
                    I = I + d;
                }
                else if (sym == "-")
                {
                    double c = double.Parse(Console.ReadLine());
                    double d = double.Parse(Console.ReadLine());
                    N = N - c;
                    I = I - d;
                }
                else if (sym == "*")
                {
                    double c = double.Parse(Console.ReadLine());
                    double d = double.Parse(Console.ReadLine());
                    double t = N;
                    N = N*c-I*d;
                    I = t*d + I*c;
                }
                else if (sym == "/")
                {
                    double c = double.Parse(Console.ReadLine());
                    double d = double.Parse(Console.ReadLine());
                    double t = N;
                    N = (N * c + I * d) / (Math.Pow(c, 2) + Math.Pow(d, 2));
                    I = (I * c - t * d) / (Math.Pow(c, 2) + Math.Pow(d, 2));
                }
                else if (sym == "^")
                {
                    double p = double.Parse(Console.ReadLine());
                    double t = N;
                    double s = I;
                    for (int y = 1;y<p;y++)
                    {
                        N = Math.Pow(t,2) - Math.Pow(s,2);
                        I = t*I + I*t;
                    }
                }
                else if(sym == "|")
                {   
                        N = Math.Sqrt(Math.Pow(N, 2) + Math.Pow(I, 2));
                        I = 0;
                }
                else
                {
                    break;
                }
                if (N<0 && I<0)
                {
                    N = Math.Abs(N);
                    I = Math.Abs(I);
                }
                if (I < 0) {
                    Console.WriteLine("{0}{1}i", N, I); }
                else {
                    Console.WriteLine("{0}+{1}i", N, I);
                }
            }
        }

     


    }
}
