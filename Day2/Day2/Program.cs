using System;

namespace FirstPart
{
    class Section1
    {
        static void Main(string[] args)
        {

            //String INTERPOLATION:-
            string first_name = "Mithun";
            int age = 19;
            string about = $"My name is {first_name}, Age: {age}";
            Console.WriteLine(about);

            //Access Strings:-
            string name = "Troxer";
            Console.WriteLine(name[0]);
            Console.WriteLine(name.IndexOf("x"));

            //Special Character:-
            string text = "Hello this is to test with \"Double-Quotes\"";
            Console.WriteLine(text);

            // \n -> New Line
            // \t -> Tab Space
            // \b -> Back Space

            //int other_age = Convert.ToInt32(Console.ReadLine());

            // If...Else
            Console.WriteLine("Please Enter a Password: ");
            string password = Console.ReadLine();

            if(password.Length > 5)
            {
                Console.WriteLine("Password set SUCCESSFULLY!");
            }
            else
            {
                Console.WriteLine("Please enter a longer Password!!");
            }

        }
    }
}