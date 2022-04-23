using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathModelLib;

namespace MathModelConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Data data = new Data();
            Console.WriteLine(data.A0);
            Console.WriteLine(data.A1);
            Console.ReadLine();

            for(int i=1; i<16; i++)
            {
                Console.WriteLine(funk(i, data));

                
            }
            Console.ReadLine();
        }
        private static double funk(double x, Data data)
        {
            return data.A0 * Math.Pow(data.A1,x);
        }
    }
}
