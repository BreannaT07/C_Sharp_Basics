using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Comments();
            //DataTypes();
            //InputOutput();

            //Mattstuff.cs V
            Mathstuff.Do_Stuff();
            Mathstuff.Math_Addition();
            Mathstuff.Math_Subtraction();
            Mathstuff.Math_Multiplication();
            Mathstuff.Math_Division();



            Console.ReadKey();
        }

        public static void Comments()
        {
            Console.WriteLine("Comments have slashes.");
            // this is a comment
            /* this
             * is
             * a
             * multiline
             * comment
             */
            Console.WriteLine("Multiline Commentysb start and end with /* */");

        }
        public static void DataTypes()
        {
            int myAge = 99;
            Console.WriteLine(myAge);
            char classGrade = 'A';
            Console.WriteLine(classGrade);

            float myFloat = 123.34F;
            // or double myfloat = 123.34;
            Console.WriteLine(myFloat);

            decimal myDecimal = 86.7539M;
            Console.WriteLine(myDecimal);

            double myDouble = 123.34;
            Console.WriteLine(myDouble);

            bool myBool = true;
            Console.WriteLine(myBool);

            string myString = "Mr. Sekol is awesome :)";
            Console.WriteLine(myString);
        }
        public static void InputOutput()
        {
            Console.Write("what is your name?: ");
            string playername = Console.ReadLine();
            Console.WriteLine($"Hello {playername}. How are you today? ");
            // Readline takes in strings so if you wnat to do math, you have to cats the
            // string indifferent datatype

            //Let's math
            Console.WriteLine("Welcome to my Addition calulator");
            Console.Write("Please enter a number: ");
            double num_1 = double.Parse(Console.ReadLine());
            Console.Write("Please enter a 2nd number: ");
            double num_2 = double.Parse(Console.ReadLine());
            double the_sum = num_1 + num_2;
            Console.WriteLine($"{num_1} + {num_2} = {the_sum}");

            Console.WriteLine("Let's do multiplication");
            Console.Write("Please enter a number: ");
            double num_3 = double.Parse(Console.ReadLine());
            Console.Write("Please enter a 2nd number: ");
            double num_4 = double.Parse(Console.ReadLine());
            double the_product = num_3 * num_4;
            Console.WriteLine($"{num_3} x {num_4} = {the_product}");
        }

    }
}
