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
           UsingValueParameters();
            Console.ReadLine();
        }

        public static void UsingValueParameters ()
        {
            int monthlyWage1 = 1000;
            int monthlyWage2 = 1500;
            int monthlyWage3 = 1800;
            int monthlyWage4 = 2000;
            int monthlyWage5 = 2100;
            int months = 12;
            int bonus = 0;


            int yearlyWageForEmployee1 = CalculateYearlyWage(monthlyWage1, months, bonus);
            Console.WriteLine($"\nValue Parameters Method: Monthly wage: {monthlyWage1}: Yearly wage for employee 1, includes bonus of 9 if >2000/month:{yearlyWageForEmployee1}***");

            int yearlyWageForEmployee2 = CalculateYearlyWage(monthlyWage2, months, bonus);
            Console.WriteLine($"\nValue Parameters Method: Monthly wage: {monthlyWage2}: Yearly wage for employee 2, includes bonus of 9 if >2000/month:{yearlyWageForEmployee2}***");

            int yearlyWageForEmployee3 = CalculateYearlyWage(monthlyWage3, months, bonus);
            Console.WriteLine($"\nValue Parameters Method: Monthly wage: {monthlyWage3}: Yearly wage for employee 3, includes bonus of 9 if >2000/month:{yearlyWageForEmployee3}***");

            int yearlyWageForEmployee4 = CalculateYearlyWage(monthlyWage4, months, bonus);
            Console.WriteLine($"\nValue Parameters Method: Monthly wage: {monthlyWage4}: Yearly wage for employee 4, includes bonus of 9 if >2000/month:{yearlyWageForEmployee4}***");

            int yearlyWageForEmployee5 = CalculateYearlyWage(monthlyWage5, months, bonus);
            Console.WriteLine($"\nValue Parameters Method: Monthly wage: {monthlyWage5}: Yearly wage for employee 5, includes bonus of 9 if >2000/month:{yearlyWageForEmployee5}***");
        }

        public static int CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked, int bonus)
        {
            if (monthlyWage < 2000)
                bonus = 9;

            Console.WriteLine($"This 'CalculateYearlyWage' Method checks the bonus qualification: The yearly wage is : {monthlyWage * numberOfMonthsWorked + bonus}. The employee got a bonus of:{bonus} if salary was >2000/month***");
            return monthlyWage * numberOfMonthsWorked + bonus;
        }

    }
}
