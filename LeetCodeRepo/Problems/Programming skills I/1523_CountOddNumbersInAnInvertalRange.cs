using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeRepo.Problems.Programming_skills_I
{
    internal class _1523_CountOddNumbersInAnInvertalRange
    {
        /*Given two non-negative integers low and high. Return the count of odd numbers between low and high (inclusive).*/     
        public static int CountOdds(int low, int high)
        {
            return (high + 1) / 2 - low / 2;
        }
    }
}
