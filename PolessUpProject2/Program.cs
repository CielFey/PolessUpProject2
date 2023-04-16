using System;

namespace PolessUpProject2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 4, 7, 11, 1 };
            int target = 11;
            bool check = false;
            for (int i = 0; i < nums.Length && check == false; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        Console.WriteLine("Индексы: [{0}, {1}]", i, j);
                        check = true;
                    }
                }
            }
        }
    }
}
