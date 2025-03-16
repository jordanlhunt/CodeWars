using System;

public static class Kata
{
    public static int ElevatorDistance(int[] array)
    {
        int sumTotalFloorsTraveled = 0;
        int previousFloor = array[0];
        int currentFloor = array[0];
        foreach (int floor in array)
        {
            currentFloor = floor;
            if (currentFloor != previousFloor)
            {
                sumTotalFloorsTraveled += Math.abs(currentFloor - previousFloor);
            }
            previousFloor = currentFloor;
        }
        return sumTotalFloorsTraveled;
    }
}