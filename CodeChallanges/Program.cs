using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{

    /*
     * Complete the simpleArraySum function below.
     */
    static int simpleArraySum(int[] ar)
    {
        /*
         * Write your code here.
         */

        int n = ar.Length;
        int sum = 0;
        for (int i = 0; i < n; i++)
            sum += ar[i];
        return sum;

    }

    public static void Main()
    {

        int[] ar = { 12, 3, 4, 15 };


        Console.Write($"Sum of given array is {simpleArraySum(ar)}");
    }
}
