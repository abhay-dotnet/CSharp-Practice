//Maximum Product of Three Numbers problem

using System;
using System.Linq;

class MaximumProduct
{
    // Method to find maximum product of three numbers
    public static long FindMaximumProduct(int[] nums)
    {
        // Validate input
        if (nums == null || nums.Length < 3)
        {
            throw new ArgumentException(
                "Array must contain at least 3 numbers."
            );
        }

        // Sort the array in ascending order
        int[] sortedNums = nums.OrderBy(x => x).ToArray();

        int n = sortedNums.Length;

        // Case 1:
        // Three largest numbers
        long product1 =
            (long)sortedNums[n - 1] *
            sortedNums[n - 2] *
            sortedNums[n - 3];

        // Case 2:
        // Two smallest negative numbers and largest number
        long product2 =
            (long)sortedNums[0] *
            sortedNums[1] *
            sortedNums[n - 1];

        // Return the maximum product
        return Math.Max(product1, product2);
    }

    public static void Main()
    {
        try
        {
            int[] nums1 = { 1, 2, 3 };
            int[] nums2 = { 1, 2, 3, 4 };
            int[] nums3 = { -1, -2, -3 };
            int[] nums4 = { -10, -10, 5, 2 };

            Console.WriteLine(
                "Maximum Product: " +
                FindMaximumProduct(nums1)
            );

            Console.WriteLine(
                "Maximum Product: " +
                FindMaximumProduct(nums2)
            );

            Console.WriteLine(
                "Maximum Product: " +
                FindMaximumProduct(nums3)
            );

            Console.WriteLine(
                "Maximum Product: " +
                FindMaximumProduct(nums4)
            );
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}