using System.Transactions;

namespace chap03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Time Travel calculator");


            Console.WriteLine("Enter miles: ");
            int miles = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter miles per hour: ");
            int mph = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Estimated Travel Time\n" +
                              "=====================");
            double time = (double)miles / mph;
            int hour = Convert.ToInt32(time);
            int minute = (int)Math.Round((time - hour) * 60);
            Console.WriteLine($"Hours: {hour}");
            Console.WriteLine($"Minute: {minute}");

            // 4-4 Greatest common divisor, I know this says chap03 but I am tired lol

            //Greatest common divisor finder Application
            Console.WriteLine("Welcome to the greatest common divisor app");
            // Enter First: 12
            // Enter Second: 8
            // Greatest Divisor: 4
            // Ask for first and second number using Readline and convert to Int
            // start loop to search for common divisors with lower number entry and counter=-1
            // if First%counter == 0 && Second%counter == 0
            // print counter

            Console.WriteLine("Enter First: ");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second");
            int second = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine(first);
            // Console.WriteLine(second);
            for (int i = second; i > 0; i--)
            {
                // Console.WriteLine($"Each Number being ran as i: {i}");
                if (first%i == 0 &&  second%i == 0)
                {
                    Console.WriteLine($"Greatest Common Divisor {i}");
                    break;
                }
            }
        }
    }
}
