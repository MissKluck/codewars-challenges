public class KyuSix
{
    public int Multiples(int value)
    {
        //https://www.codewars.com/kata/514b92a657cdc65150000006
        int result = 0;
        for (int i = 0; i < value; i++)
        {
            //Console.WriteLine(i);
            if (i % 3 == 0 || i % 5 == 0)
            {
                result += i;
            }

            //i % 3 = 1;

        }
        return result;
    }
}