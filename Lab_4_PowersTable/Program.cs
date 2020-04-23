
/* A.TORRES
 * 
 * Lab 4 - Display a table of powers.
 * 
 * The application prompts the user to enter an integer.
 * The application displays a table of squares and cubes from 1 to the value entered.
 * The application prompts the user to continue.
 * 
 * Assume that the user will enter valid data.
 * The application should continue only if the user agrees to
 *  
 * Additional Requirements:
 * For answering Lab Summary when submitting to the LMS
 * if there are any syntax errors or if the program does not run (for example, in a Main method).
 * 
 * Extended Exercises:
 * - Provide validation for the user’s input. Keep prompting the user until they enter a number.
 * - Format the table to display nicely.
 */
using System;

namespace Lab_4_PowersTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Learn your squares and cubes!");
            const string format = "{0}\t{1}\t{2}";
            string canContinue = "";
            do
            {
                // prompt the user to enter an integer
                int number = ReadInteger("Enter an integer:");

                // displays a table of squares and cubes from 1 to the value entered
                Console.WriteLine(format, "Number", "Squared", "Cubed");
                Console.WriteLine(format, "======", "=======", "=====");
                for (int i = 1; i <= number; i++)
                {
                    Console.WriteLine(format, i, Math.Pow(i, 2), Math.Pow(i, 3));
                }

                // prompt the user to continue
                canContinue = ReadString("Continue? (y for 'yes' or anything else to quit) ").ToLower();
            } while (canContinue == "y");
        }
        public static string ReadString(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine().Trim();
        }
        public static int ReadInteger(string message)
        {
            string input;
            int number = -1;
            do
            {
                input = ReadString(message);
            } while (int.TryParse(input, out number) == false);
            return number;
        }
    }
}
