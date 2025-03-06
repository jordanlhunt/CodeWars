using System;

public class Kata
{
  public static int Multiply(int number)
  {
    int numberOfDigits = 0;
    if (number < 0)
    {
      numberOfDigits = number.ToString().Length - 1;
    }
    else
    {
      numberOfDigits = number.ToString().Length;
    }
    int product = number * (int)Math.Pow(5, numberOfDigits);
    return product;
  }
}