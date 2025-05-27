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
            string choice = "y";
            while (choice == "y") {
                Console.WriteLine("Enter Numerical grade: ");
                int grade = Convert.ToInt32(Console.ReadLine());
                if (grade < 0 && grade >100) { 
                    Console.WriteLine("Number must be under 100 and greater than 0");
                }
                else if (grade >= 88) {
                    Console.WriteLine("Letter Grade: A");
                }
                else if (grade >= 80 && grade < 88)
                {
                    Console.WriteLine("Letter Grade: B");
                }
                else if (grade >= 67 && grade < 79)
                {
                    Console.WriteLine("Letter Grade: C");
                }
                else if (grade > 59 && grade < 67)
                {
                    Console.WriteLine("Letter Grade: D");
                }
                else
                {
                    Console.WriteLine("Letter Grade: F");
                }
                Console.WriteLine("Continue? (y/n)");
                choice = Console.ReadLine();
                    }

        }
    }
}
