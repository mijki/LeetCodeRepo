namespace LeetCodeRepo.Problems.Programming_skills_I;

public class _1768_MergeStringsAlternately {
    public static string mergeAlternately(string word1, string word2)
    {
        char[] wordChars = new char[word1.Length + word2.Length];
        int i = 0, j = 0, k = 0;
        do
        {
            if (i < word1.Length) wordChars[k++] = word1[i++];
            if (j < word2.Length) wordChars[k++] = word2[j++];
        } while (i < word1.Length || j < word2.Length);
        return new string(wordChars);
    }
}