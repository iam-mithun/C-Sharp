public class Task4
{


    static void Main()
    {
        Console.WriteLine("1. Diagonal Difference");
        Console.WriteLine("2. Snake Pattern");
        Console.WriteLine("3. Transpose Matrix");
        Console.WriteLine("4. Spiral Order");
        Console.Write("Choose problem: ");

        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1: DiagonalDifference(); break;
            case 2: SnakePattern(); break;
            case 3: TransposeMatrix(); break;
            case 4: SpiralOrder(); break;
            default: Console.WriteLine("Invalid choice"); break;
        }
    }


    static int[,] ReadMatrix(int n, int m)
    {
        int[,] mat = new int[n, m];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write($"Enter element [{i},{j}]: ");
                mat[i, j] = int.Parse(Console.ReadLine());
            }
        }
        return mat;
    }

    static void PrintMatrix(int[,] mat)
    {
        int n = mat.GetLength(0);
        int m = mat.GetLength(1);

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
                Console.Write(mat[i, j] + " ");
            Console.WriteLine();
        }
    }

    static void DiagonalDifference()
    {
        Console.Write("Enter matrix size n: ");
        int n = int.Parse(Console.ReadLine());

        int[,] mat = ReadMatrix(n, n);

        int primarySum = 0;
        int secondarySum = 0;

        for (int i = 0; i < n; i++)
        {
            primarySum += mat[i, i];
            secondarySum += mat[i, n - 1 - i];
        }

        int result = Math.Abs(primarySum - secondarySum);

        Console.WriteLine("Primary Diagonal Sum = " + primarySum);
        Console.WriteLine("Secondary Diagonal Sum = " + secondarySum);
        Console.WriteLine("Absolute Difference = " + result);
    }


    static void SnakePattern()
    {
        Console.Write("Enter matrix size n: ");
        int n = int.Parse(Console.ReadLine());

        int[,] mat = ReadMatrix(n, n);

        Console.WriteLine("Snake Pattern:");
        for (int i = 0; i < n; i++)
        {
            if (i % 2 == 0)
            {
                for (int j = 0; j < n; j++)
                    Console.Write(mat[i, j] + " ");
            }
            else
            {
                for (int j = n - 1; j >= 0; j--)
                    Console.Write(mat[i, j] + " ");
            }
        }
        Console.WriteLine();
    }


    static void TransposeMatrix()
    {
        Console.Write("Enter matrix size n: ");
        int n = int.Parse(Console.ReadLine());

        int[,] mat = ReadMatrix(n, n);

        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                int temp = mat[i, j];
                mat[i, j] = mat[j, i];
                mat[j, i] = temp;
            }
        }

        Console.WriteLine("Transposed Matrix:");
        PrintMatrix(mat);
    }


    static void SpiralOrder()
    {
        Console.Write("Enter number of rows: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Enter number of columns: ");
        int cols = int.Parse(Console.ReadLine());

        int[,] mat = ReadMatrix(rows, cols);

        int top = 0, bottom = rows - 1;
        int left = 0, right = cols - 1;

        Console.WriteLine("Spiral Order:");

        while (top <= bottom && left <= right)
        {
            for (int i = left; i <= right; i++)
                Console.Write(mat[top, i] + " ");
            top++;

            for (int i = top; i <= bottom; i++)
                Console.Write(mat[i, right] + " ");
            right--;

            if (top <= bottom)
            {
                for (int i = right; i >= left; i--)
                    Console.Write(mat[bottom, i] + " ");
                bottom--;
            }

            if (left <= right)
            {
                for (int i = bottom; i >= top; i--)
                    Console.Write(mat[i, left] + " ");
                left++;
            }
        }
        Console.WriteLine();
    }




}