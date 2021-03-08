using System;

// Working With Numbers | C# | Tutorial 7

namespace CSharpExercises_7
{
    class Program
    {
        static void Main(string[] args)
        {
            // modulus operator - 5 div by 2 and gives us remainder
            Console.WriteLine(5 % 2);

            // order of operation here says 2 * 3 first and then add 4
            Console.WriteLine(4 + 2 * 3);
            // we can add () to control order 
            Console.WriteLine((4 + 2) * 3);

            // gives you a decimal answer
            Console.WriteLine(5 + 8.1);

            // gives you an int answer
            Console.WriteLine(5 / 2);
            // gives you a decimal answer
            Console.WriteLine(5 / 2.0);

            // declare a variable and set to a number and increment or decrement
            int num = 6;
            num--;
            Console.WriteLine(num);

            // math methods
            // abosolute value of a number
            Console.WriteLine( Math.Abs(-40));
            // power a 1st number raised to the power of the 2nd number
            Console.WriteLine(Math.Pow(3.8, 2));

            Console.WriteLine(Math.Sqrt(36));

            Console.WriteLine(Math.Max(4, 90));

            Console.WriteLine(Math.Min(4, 90));

            Console.WriteLine(Math.Round(4.6));

            Console.ReadLine();
        }
    }
}
