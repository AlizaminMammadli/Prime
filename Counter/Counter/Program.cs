namespace Counter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = -000200;
            string numbStr = number.ToString();

            if (number < 0)
            {
                numbStr = numbStr.Substring(1);
                Console.WriteLine(number + " " + "consists of" + " " + numbStr.Length + " " + "character");
            }

            else
            {
                Console.WriteLine(number + " " + "consists of" + " " + numbStr.Length + " " + "character");

            }
        }
    }
}
