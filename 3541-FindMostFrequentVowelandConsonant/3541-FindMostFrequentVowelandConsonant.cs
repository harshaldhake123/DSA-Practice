// Last updated: 9/13/2025, 9:43:51 PM
public class Solution 
{
    public int MaxFreqSum(string s) 
    {
        int maxVowel = 0, maxConsonant = 0;
        int[] count = new int[26];

        foreach (char c in s) count[c - 'a']++;

        for (int i = 0; i < 26; i++)
        {
            if (i == 0 || i == 4 || i == 8 || i == 14 || i == 20)
                maxVowel = Math.Max(maxVowel, count[i]);
            else
                maxConsonant = Math.Max(maxConsonant, count[i]);
        }

        return maxVowel + maxConsonant;
    }
}