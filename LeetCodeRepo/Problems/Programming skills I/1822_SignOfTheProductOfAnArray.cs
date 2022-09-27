namespace LeetCodeRepo.Problems.Programming_skills_I;

public class _1822_SignOfTheProductOfAnArray {
    public static int ArraySign(int[] nums)
    {
        int sign = 1;
        foreach(int num in nums){
            if(num == 0)
                return 0;
            else if(num < 0)
                sign *= -1;
        }
        return sign;
    }
}