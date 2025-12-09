using System;
namespace HelloWorld
{
    class newProgram
    {
        static void Main(string[] args)
        {
            // This is to print something.
            Console.WriteLine("Mithun");
            int num1 = 10;
            int num2 = 29;
            int sum = num1 + num2;

            Console.WriteLine("The answer is: " + sum);

            string myName = "Mithun .M";
            Console.WriteLine("My name is: " + myName);

            Console.WriteLine("Enter the user name: ");
            string userName = Console.ReadLine();
            Console.WriteLine("The user name is: " + userName);

            // Convert.ToString()  converts int, double, bool to string.
            // Convert.ToDouble() converts int to double.
            // Convert.ToInt32() converts double to int.

            Console.WriteLine("Enter the age of the user: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("User Age is: " + age);

            int age1 = 20;
            int age2 = 18;

            // Comparison Operator:-
            Console.WriteLine(age1 > age2);
            Console.WriteLine(age1 == age2);
            Console.WriteLine(age1 != age2);
            Console.WriteLine(age1 <= age2);

            // Logical Operator:-
            Console.WriteLine(age1 >= 18 && age1 <= 25);
            Console.WriteLine(age2 <= 20 || age2 >= 18);

            //Math Operation:-
            int value1 = 98;
            int value2 = 45;

            Math.Min(value1, value2);
            Math.Max(value1, value2);
            Math.Sqrt(value1);
            
            Math.Abs(-98.56);
            Math.Round(14.47);

            //String Methods:-
            string text = "This is a sample Text";
            Console.WriteLine("The length of the text string is: " + text.Length);

            Console.WriteLine(text.ToUpper());
            Console.WriteLine(text.ToLower());

            Console.WriteLine("Enter the first Name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the second Name: ");
            string lastName = Console.ReadLine();
            string name = firstName + lastName;
            Console.WriteLine(name);
        }
    }
}
