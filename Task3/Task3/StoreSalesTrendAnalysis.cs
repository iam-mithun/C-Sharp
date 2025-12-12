// Program1_StoreSales.cs
using System;
using System.Linq;

class StoreSalesAnalysis
{
    static void Main()
    {
        Console.WriteLine("STORE SALES TREND ANALYSIS");
        int n = ReadPositiveInt("Enter number of days in the month: ");

        int[] sales = ReadIntArray(n, "Enter sales for day");
        Console.WriteLine();

        // Display original
        Console.WriteLine("Original sales:");
        PrintArrayWithIndex(sales);

        // Sorted display (do not change original)
        int[] sorted = (int[])sales.Clone();
        Array.Sort(sorted);
        Console.WriteLine("\nSorted sales (ascending):");
        PrintArray(sorted);

        // Summary statistics
        int total = sales.Sum();
        int max = sales.Max();
        int min = sales.Min();
        Console.WriteLine($"\nSummary:");
        Console.WriteLine($"Total sales for month: {total}");
        Console.WriteLine($"Highest single-day sales: {max}");
        Console.WriteLine($"Lowest single-day sales: {min}");

        // Search
        int query = ReadInt("Enter a sales value to search for: ");
        bool found = Array.Exists(sales, x => x == query);
        Console.WriteLine(found ? $"Value {query} exists in the data." : $"Value {query} NOT found.");

        // Backup copy
        int[] backup = (int[])sales.Clone();
        Console.WriteLine("\nBackup of sales data created.");

        // Compare with another dataset
        Console.WriteLine("\nNow enter another sales dataset to compare with original:");
        int[] other = ReadIntArray(n, "Enter sales for day (other dataset)");
        bool equal = sales.SequenceEqual(other);
        Console.WriteLine(equal ? "The two sales datasets are EQUAL." : "The two sales datasets are NOT equal.");

        Console.WriteLine("\nProgram finished. Press any key to exit.");
        Console.ReadKey();
    }


    // Helpers
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
        while (!int.TryParse(Console.ReadLine(), out  x))
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
            Console.WriteLine($"Day {i + 1}: {arr[i]}");
    }
}
