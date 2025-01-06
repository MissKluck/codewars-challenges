public class KyuSeven
{
    public static int GetVowelCount(string str)
    {
        // alternative solution return str.Count(i => "aeiou".Contains(i));
        int vowelCount = 0;
        string vowels = "aeiou";
        foreach (char ch in str)
        {
            if (vowels.Contains(ch))
            {
                vowelCount++;
            }
        }
        return vowelCount;
    }
}