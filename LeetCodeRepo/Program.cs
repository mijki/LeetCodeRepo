using LeetCodeRepo.Problems;
using LeetCodeRepo.Problems.Programming_skills_I;

/*Task1: Two Sum
    int[] nums = { 3, 2, 4 };
    int target = 6;
    TwoSum.TwoSumMethod(nums, target);
*/

/*Task2: Number of Digit One
    int n = 824883294;
    Console.WriteLine(_233_NumberOfDigitOne.CountDigitOne(n));
*/

/*Task3: Reverse Words in String III
string s = "Let's take LeetCode contest";
Console.WriteLine(_557_ReverseWordsInString.ReverseWords(s));
*/

/*Programming Skills I.
 * 
 * Day1:
 * Task4: Count Odd Numbers in an Interval Range
           Console.WriteLine(_1523_CountOddNumbersInAnInvertalRange.CountOdds(3, 7));
 * Task5: 1491. Average Salary Excluding the Minimum and Maximum Salary
           int[] salary = { 4000, 3000, 1000, 2000 };
           Console.WriteLine(_1491_AverageSalaryExcludingTheMinMaxSalary.Average(salary));
*/

/*
 * Day2:
 * 191: Number of 1 Bits
    uint n = 11111111111111111111111111111101;
    Console.WriteLine(_191_NumberOfOneBits.HammingWeight(n));
    1281: Subtract the Product and Sum of Digits of an Integer
    Given an integer number n, return the difference between the product of its digits and the sum of its digits.
    Console.WriteLine(_1281_SubtractTheProducts.SubtractProductAndSum(234));*/

/*Day3:
 Task 1:
    976. Largest perimeter triangle
    Given an integer array nums, return the largest perimeter of a triangle with a non-zero area, formed from three of these lengths. 
    If it is impossible to form any triangle of a non-zero area, return 0.
        int[] nums = { 3, 6, 2, 3 };
        Console.WriteLine(_976_LargestPerimeterTriangle.LargestPerimeter(nums));
 Task2:
    1779. Find Nearest Point That Has the Same X or Y Coordinate
    */
int x = 3;
int y = 4;
int[][] points = new int[][] { new int[] { 3,4} };
Console.WriteLine(_1779_NearesPointThatHasTheSameCoordinates.NearestValidPoint(x, y, points));




