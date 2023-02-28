using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace canculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number1,number2,result;
            string process;

            Console.WriteLine("enter number1");
            number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter number2");
            number2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("select the process(+,-,*,/):");
            process = Console.ReadLine();

            if (process == "+")
            {
                result = number1 + number2;
                Console.WriteLine("result: "+result);
            }
            if (process == "-")
            {
                result = number1 - number2;
                Console.WriteLine("result: " + result);
            }
            if (process == "*")
            {
                result = number1 * number2;
                Console.WriteLine("result: " + result);
            }
            if (process == "/" )
            {
                if (number2 == 0) 
                {
                    Console.WriteLine("undefined");
                }
                result = number1 / number2;
                Console.WriteLine("result: " + result);
            }

            Console.ReadLine();

        }
    }
}
