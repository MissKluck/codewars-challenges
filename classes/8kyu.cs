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
        int litres = 0;
        if (time > 1)
        {
            double water = 0.5;
            litres = (int)(time * water);
            return litres;
        }
        else
        {
            return 0;
        }
        //the reason this works is because we put (int) before (time * water), which converts the double time to int before it multiplies
        //alternate solution from codewars; 
        //return (int)(time/2);
        //public static int Litres(double time) => (int)(time*0.5);

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