public class Kata
{
    public static int[] TwoSum(int[] numbers, int target)
    {
        int[] arrayToReturn = new int[2];
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            for (int j = 1; j < numbers.Length; j++)
            {
                if (numbers[i] + numbers[j] == target && i != j)
                {
                    arrayToReturn[0] = i;
                    arrayToReturn[1] = j;

                }
            }
        }
        return arrayToReturn;
    }
}
