using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_7_15_ExperIT_GregNorris_Accumulation
{
    class Program
    {
        static void Main(string[] args)
        {
            double dailyDeposit = 35.00;
            double[] days = { 365, 731, 1826,3653 };
            double[] totals = { 0, 0,0, 0 };

            for (int y = 0; y < 4; y++)
                {
                    totals[y]= dailyDeposit * days[y];
                }
                                  
                     Console.WriteLine("The total deposits for 1 year "+ totals[0].ToString("C2"));
                     Console.WriteLine("The total deposits for 2 year " + totals[1].ToString("C2"));
                     Console.WriteLine("The total deposits for 5 year " + totals[2].ToString("C2"));
                     Console.WriteLine("The total deposits for 10 year " + totals[3].ToString("C2"));


            Console.ReadLine();

        }
    }
}
