namespace LeetCodeRepo.Problems.Programming_skills_I;

public class _191_NumberOfOneBits {
    
    public static int HammingWeight(uint n)
    {
        int count = 0;
        while(n!=0)
        {
            if (n % 2 == 0) count++;
            else if(n == 1) count++;
            n = n / 2;
        }
        return count;
        /*string input = n.ToString();
        int count = 0;
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '1') count++;
        }

        return count;*/
        //return Convert.ToInt32(n.ToString().Count( x => x == '1'));
    }
}