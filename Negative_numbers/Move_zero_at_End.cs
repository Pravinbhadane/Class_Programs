using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Move zeros to beginning or end of array. 

namespace Negative_numbers
{
    internal class Move_zero_at_End
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10] { 5, 6, 0, 0, 0, 9,0,6,9,8};

            int zeroes = arr.Length;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i ; j < arr.Length ; j++)
                {
                    int temp;
                    if (arr[i] == 0)
                    {
                        temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                    }
                }

            }
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
        }
    }
}
