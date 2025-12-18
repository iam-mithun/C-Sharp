using System;

class Person
{
    private string firstName;
    private string lastName;
    private string emailAddress;
    private DateTime dateOfBirth;

    public Person(string firstName, string lastName, string email, DateTime dob)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.emailAddress = email;
        this.dateOfBirth = dob;
    }

    public bool IsAdult
    {
        get
        {
            int age = DateTime.Now.Year - dateOfBirth.Year;
            if (dateOfBirth > DateTime.Now.AddYears(-age))
                age--;
            return age >= 18;
        }
    }

    public string SunSign
    {
        get
        {
            int day = dateOfBirth.Day;
            int month = dateOfBirth.Month;

            if ((month == 3 && day >= 21) || (month == 4 && day <= 19)) return "Aries";
            if ((month == 4 && day >= 20) || (month == 5 && day <= 20)) return "Taurus";
            if ((month == 5 && day >= 21) || (month == 6 && day <= 20)) return "Gemini";
            if ((month == 6 && day >= 21) || (month == 7 && day <= 22)) return "Cancer";
            if ((month == 7 && day >= 23) || (month == 8 && day <= 22)) return "Leo";
            if ((month == 8 && day >= 23) || (month == 9 && day <= 22)) return "Virgo";
            if ((month == 9 && day >= 23) || (month == 10 && day <= 22)) return "Libra";
            if ((month == 10 && day >= 23) || (month == 11 && day <= 21)) return "Scorpio";
            if ((month == 11 && day >= 22) || (month == 12 && day <= 21)) return "Sagittarius";
            if ((month == 12 && day >= 22) || (month == 1 && day <= 19)) return "Capricorn";
            if ((month == 1 && day >= 20) || (month == 2 && day <= 18)) return "Aquarius";
            return "Pisces";
        }
    }

    public bool IsBirthDay
    {
        get
        {
            return DateTime.Now.Day == dateOfBirth.Day &&
                   DateTime.Now.Month == dateOfBirth.Month;
        }
    }

    public string ScreenName
    {
        get
        {
            return firstName.ToLower() +
                   lastName.ToLower() +
                   dateOfBirth.ToString("ddMMyy");
        }
    }
}

class Employee : Person
{
    public double Salary { get; set; }

    public Employee(string f, string l, string e, DateTime dob, double salary)
        : base(f, l, e, dob)
    {
        Salary = salary;
    }
}

class HourlyEmployee : Person
{
    public double HoursWorked { get; set; }
    public double PayPerHour { get; set; }

    public HourlyEmployee(string f, string l, string e, DateTime dob,
                          double hours, double pay)
        : base(f, l, e, dob)
    {
        HoursWorked = hours;
        PayPerHour = pay;
    }
}

class PermanentEmployee : Person
{
    public double HRA { get; set; }
    public double DA { get; set; }
    public double Tax { get; set; }

    public double TotalPay => HRA + DA;
    public double NetPay => TotalPay - Tax;

    public PermanentEmployee(string f, string l, string e, DateTime dob,
                             double hra, double da, double tax)
        : base(f, l, e, dob)
    {
        HRA = hra;
        DA = da;
        Tax = tax;
    }
}

class Gadget
{
    private string brand;
    private string model;
    private DateTime releaseDate;
    private double price;

    public Gadget(string brand, string model, DateTime releaseDate, double price)
    {
        this.brand = brand;
        this.model = model;
        this.releaseDate = releaseDate;
        this.price = price;
    }

    public int AgeInYears => DateTime.Now.Year - releaseDate.Year;

    public bool IsWarrantyValid => (DateTime.Now - releaseDate).TotalDays <= 730;

    public double DiscountedPrice
    {
        get
        {
            if (AgeInYears > 3) return price * 0.88;
            if (AgeInYears > 1) return price * 0.95;
            return price;
        }
    }

    public string UniqueCode =>
        brand.Substring(0, 3).ToLower() +
        model.Substring(model.Length - 2).ToLower() +
        releaseDate.Year.ToString().Substring(2);

    public string Brand => brand;
    public string Model => model;
}

class Smartphone : Gadget
{
    public int RAM { get; set; }
    public int Storage { get; set; }
    public double CameraMP { get; set; }

    public Smartphone(string b, string m, DateTime r, double p,
                      int ram, int storage, double cam)
        : base(b, m, r, p)
    {
        RAM = ram;
        Storage = storage;
        CameraMP = cam;
    }
}

class Laptop : Gadget
{
    public int RAM { get; set; }
    public string Processor { get; set; }
    public double BatteryBackupHours { get; set; }

    public Laptop(string b, string m, DateTime r, double p,
                  int ram, string proc, double battery)
        : base(b, m, r, p)
    {
        RAM = ram;
        Processor = proc;
        BatteryBackupHours = battery;
    }
}


class GeometryTool
{
    public double Perimeter(double side) => 4 * side;
    public double Perimeter(double l, double b) => 2 * (l + b);
    public double Perimeter(double a, double b, double c) => a + b + c;
    public double Perimeter(double r, bool isCircle) => 2 * Math.PI * r;
}


class Calculator
{
    public int Add(int a, int b) => a + b;
    public int Add(int a, int b, int c) => a + b + c;
    public double Add(double a, double b) => a + b;
    public double Add(double a, double b, double c) => a + b + c;

    public int Multiply(int a, int b) => a * b;
    public int Multiply(int a, int b, int c) => a * b * c;
    public double Multiply(double a, double b) => a * b;

    public int Subtract(int a, int b) => a - b;
    public double Subtract(double a, double b) => a - b;
}


class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Drawing a shape");
    }
}

class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a circle");
    }
}

class Rectangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a rectangle");
    }
}

class Triangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a triangle");
    }
}


class Notification
{
    public virtual void Send(string message)
    {
        Console.WriteLine("Sending notification: " + message);
    }
}

class EmailNotification : Notification
{
    public override void Send(string message)
    {
        Console.WriteLine("Email sent to registered address: " + message);
    }
}

class SmsNotification : Notification
{
    public override void Send(string message)
    {
        Console.WriteLine("SMS sent to mobile number: " + message);
    }
}

class PushNotification : Notification
{
    public override void Send(string message)
    {
        Console.WriteLine("Push notification delivered to device: " + message);
    }
}


class Program
{
    static void Main()
    {
        Shape s;
        s = new Circle(); s.Draw();
        s = new Rectangle(); s.Draw();
        s = new Triangle(); s.Draw();

        Notification n;
        n = new EmailNotification(); n.Send("Welcome");
        n = new SmsNotification(); n.Send("OTP 1234");
        n = new PushNotification(); n.Send("New Alert");
    }
}


