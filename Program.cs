/*Author: Matthew Potter
 * Date: 1/29/2021
 * Comments: Demonstrating use of conditional statemnts
 */


using System;

namespace ConditionalStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your desired grade in interger form...");


            try
            {
                string input = Console.ReadLine();
                decimal grade = decimal.Parse(input);

                if (grade >= 98)
                {
                    Console.WriteLine("Your Letter Grade Will Be an A+");
                }
                else if ((grade < 98) && (grade >= 92))
                {
                    Console.WriteLine("Your Letter Grade Will Be an A");
                }
                else if ((grade < 92) && (grade >= 90))
                {
                    Console.WriteLine("Your Letter Grade Will Be an A-");
                }
                else if ((grade < 90) && (grade >= 88))
                {
                    Console.WriteLine("Your Letter Grade Will Be a B+");
                }
                else if ((grade < 88) && (grade >= 82))
                {
                    Console.WriteLine("Your Letter Grade Will Be a B");
                }
                else if ((grade < 82) && (grade >= 80))
                {
                    Console.WriteLine("Your Letter Grade Will Be a B-");
                }
                else if ((grade < 80) && (grade >= 78))
                {
                    Console.WriteLine("Your Letter Grade Will Be a C+");
                }
                else if ((grade < 78) && (grade >= 72))
                {
                    Console.WriteLine("Your Letter Grade Will Be a C");
                }
                else if ((grade < 72) && (grade >= 70))
                {
                    Console.WriteLine("Your Letter Grade Will Be a C-");
                }
                else if ((grade < 70) && (grade >= 68))
                {
                    Console.WriteLine("Your Letter Grade Will Be a D+");
                }
                else if ((grade < 68) && (grade >= 62))
                {
                    Console.WriteLine("Your Letter Grade Will Be a D");
                }
                else if ((grade < 62) && (grade >= 60))
                {
                    Console.WriteLine("Your Letter Grade Will Be a D-");
                }
                else 
                {
                    Console.WriteLine("Your Letter Grade Will Be an F");
                }
            }
            catch
            {
                Console.WriteLine("Please enter an interget between 0-100 next time");
            }
        }
    }
}
