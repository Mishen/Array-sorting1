using System;
namespace SortApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int[] nums = new int[7];
            Console.WriteLine("Insert twenty numbers");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write("{0} number: ", i + 1);
                nums[i] = Int32.Parse(Console.ReadLine());
            }

            // sorting
            int temp;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                }
            }

            // output
            Console.WriteLine("Sorting array output");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
            Console.ReadLine();
        }
    }
}