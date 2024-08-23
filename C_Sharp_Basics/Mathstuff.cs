using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Basics
{
    internal class Mathstuff
    {
        public static void Math_Addition()
        {
            Console.WriteLine("Welcome to the greatest calulator ever");
            Console.WriteLine("Lets try doing Addition and adding some numbers together.");
            Console.Write("First, enter the 1st number to add: ");
            double num_1 = double.Parse(Console.ReadLine());
            Console.Write("Then, enter the 2nd number to add: ");
            double num_2 = double.Parse(Console.ReadLine());
            double the_sum = num_1 + num_2;
            Console.WriteLine($"As {num_1} + {num_2} = {the_sum}");
            Console.WriteLine($"The sum would be: {the_sum}");
        }
        public static void Math_Subtraction()
        {
            Console.WriteLine("With Addition out of the way, lets work on Subtraction.");
            Console.Write("First, enter the 1st number to subtract: ");
            double num_3 = double.Parse(Console.ReadLine());
            Console.Write("Then, enter the 2nd number to subtract: ");
            double num_4 = double.Parse(Console.ReadLine());
            double the_sum = num_3 - num_4;
            Console.WriteLine($"As {num_3} - {num_4} = {the_sum}");
            Console.WriteLine($"The sum would be: {the_sum}");
        }
        public static void Math_Multiplication()
        {
            Console.WriteLine("As we wrap up Subtraction, lets go into Multplication.");
            Console.Write("First, enter the 1st number to multiply: ");
            double num_5 = double.Parse(Console.ReadLine());
            Console.Write("Then, enter the 2nd number to multiply: ");
            double num_6 = double.Parse(Console.ReadLine());
            double the_sum = num_5 * num_6;
            Console.WriteLine($"As {num_5} * {num_6} = {the_sum}");
            Console.WriteLine($"The sum would be: {the_sum}");
        }
        public static void Math_Division()
        {
            Console.WriteLine("Now that we are done with Multplication, lets try division.");
            Console.Write("First, enter the 1st number to divide: ");
            double num_7 = double.Parse(Console.ReadLine());
            Console.Write("Then, enter the 2nd number to divide: ");
            double num_8 = double.Parse(Console.ReadLine());
            double the_sum = num_7 / num_8;
            Console.WriteLine($"As {num_7} / {num_8} = {the_sum}");
            Console.WriteLine($"The sum would be: {the_sum}");
        }

        public static void Do_Stuff()
        {
            Console.WriteLine("_");
        }
    }
}
