using System;
public class Kata
{
    public static int[] Get_size(int w, int h, int d)
    {
        int[] returnArray = new int[2];
        int totalSurfaceArea = (2 * (w * h)) + (2 * (h * d)) + (2 * (w * d));
        int volume = w * h * d;
        returnArray = [totalSurfaceArea, volume];
        return (returnArray);
    }
}