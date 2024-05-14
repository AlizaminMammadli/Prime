using System.ComponentModel.Design;

namespace Counter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int number = 125;
            //string numbstr = number.tostring();

            //if (number < 0)
            //{
            //    numbstr = numbstr.substring(1);
            //    console.writeline(number + " " + "consists of" + " " + numbstr.length + " " + "character");
            //}

            //else
            //{
            //    console.writeline(number + " " + "consists of" + " " + numbstr.length + " " + "character");

            //}
            int number = 1;
            int counter = 0;
            for (; number != 0; number /= 10 )
            {
                 counter++;                  
            }
            Console.WriteLine(counter);
        }
    }
}
