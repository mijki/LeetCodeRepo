namespace LeetCodeRepo.Problems.Programming_skills_I;

public class _1281_SubtractTheProducts {
    public static int SubtractProductAndSum(int n)
    {
        string s = n.ToString();
        int sum = 0, products = int.Parse(s[0].ToString());
        for(int i = 0; i < s.Length; i++)
        {
            sum += int.Parse(s[i].ToString());
            if(i != 0) products *= int.Parse(s[i].ToString());
        }

        return products - sum;
    }
}