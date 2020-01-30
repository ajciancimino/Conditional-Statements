using System;

namespace Conditional_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for input
            Console.WriteLine("What grade they expect to get in ISM 4300?");

            //Try catch is used to catch bad user imputs
            try
            {
                // This variable will be used to store the user input
                string input = Console.ReadLine();

                // This variable stores a refined value after it has been parsed
                int grade = int.Parse(input);

                if ((grade >= 0) && (grade <= 100))
                {
                    //A series of conditionals to evaluate the grade and display appropriate letter grade
                    if (98 <= grade)
                        Console.WriteLine("A+");
                    else if (92 <= grade)
                        Console.WriteLine("A");
                    else if (90 <= grade)
                        Console.WriteLine("A-");
                    else if (88 <= grade)
                        Console.WriteLine("B+");
                    else if (82 <= grade)
                        Console.WriteLine("B");
                    else if (80 <= grade)
                        Console.WriteLine("B-");
                    else if (78 <= grade)
                        Console.WriteLine("C+");
                    else if (72 <= grade)
                        Console.WriteLine("C");
                    else if (70 <= grade)
                        Console.WriteLine("C-");
                    else if (68 <= grade)
                        Console.WriteLine("D+");
                    else if (62 <= grade)
                        Console.WriteLine("D");
                    else if (60 <= grade)
                        Console.WriteLine("D-");
                    else if (60 > grade)
                        Console.WriteLine("F");
                }
                else
                    Console.WriteLine("Grade must be between 0 and 100");

            }
            catch
            {
                Console.WriteLine("Please enter your grade as an integer, thank you.");
            }
        }
    }
}
