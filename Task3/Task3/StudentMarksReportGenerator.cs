// Program2_MarksReport.cs
using System;
using System.Linq;

class MarksReportGenerator
{
    static void Main()
    {
        Console.WriteLine("STUDENT MARKS REPORT GENERATOR");
        int n = ReadPositiveInt("Enter number of students: ");

        int[] marks = ReadIntArray(n, "Enter marks for student");
        Console.WriteLine();

        // Display original
        Console.WriteLine("Original marks:");
        PrintArrayWithIndex(marks);

        // Sorted marks
        int[] sorted = (int[])marks.Clone();
        Array.Sort(sorted);
        Console.WriteLine("\nSorted marks (ascending):");
        PrintArray(sorted);

        // Summary
        int total = marks.Sum();
        int highest = marks.Max();
        int lowest = marks.Min();
        double average = (double)total / n;
        Console.WriteLine("\nSummary:");
        Console.WriteLine($"Total marks (sum): {total}");
        Console.WriteLine($"Highest mark: {highest}");
        Console.WriteLine($"Lowest mark: {lowest}");
        Console.WriteLine($"Average mark: {average:F2}");

        // Search
        int query = ReadInt("Enter a mark to search for: ");
        bool found = Array.Exists(marks, x => x == query);
        Console.WriteLine(found ? $"Mark {query} FOUND." : $"Mark {query} NOT found.");

        // Backup
        int[] backup = (int[])marks.Clone();
        Console.WriteLine("\nBackup of marks data created.");

        // Compare
        Console.WriteLine("\nEnter another set of marks to compare with original:");
        int[] other = ReadIntArray(n, "Enter marks for student (other dataset)");
        bool equal = marks.SequenceEqual(other);
        Console.WriteLine(equal ? "Both marks datasets are IDENTICAL." : "Marks datasets are DIFFERENT.");

        Console.WriteLine("\nProgram finished. Press any key to exit.");
        Console.ReadKey();
    }

    // Helpers (same as previous program)
    static int ReadPositiveInt(string prompt)
    {
        int v;
        do
        {
            v = ReadInt(prompt + " ");
            if (v <= 0) Console.WriteLine("Please enter a positive integer.");
        } while (v <= 0);
        return v;
    }

    static int ReadInt(string prompt)
    {
        Console.Write(prompt);
        int x;
        while (!int.TryParse(Console.ReadLine(), out x))
            Console.Write("Invalid. " + prompt);
        return x;
    }

    static int[] ReadIntArray(int n, string elementPrompt)
    {
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = ReadInt($"{elementPrompt} {i + 1}: ");
        }
        return arr;
    }

    static void PrintArray(int[] arr)
    {
        Console.WriteLine(string.Join(" ", arr));
    }

    static void PrintArrayWithIndex(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
            Console.WriteLine($"Student {i + 1}: {arr[i]}");
    }
}
