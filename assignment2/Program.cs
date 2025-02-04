class Program
{
    static void Main(string[] args)
    {
        Factorial();
        PrintPatterns();
        StudentVerification();
        SumOddNumbers();
        CubeNumbers();
        SumOfSeries();
        SumAndAverage();
        GradeDescription();
        MultiplicationTable10x10();
        SingleMultiplicationTable();
        ArrayOfTenElements();
        ReverseArray();
        SwapMinMax();
        MergeArrays();
        FrequencyOfElements();
        SeparateOddEven();
        DeleteElement();
        TwoDMatrix();
        LowerTriangularMatrix();
        UniqueElements();
    }

    static void Factorial()
    {
        Console.Write("Enter a number to find its factorial: ");
        int n = Convert.ToInt32(Console.ReadLine());
        long factorial = 1;
        for (int i = 2; i <= n; i++) factorial *= i;
        Console.WriteLine($"Factorial of {n} is {factorial}\n");
    }

    static void PrintPatterns()
    {
        Console.WriteLine("Pattern A:");
        for (int i = 5; i >= 1; i--)
        {
            for (int j = i; j <= 5; j++)
                Console.Write(j);
            Console.WriteLine();
        }

        Console.WriteLine("\nPattern B:");
        for (int i = 1; i <= 6; i++)
        {
            for (int j = 1; j <= i; j++)
                Console.Write(j);
            Console.WriteLine();
        }

        Console.WriteLine("\nPattern C:");
        for (int i = 5; i >= 1; i--)
        {
            Console.WriteLine(new string(' ', 5 - i) + new string('*', i));
        }

        Console.WriteLine("\nPattern D:");
        for (int i = 1; i <= 5; i++)
            Console.WriteLine(new string(' ', 5 - i) + new string('*', i));
        for (int i = 4; i >= 1; i--)
            Console.WriteLine(new string(' ', 5 - i) + new string('*', i));
    }

    static void StudentVerification()
    {
        Console.Write("Enter student ID (0-9999999): ");
        string? idInput = Console.ReadLine();
        if (idInput == null || !int.TryParse(idInput, out int id) || id < 0 || id > 9999999)
        {
            Console.WriteLine("Invalid ID. Exiting.");
            return;
        }
        Console.WriteLine("Valid ID: " + id);

        Console.Write("Enter password (6-20 chars): ");
        string? password = Console.ReadLine();
        if (password == null || password.Length < 6 || password.Length > 20)
        {
            Console.WriteLine("Invalid password. Exiting.");
            return;
        }
        Console.WriteLine("Password: " + password);

        Console.Write("Enter a string: ");
        string? input = Console.ReadLine();
        if (input == null)
        {
            Console.WriteLine("Invalid input. Exiting.");
            return;
        }
        Console.WriteLine("Uppercase: " + input.ToUpper());
    }

    static void SumOddNumbers()
    {
        int sum = 0;
        for (int i = 15; i <= 100; i++)
        {
            if (i % 2 != 0)
                sum += i;
        }
        Console.WriteLine("Sum of odd numbers from 15 to 100: " + sum);
    }

    static void CubeNumbers()
    {
        Console.Write("Enter number of terms: ");
        int terms = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= terms; i++)
            Console.WriteLine($"Number is: {i}, and cube is: {i * i * i}");
    }

    static void SumOfSeries()
    {
        Console.Write("Enter the number of terms: ");
        int terms = Convert.ToInt32(Console.ReadLine());
        int sum = 0, term = 0;
        for (int i = 0; i < terms; i++)
        {
            term = term * 10 + 1;
            sum += term;
            Console.Write(term + (i < terms - 1 ? " + " : ""));
        }
        Console.WriteLine($"\nSum is: {sum}");
    }

    static void SumAndAverage()
    {
        Console.Write("Enter number of terms: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Enter number {i + 1}: ");
            sum += Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine($"Sum: {sum}, Average: {sum / (float)n}");
    }

    static void GradeDescription()
    {
        Console.Write("Enter grade (E/V/G/A/F): ");
        string? input = Console.ReadLine();
        if (string.IsNullOrEmpty(input))
        {
            Console.WriteLine("Invalid input. Exiting.");
            return;
        }

        char grade = char.ToUpper(input[0]);
        string description = grade switch
        {
            'E' => "Excellent",
            'V' => "Very Good",
            'G' => "Good",
            'A' => "Average",
            'F' => "Fail",
            _ => "Invalid grade"
        };
        Console.WriteLine("You have chosen: " + description);
    }

    static void MultiplicationTable10x10()
    {
        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
                Console.Write((i * j).ToString().PadLeft(4));
            Console.WriteLine();
        }
    }

    static void SingleMultiplicationTable()
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= 10; i++)
            Console.WriteLine($"{num} x {i} = {num * i}");
    }

    static void ArrayOfTenElements()
    {
        int[] arr = new int[10];
        Console.WriteLine("Enter 10 elements:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Element {i}: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Elements in array are: " + string.Join(" ", arr));
    }

    static void ReverseArray()
    {
        Console.Write("Enter number of elements: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];
        Console.WriteLine("Enter elements:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Element {i}: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Reverse: " + string.Join(" ", arr.Reverse()));
    }

    static void SwapMinMax()
    {
        int[] arr = new int[10];
        Console.WriteLine("Enter 10 elements:");
        for (int i = 0; i < 10; i++)
            arr[i] = Convert.ToInt32(Console.ReadLine());

        int minIndex = Array.IndexOf(arr, arr.Min());
        int maxIndex = Array.IndexOf(arr, arr.Max());

        (arr[minIndex], arr[maxIndex]) = (arr[maxIndex], arr[minIndex]);

        Console.WriteLine("Array after swapping min and max: " + string.Join(" ", arr));
    }

    static void MergeArrays()
    {
        Console.Write("Enter size of arrays: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr1 = new int[n];
        int[] arr2 = new int[n];
        Console.WriteLine("Enter elements for first array:");
        for (int i = 0; i < n; i++)
            arr1[i] = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter elements for second array:");
        for (int i = 0; i < n; i++)
            arr2[i] = Convert.ToInt32(Console.ReadLine());

        int[] merged = [.. arr1.Concat(arr2).OrderBy(x => x)];
        Console.WriteLine("Merged and sorted array: " + string.Join(" ", merged));
    }

    static void FrequencyOfElements()
    {
        Console.Write("Enter number of elements: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];
        Console.WriteLine("Enter elements:");
        for (int i = 0; i < n; i++)
            arr[i] = Convert.ToInt32(Console.ReadLine());

        var frequencies = arr.GroupBy(x => x).ToDictionary(g => g.Key, g => g.Count());
        foreach (var (key, value) in frequencies)
            Console.WriteLine($"{key} occurs {value} times");
    }

    static void SeparateOddEven()
    {
        Console.Write("Enter number of elements: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];
        Console.WriteLine("Enter elements:");
        for (int i = 0; i < n; i++)
            arr[i] = Convert.ToInt32(Console.ReadLine());

        var evens = arr.Where(x => x % 2 == 0);
        var odds = arr.Where(x => x % 2 != 0);

        Console.WriteLine("Even elements: " + string.Join(" ", evens));
        Console.WriteLine("Odd elements: " + string.Join(" ", odds));
    }

    static void DeleteElement()
    {
        Console.Write("Enter size of array: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];
        Console.WriteLine("Enter elements:");
        for (int i = 0; i < n; i++)
            arr[i] = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter position to delete (1-based): ");
        int pos = Convert.ToInt32(Console.ReadLine()) - 1;
        arr = [.. arr.Where((_, index) => index != pos)];

        Console.WriteLine("New array: " + string.Join(" ", arr));
    }

    static void TwoDMatrix()
    {
        int[,] matrix = new int[3, 3];
        Console.WriteLine("Enter 3x3 matrix:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"Element [{i}],[{j}]: ");
                matrix[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("Matrix:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
                Console.Write(matrix[i, j] + " ");
            Console.WriteLine();
        }
    }

    static void LowerTriangularMatrix()
    {
        int[,] matrix = new int[3, 3];
        Console.WriteLine("Enter 3x3 matrix:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"Element [{i}],[{j}]: ");
                matrix[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("Lower Triangular Matrix:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (j > i)
                    Console.Write("0 ");
                else
                    Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static void UniqueElements()
    {
        Console.Write("Enter number of elements: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];
        Console.WriteLine("Enter elements:");
        for (int i = 0; i < n; i++)
            arr[i] = Convert.ToInt32(Console.ReadLine());

        var uniqueElements = arr.GroupBy(x => x).Where(g => g.Count() == 1).Select(g => g.Key);
        Console.WriteLine("Unique elements: " + string.Join(" ", uniqueElements));
    }
}
