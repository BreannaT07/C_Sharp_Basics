﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Basics
{
    internal class Mathstuff
    {
        public static void Do_Stuff()
        {
            Console.WriteLine("Welcome to the greatest calulator ever. Choose which arithmetic operation you want to try out.");
            Console.WriteLine("\n1. Addition \n2. Subraction \n3. Multiplication \n4. Division");
            Console.WriteLine("Choose which one you want to try first: ");

            var Math_Addition = true;
            int myAddition = 1;

            var Math_Subtraction = true;
            int mySubbtraction = 2;

            var Math_Multiplication = true;
            int myMultiplication = 3;

            var Math_Division = true;
            int myDivision = 4;

            if (myAddition == 1)
            {
                Console.ReadKey(Math_Addition);
            }
            else if (mySubbtraction == 2)
            {
                Console.ReadKey(Math_Subtraction);
            }
            else if (myMultiplication == 3)
            {
                Console.ReadKey(Math_Multiplication);
            }
            else if (myDivision == 4)
            {
                Console.ReadKey(Math_Division);
            }
            else
            {
                Console.Write("Sorry, that's not an option.");
            }

        }
        public static void Math_Addition()
        {
            Console.WriteLine("You've chosen Addition.");
            Console.WriteLine("Lets try adding any numbers you pick together.");
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
            Console.WriteLine("You've chosen Subtraction.");
            Console.WriteLine("Lets try subracting any numbers you pick together.");
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
            Console.WriteLine("You've chosen Multplication.");
            Console.WriteLine("Lets try multiplying any numbers you pick together.");
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
            Console.WriteLine("You've chosen Division.");
            Console.WriteLine("Lets try dividing any numbers you pick together.");
            Console.Write("First, enter the 1st number to divide: ");
            double num_7 = double.Parse(Console.ReadLine());
            Console.Write("Then, enter the 2nd number to divide: ");
            double num_8 = double.Parse(Console.ReadLine());
            double the_sum = num_7 / num_8;
            Console.WriteLine($"As {num_7} / {num_8} = {the_sum}");
            Console.WriteLine($"The sum would be: {the_sum}");
        }

    }
}
