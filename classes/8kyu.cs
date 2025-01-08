using System.ComponentModel;

public class KyuEight
{
    public static string EvenOrOdd(int number)
    {
        // alternate solution; return number % 2 == 0 ? "Even" : "Odd";
        if (number % 2 == 0)
        {
            return "Even";
        }
        else
        {
            return "Odd";
        }
        // Code goes here ...
    }

    public static int Litres(double time)
    {
        //The fun begins here.

        return 0;
    }

    public static string NumberToString(int num)
    {
        // code here
        string myString;
        return myString = num.ToString();
    }

    public static string Solution(string str)
    {
        throw new NotImplementedException("TODO: Kata.Solution(string) => string");
        char[] charArray = str.ToArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}