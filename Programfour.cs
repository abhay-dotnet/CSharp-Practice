using System;

class Program
{
    public static void Main()
    {
        string s = "babab";

        int[] count = new int[26];

        // Count characters
        foreach (char c in s)
        {
            count[c - 'a']++;
        }

        // Create left half
        string left = "";

        for (int i = 0; i < 26; i++)
        {
            for (int j = 0; j < count[i] / 2; j++)
            {
                left += (char)('a' + i);
            }
        }

        // Find middle character
        char middle = '\0';

        for (int i = 0; i < 26; i++)
        {
            if (count[i] % 2 != 0)
            {
                middle = (char)('a' + i);
                break;
            }
        }

        // Create right half
        char[] arr = left.ToCharArray();
        Array.Reverse(arr);

        string right = new string(arr);

        // Print answer
        Console.WriteLine("Input: " + s);
        Console.WriteLine("Output: " + left + middle + right);
    }
}