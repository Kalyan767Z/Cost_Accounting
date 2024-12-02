using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cost_calculator
{
    internal class Program
    {
        static void WriteCost(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Enter expenses for the " + (i + 1) + " day:\t");
                if (!double.TryParse(Console.ReadLine(), out double dayCost))
                {
                    Dekor();
                    Console.Write("Invalid cost - will be 0");
                    Dekor();
                    continue;
                }
                else if (dayCost < 0)
                {
                    Dekor();
                    Console.Write("Congratulations! You have earned " + -dayCost);
                    Dekor();
                    array[i] = dayCost;
                }
                else
                    array[i] = dayCost;
            }
        }

        static double SumCost (double[] days)
        {
            double result = 0;
            for (int i = 0; i < days.Length; i++)
            {
                result += days[i];
            }
            return result;
        }

        static void OutputCost(double sum , uint dayCount)
        {
            if (sum == 0)
            {
                Dekor();
                Console.Write("You have not lost anything");
                Dekor();
            }
            else if(sum<0)
            {
                Dekor();
                Console.Write("\nCongratulations!");
                Console.Write("\nYou earned per day in average: " + -(sum/dayCount));
                Console.Write("\nIn total, you earned: " + -sum);
                Dekor ();
            }
            else if (sum > 0)
            {
                Dekor();
                Console.Write("You spent per day in average: " + (sum / dayCount) + "\n");
                Console.Write("In total, you spent: " + sum + "\n");
                Dekor();
            }

        }
           

        static void Dekor()
        {
            Console.WriteLine();
            for (int i = 0; i < 120; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
        }


        static void Main(string[] args)
        {
            Console.Write("Enter the number of days:\t");
            if(!uint.TryParse(Console.ReadLine(), out uint dayCount) || dayCount<=0)
            {
                Dekor();
                Console.Write("\nInvalid count of days");
                Dekor();
                return;
            }
            Dekor();

            double[] dayList = new double[dayCount];

            WriteCost(dayList);
            
            double sum = SumCost(dayList);

            OutputCost(sum, dayCount);
        }
    }
}
