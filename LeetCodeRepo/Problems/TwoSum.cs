using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeRepo.Problems
{
    internal class TwoSum
    {
        /*
        Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
        You may assume that each input would have exactly one solution, and you may not use the same element twice.
        You can return the answer in any order.
        */

        public static int[] TwoSumMethod(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; i < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target && i != j)
                    {
                        Console.WriteLine($"[{i}, {j}]");
                        return new int[] { i, j };
                    }
                }
            }
            return new int[] { 0, 0 };
        }
    }
}
