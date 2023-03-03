using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp
{
    internal class Exercises
    {
        public static void Exc1() 
        {
            int[] nums1 = { 2, 7, 11, 15 };
            int target1 = 9;
            int[] nums2 = {3,2,4};
            int target2 = 6;
            int[] nums3 = {3,3};
            int target3 = 6;
            Console.WriteLine("" +
                "Input: nums = [2,7,11,15], target = 9\r\n" + TwoSum(nums1, target1));
            Console.WriteLine("NEXT");
            Console.WriteLine("" +
                "Input: nums = [3,2,4], target = 6\r\n " + TwoSum(nums2, target2));
            Console.WriteLine("NEXT");
            Console.WriteLine("" +
                "Input: nums = [3,3], target = 6\r\n" + TwoSum(nums3,target3));
        }
        private static int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i+1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target) 
                    {
                        Console.Write($"\n{i} || {j}\n");
                        return new int[] { i, j };

                    }
                }
            }
            return Array.Empty<int>();


        }
    }
}
