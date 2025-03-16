using System;
public class NewAverage
{
  public static long NewAvg(double[] arr, double navg)
  {
    double arraySum = 0;
    foreach (double donation in arr)
    {
      arraySum = arraySum + donation;
    }
    double nextDonation = (navg * (arr.Length + 1)) - arraySum;
    if (nextDonation <= 0)
    {
      throw new ArgumentException(String.Format("{0} I don't understand the test", navg));
    }
    return (long)Math.Ceiling((double)nextDonation);
  }
}