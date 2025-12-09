//using System;

//namespace Company
//{
//    namespace Training
//    {
//        class Demo
//        {
//            public void Show()
//            {
//                Console.WriteLine("Inside nested namespace: Company.Training ");
//                int age = 19;
//                if (age > 18)
//                {
//                    Console.WriteLine("You are eligible for voting!");
//                }
//                else
//                {
//                    Console.WriteLine("You are not eligible for voting");
//                }
//            }
//        }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Company.Training.Demo obj = new Company.Training.Demo();
//        obj.Show();
//    }
//}

public class Details
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Details(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }


}

public class Student
{
    public static void Main()
    {
        Details d1 = new Details("Mithun", 19);
        Console.WriteLine(d1.Name);
        Console.WriteLine(d1.Age);
    }
}