using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LeetCodeRepo.Problems.Programming_skills_I
{
    internal class _1491_AverageSalaryExcludingTheMinMaxSalary
    {
        //You are given an array of unique integers salary where salary[i] is the salary of the ith employee.
        //Return the average salary of employees excluding the minimum and maximum salary.Answers within 10-5 of the actual answer will be accepted.
        public static double Average(int[] salary)
        {
            return (salary.Sum() - salary.Max() - salary.Min()) / (salary.Length - 2.0);
        }

    }
}
