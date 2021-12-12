using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS155Lab13PassingParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello. Lab 13 - passing parameters to methods, normal, optional, named, variable");
            Console.WriteLine("--------------------------------------------------------------------------------\n");

            ExamplesForLab7 example = new ExamplesForLab7();

            Console.Write("Calling multiply normally, multiply(5,6)           = ");
            Console.WriteLine(example.Multiply_OptionalParameters(5, 6));
            Console.Write("Calling multiply w/only b, multiply(b:7)           = ");
            Console.WriteLine(example.Multiply_OptionalParameters(b:7));
            Console.Write("Calling multiply w/only a, multiply(a:4)           = ");
            Console.WriteLine(example.Multiply_OptionalParameters(a:4));
            Console.Write("Calling multiply w/b & then a, multiply(b:11, a:2) = ");
            Console.WriteLine(example.Multiply_OptionalParameters(b:11, a:2));

            Console.WriteLine();
            Console.Write("Calling power normally, power(2.0,5.0)                   = ");
            Console.WriteLine(example.Power(2, 5));
            Console.Write("Calling power w/only b, power(exponent:7.0)              = ");
            Console.WriteLine(example.Power(exponent: 7));
            Console.Write("Calling power w/only a, power(number:4.0)                = ");
            Console.WriteLine(example.Power(number: 4));
            Console.Write("Calling power w/b & then a, power(exponent:10, number:2) = ");
            Console.WriteLine(example.Power(exponent: 10, number: 2));


            Console.ReadKey();
        }
    }

    class ExamplesForLab7       //Passing parameters to methods, optional, named, varaible # of parameters
    {
        int num;

        public int Num { get => num; set => num = value; }

        public ExamplesForLab7()
        {
            Num = 0;
        }

        public long Multiply_OptionalParameters(int a = 1, int b = 1)
        {
            return a * b;
        }


        public double Power(double number=0.0, double exponent=1.0)
        {
            return Math.Pow(number, exponent);
        }

        public double Mean(params int[] parameters)
        {
            double mean = 0.0;
            double sum = 0.0;
            int count = 0;

            foreach (int val in parameters)
            {
                sum += val;
                count++;
            }

            mean = sum / count;
            return mean;
        }
    }
}
