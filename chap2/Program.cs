namespace chap2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Student Registration App");
            Console.WriteLine("Enter First Name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter Year of Birth");
            int YOB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Welcome {firstName} {lastName}!");
            Console.WriteLine("Your registration is complete");
            Console.WriteLine($"Your temporary password is: {firstName}*{YOB}");

            Console.WriteLine("Welcome to the grade converter App");

        }
    }
}
