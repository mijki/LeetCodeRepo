using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeRepo.Problems
{
    internal class _557_ReverseWordsInString
    {
        public static string ReverseWords(string s)
        {
            return string.Join(" ", s.Split(' ').Select(x => new string(x.Reverse().ToArray())));
        }
    }
}
