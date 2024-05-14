using System.Runtime.Intrinsics.Arm;

namespace Sade_ve_murekkeb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 23;


            if (number <= 1)
            {
                Console.WriteLine(number + " " + "is neither prime nor composite");
            }
            else if (number == 2 || number == 3 || number == 5 || number == 7)
            {
                Console.WriteLine(number + " " + "is prime");
            }
            else if (number % 2 == 0 || number % 3 == 0 || number % 5 == 0 || number % 7 == 0)
            {
                Console.WriteLine(number + " " + "is composite");
            }

            else
            {
                Console.WriteLine(number + " " + "is prime");
            }



        }
    }
}
