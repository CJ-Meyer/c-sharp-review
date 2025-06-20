namespace Chap05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, welcome to the Dice roller app");
            Console.WriteLine("Roll the dice!? Y/N");
            string roll = Console.ReadLine().ToLower();
            Console.WriteLine();
            while (roll == "y")
            {
                Random random = new Random();
                int die1 = random.Next(1,7);
                int die2 = random.Next(1,7);
                Console.WriteLine($"Die 1: {die1}\nDie 2: {die2}");
                string message = $"total: {die1 + die2}";
                Console.WriteLine(message);
                switch(die1+die2)
                {
                    case 2:
                        Console.WriteLine("Snake Eyes");
                        break;
                    case 7:
                        Console.WriteLine("Craps");
                        break;
                    case 12:
                        Console.WriteLine("BoxCars");
                        break;
                }
                Console.WriteLine();
                Console.WriteLine("Roll again!? Y/N");
                roll = Console.ReadLine().ToLower();
                Console.WriteLine();
            }
            Console.WriteLine("Ok Goodbye!");
        }
    }
}
