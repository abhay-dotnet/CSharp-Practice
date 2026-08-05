using System;

public class Programseven
{
    public int NumDistinct(string s, string t)
    {
        int m = s.Length;
        int n = t.Length;

        if (n > m)
            return 0;

        long[] dp = new long[n + 1];
        dp[0] = 1; // Empty string can always be formed

        for (int i = 1; i <= m; i++)
        {
            for (int j = Math.Min(i, n); j >= 1; j--)
            {
                if (s[i - 1] == t[j - 1])
                {
                    dp[j] += dp[j - 1];
                }
            }
        }

        return (int)dp[n];
    }

    public static void Main(string[] args)
    {
        Programseven solution = new Programseven();

        Console.WriteLine(solution.NumDistinct("rabbbit", "rabbit")); // Output: 3
        Console.WriteLine(solution.NumDistinct("babgbag", "bag"));     // Output: 5
    }
}