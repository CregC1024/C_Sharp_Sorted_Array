using System;

namespace C_Sharp_Sorted_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 10, 15, 16, 8, 6 };
            Console.WriteLine("Original Arry");

            foreach (var element in nums)
                Console.WriteLine(element);

            Array.Sort(nums);

            Console.WriteLine("Sorted Array");

            foreach (var element in nums)
                Console.WriteLine(element);
            Array.Reverse(nums);
            Console.WriteLine("Reversed Array");
            Array.ForEach<int>(nums, n => Console.WriteLine(n));
            Console.WriteLine(Array.BinarySearch(nums, 15));

        }
    }
}
