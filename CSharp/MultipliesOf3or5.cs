public static class Kata
{
  public static int Solution(int value)
  {
    int sumOfMultiples = 0;
    if (value > 0)
    {
      for (int i = 1; i < value; i++)
      {
        if (i % 3 == 0 || i % 5 == 0)
        {
          sumOfMultiples += i;
        }
      }
    }
    return sumOfMultiples;
  }
}