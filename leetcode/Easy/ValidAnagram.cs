public class IsAnagramSolution
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length) return false;

        // Assuming only lowercase letters a-z
        // Using an array of size 26 to count occurrences of each letter
        int[] letters = new int[26]; 

        for (int i = 0; i < s.Length; i++)
        {
            // Increment the count for the letter in s and decrement for the letter in t
            letters[s[i] - 'a']++;
            letters[t[i] - 'a']--;
        }

        foreach (int letter in letters)
        {
            if (letter != 0) return false;
        }
        return true;
    }
}