
using System.Globalization;
using System.Runtime.ExceptionServices;

public class Demo
{

    static void Main(string[] args)
    {
        Console.Write("Enter your name: ");
        string? name = Console.ReadLine();

        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\n\nYour Details:-");
        Console.WriteLine($"Name: {name}, \n Age: {age}");


        //Short if...else
        int time = 14;
        string result = (time <= 12) ? "Good Morning" : "Good Afternoon";
        Console.WriteLine(result);

        //Switch Statement:-
        Console.Write("Enter the day: ");
        int day = Convert.ToInt32(Console.ReadLine());

        switch (day)
        {
            case 1:
                Console.WriteLine("Sunday");
                break;
            case 2:
                Console.WriteLine("Monday");
                break;
            case 3:
                Console.WriteLine("Tuesday");
                break;
            case 4:
                Console.WriteLine("Wednesday");
                break;
            case 5:
                Console.WriteLine("Thursday");
                break;
            case 6:
                Console.WriteLine("Friday");
                break;
            case 7:
                Console.WriteLine("Saturday");
                break;
            default:
                Console.WriteLine("Please Enter a valid date!");
                break;
        }

        //   While / do While Loop:-
        int i = 0;
        do
        {
            Console.WriteLine(i + 1 + ". Mithun");
            i++;

        }
        while (i < 10);

        for(int j =0; j < 10; j++)
        {
            Console.WriteLine()
        }



    }

}


/*To use this as the Entry Point -> Right click on the right side and click properties then select the
  startup where the Other Entry point Exist. */
public class Test
{
    static void Main()
    {
        Console.WriteLine("Mithun");
    }
}