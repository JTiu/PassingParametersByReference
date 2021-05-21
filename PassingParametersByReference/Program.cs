using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassingParametersByReference
{
    class Program
    {
        static void Main(string[] args)
        {
           UsingRefParameters();
            Console.ReadLine();
        }

        private static void UsingRefParameters()
        {
            int monthlyWage1 = 1234;
            int monthlyWage2 = 2000;
            int monthlyWage3 = 1900;
            int monthlyWage4 = 2001;

            int months1 = 12;
            int months2 = 8;
            int bonus = 300;

            int yearlyWageForEmployee1ByRef = CalculateYearlyWageByRef(monthlyWage1, months1, ref bonus);
            Console.WriteLine($"\nYearly wage for employee 1 (Bethany, 12 months):{yearlyWageForEmployee1ByRef}");
            Console.WriteLine($"Employee1 recieved a bonus of {bonus}");

            int yearlyWageForEmployee2ByRef = CalculateYearlyWageByRef(monthlyWage2, months2, ref bonus);
            Console.WriteLine($"\nYearly wage for employee 2 (John, 8 months):{yearlyWageForEmployee2ByRef}");
            Console.WriteLine($"Employee2 recieved a bonus of {bonus}");

            //int yearlyWageForEmployee3ByRef = CalculateYearlyWageByRef(monthlyWage3, months1, ref bonus);
            //Console.WriteLine($"\nYearly wage for employee 3 (Jaime, 12 months):{yearlyWageForEmployee3ByRef}");
            //Console.WriteLine($"Employee3 recieved a bonus of {bonus}");

            //int yearlyWageForEmployee4ByRef = CalculateYearlyWageByRef(monthlyWage4, months1, ref bonus);
            //Console.WriteLine($"\nYearly wage for employee 4 (Mija, 12 months):{yearlyWageForEmployee4ByRef}");
            //Console.WriteLine($"Employee4 recieved a bonus of {bonus}");
        }

        public static int CalculateYearlyWageByRef(int monthlyWage, int numberOfMonthsWorked, ref int bonus)
        {
            if (monthlyWage < 2000)
            {
                bonus *= 2;
                Console.WriteLine("Bonus doubled, Yes!");
            }
               
            Console.WriteLine($"The yearly wage is  {monthlyWage * numberOfMonthsWorked + bonus}");
            return monthlyWage * numberOfMonthsWorked + bonus;
        }

    }
}
