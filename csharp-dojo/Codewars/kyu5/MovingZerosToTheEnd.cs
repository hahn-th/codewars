using System;

namespace Codewars.kyu5;

public class MovingZerosToTheEnd
{
    public static int[] MoveZeroes(int[] arr)
    {
        /* I have tried different approaches. This one ist MUCH MUCH faster instead of my 
        other solution: put everything in a list, delete all zeros and add the removed zeros 
        at the end of the list. */
        bool sorted = false;
        int firstOccurence = Array.IndexOf(arr, 0);
        do
        {
            sorted = false;
            for (int i = arr.Length - 1; i > 0 && i >= firstOccurence; i--)
            {
                if (arr[i - 1] == 0 && arr[i] != 0)
                {
                    int tmp = arr[i];
                    arr[i] = arr[i - 1];
                    arr[i - 1] = tmp;
                    sorted = true;
                }
            }
        } while (sorted);
        return arr;
    }
}