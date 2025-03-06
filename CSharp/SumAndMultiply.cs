public class Kata
{
    public static int[] SumAndMultiply(int sum, int multiply)
    {
        int[] sumAndProduct = new int[2];
        int x;
        int y;

        for (int i = 0; i <= sum; i++)
        {
            x = i;
            for (int j = 0; j <= sum; j++)
            {
                y = j;

                if ((x + y) == sum)
                {
                    if ((x * y) == multiply)
                    {
                        sumAndProduct[0] = x;
                        sumAndProduct[1] = y;
                        return sumAndProduct;
                    }
                }
            }
        }
        return null;
    }
}