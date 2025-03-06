using System;

namespace Solution
{
  public class SolutionClass
  {
    public static string EvenOrOdd(int number)
    {
      string returnString = "";
      if (number % 2 == 0)
      {
        returnString = "Even";
      }
      else
      {
        returnString = "Odd";
      }
      return returnString;
    }
  }
}