using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boolean_expressions
{
    internal class Program
    {

    static void SplitMyBill()
        {
            // Declaring variables
            float bill_total;
            int people;
            int tip_percentage;
            float percentage_decimal;
            float tip_total;
            float cost_per_person;

            Console.WriteLine("---Welcome to Split My Bill---");

            Console.WriteLine("What is the total bill?");

            bill_total = float.Parse(Console.ReadLine());

            Console.WriteLine("How many people are sharing?");

            people = int.Parse(Console.ReadLine());

            Console.WriteLine("What percentage tip would you like to leave?");

            tip_percentage = int.Parse(Console.ReadLine());


            percentage_decimal = tip_percentage / 100;

            tip_total = bill_total * percentage_decimal;

            bill_total = bill_total + tip_total;

            cost_per_person = bill_total / people;

            Console.WriteLine("Total bill including tip is £{0}", bill_total);

            Console.WriteLine("Total cost per person is £{0}", cost_per_person);

            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            SplitMyBill();

            Console.WriteLine(!true);

            float number_float = 14 / 3f;
            double number_double = 14 / 3d;

            Console.WriteLine(number_float);
            Console.WriteLine(number_double);

            Console.ReadLine();

            int number_modulo = 14 % 3;

            Console.WriteLine(number_modulo);

            Console.ReadLine();

            int counters_each = 14 / 3;

            int counters_remaining = 14 % 3;
            Console.WriteLine(counters_each);

            Console.WriteLine(counters_remaining);
            Console.ReadLine();


        }
    }
}
