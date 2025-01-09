public class KyuSeven
{
    public static int GetVowelCount(string str)
    {
        //https://www.codewars.com/kata/54ff3102c1bad923760001f3
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