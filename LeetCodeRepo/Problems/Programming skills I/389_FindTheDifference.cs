namespace LeetCodeRepo.Problems.Programming_skills_I;

public class _389_FindTheDifference {
    public static char FindTheDifference(string s, string t)
    {
        char diff = new char();
        for(int i = 0; i < s.Length; i++)
        {
            diff += t[i] - s[i];
        }
        return t[t.Length-1];
    }
}