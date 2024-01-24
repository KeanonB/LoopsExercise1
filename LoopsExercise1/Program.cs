using System.Security.Cryptography.X509Certificates;

namespace LoopsExercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void IsEqual(int number1, int number2)
            {
                if (number1 == number2)
                {

                }
            }
            static void PositiveOrNegative(int number)
            {
                if (number >= 0)
                {
                    Console.WriteLine($"{number} is positive");
                }
                else (number < 0)
                {
                    Console.WriteLine($"{number} is negative.");
                }

            }
            static void CanPersonVote()
            {
                int age = int.Parse(Console.ReadLine());
                if (age >= 18)
                {
                    Console.WriteLine($"You can vote!");
                }
                else (age < 18)
                {
                    Console.WriteLine($"Sorry, you cannot vote.");
                }


            }





        }
    }
}
