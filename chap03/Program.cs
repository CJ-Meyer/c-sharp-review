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

        }
    }
}
