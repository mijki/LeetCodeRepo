namespace LeetCodeRepo.Problems.Programming_skills_I;

public class _1502_CanMakeArithmeticProgFromSeq {
    /*A sequence of numbers is called an arithmetic progression if the difference between any two consecutive elements is the same.
    Given an array of numbers arr, return true if the array can be rearranged to form an arithmetic progression. Otherwise, return false.*/
    public static bool CanMakeArithmeticProgression(int[] arr)
    {
        Array.Sort(arr);
        for(int i = 2; i < arr.Length; i++)
        {
            if(arr[i] - arr[i-1] != arr[i-1] - arr[i-2]) return false;
        }
        return true;
    }
}