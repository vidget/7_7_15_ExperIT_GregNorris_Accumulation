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


            //This program calculates the totals if a person deposits $35.00 per day of the course of 1, 2, 5, 10 years starting in Jan 2015

            //dailyDeposit holds the $35.00 amount

            decimal dailyDeposit = 35.00M;

            

            //The array days contains the total number of days in each of the 4 different years 1st year = 365 2nd year = 731 the total for 2 years accounting for leapyear in 2016
            //5 years total days = 1826 days , 10 years = 3653 acconting for 3 days for leapyears (2016,2020,2024)
            decimal[] days = {365,731,1826,3653};
            //an array created to hold the total values once calculated
            decimal[] totals = {0,0,0,0};

          
            //I used a for loop to cycle through the four different values held in the days and multiplied those times the dailyDepost($35.00) and put that value into the array called totals.
            for (int y = 0; y < 4; y++)
                {
                    totals[y]= dailyDeposit * days[y];
                }


            //totals[0] = dailyDeposit * days[0];
            //totals[1] = dailyDeposit * days[1];
            //totals[2] = dailyDeposit * days[2];
            //totals[3] = dailyDeposit * days[3];
           
                                  
            //Prints out the values from the each total in the totals[] array
                     Console.WriteLine("The total deposits for 1 year "+ totals[0].ToString("C2"));
                     Console.WriteLine("The total deposits for 2 years " + totals[1].ToString("C2"));
                     Console.WriteLine("The total deposits for 5 years " + totals[2].ToString("C2"));
                     Console.WriteLine("The total deposits for 10 years " + totals[3].ToString("C2"));

                  

            Console.ReadLine();

        } 
    }
}
