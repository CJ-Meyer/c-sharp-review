namespace Chap05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, welcome to the Dice roller app");
            Console.WriteLine("Roll the dice!? Y/N");
            string roll = Console.ReadLine();
            if (roll == "Y")
            {
                Random random = new Random();
            }
        }
    }
}
