
using System.Collections;
//  WAP to replace all negative value with its immediate left elements square.
//  Means arr[] = [12, 3,-19, 29, 5, -61, 44, 7, -9]
//  Output array will be [12, 3, 9, 29, 5, 25, 44, 7, 49].


public class Program
{
    public static void Main(string[] args)
    {
        int[] arr = new int[8];
        Console.WriteLine("Enter Array Elements");

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        int[] outputArray = new int[8];
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < 0)
            {
                outputArray[i] = arr[i - 1] * arr[i - 1];
            }
            else
            {
                outputArray[i] = arr[i];
            }
        }
        Console.WriteLine();
        foreach (var item in outputArray)
        {
            Console.Write(item+" ");
        }
    }

}
