using System;

class Program
{
    // Calculate average marks
    static double CalculateAverage(int[] marks)
    {
        int sum = 0;

        foreach (int mark in marks)
        {
            sum += mark;
        }

        return (double)sum / marks.Length;
    }

    // Find highest marks
    static int FindHighest(int[] marks)
    {
        int highest = marks[0];

        foreach (int mark in marks)
        {
            if (mark > highest)
            {
                highest = mark;
            }
        }

        return highest;
    }

    // Find lowest marks
    static int FindLowest(int[] marks)
    {
        int lowest = marks[0];

        foreach (int mark in marks)
        {
            if (mark < lowest)
            {
                lowest = mark;
            }
        }

        return lowest;
    }

    // Sort marks using Bubble Sort
    static void SortMarks(int[] marks)
    {
        for (int i = 0; i < marks.Length - 1; i++)
        {
            for (int j = 0; j < marks.Length - i - 1; j++)
            {
                if (marks[j] > marks[j + 1])
                {
                    int temp = marks[j];
                    marks[j] = marks[j + 1];
                    marks[j + 1] = temp;
                }
            }
        }
    }

    // Search for a mark
    static bool SearchMark(int[] marks, int target)
    {
        foreach (int mark in marks)
        {
            if (mark == target)
            {
                return true;
            }
        }

        return false;
    }

    public static void Main(string[] args)
    {
        Console.Write("Enter number of students: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] marks = new int[n];

        // Input marks
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter marks of student " + (i + 1) + ": ");
            marks[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Display original marks
        Console.WriteLine("\nOriginal Marks:");

        foreach (int mark in marks)
        {
            Console.Write(mark + " ");
        }

        // Calculate results
        double average = CalculateAverage(marks);
        int highest = FindHighest(marks);
        int lowest = FindLowest(marks);

        Console.WriteLine("\n\nAverage Marks: " + average);
        Console.WriteLine("Highest Marks: " + highest);
        Console.WriteLine("Lowest Marks: " + lowest);

        // Sort array
        SortMarks(marks);

        Console.WriteLine("\nSorted Marks:");

        foreach (int mark in marks)
        {
            Console.Write(mark + " ");
        }

        // Search
        Console.Write("\n\nEnter marks to search: ");
        int target = Convert.ToInt32(Console.ReadLine());

        if (SearchMark(marks, target))
        {
            Console.WriteLine(target + " marks found in the array.");
        }
        else
        {
            Console.WriteLine(target + " marks not found in the array.");
        }

        Console.ReadKey();
    }
}