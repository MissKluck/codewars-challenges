using System.ComponentModel;

public class KyuEight
{
    public static string EvenOrOdd(int number)
    {
        //https://www.codewars.com/kata/53da3dbb4a5168369a0000fe
        //alternate solution; return number % 2 == 0 ? "Even" : "Odd";
        if (number % 2 == 0)
        {
            return "Even";
        }
        else
        {
            return "Odd";
        }
    }

    public static int Litres(double time)
    {
        //https://www.codewars.com/kata/582cb0224e56e068d800003c/train/csharp
        return 0;
    }

    public static string NumberToString(int num)
    {
        //https://www.codewars.com/kata/5265326f5fda8eb1160004c8 
        // alternate solution which was close to what I was thinking originally; return num.ToString();
        string myString;
        return myString = num.ToString();
    }

    public static string Solution(string str)
    {
        //https://www.codewars.com/kata/5168bb5dfe9a00b126000018/train/csharp
        //alternate solution from codewars; return new string(str.ToArray().Reverse().ToArray());
        //throw new NotImplementedException("TODO: Kata.Solution(string) => string");
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}