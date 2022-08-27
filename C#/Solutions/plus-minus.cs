using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class plus_minus_Result
{

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     * 
     */

    public static void plusMinus(List<int> arr)
    {
        int positiveCount = 0;
        int negativeCount = 0;
        int zeroCount = 0;

        for (int i = 0; i < arr.Count; i++)
        {
            if (arr[i] > 0)
                positiveCount++;

            else if (arr[i] < 0)
                negativeCount++;

            else
                zeroCount++;
        }

        Console.WriteLine(((double)positiveCount/arr.Count).ToString("F6", CultureInfo.InvariantCulture));
        Console.WriteLine(((double)negativeCount/arr.Count).ToString("F6", CultureInfo.InvariantCulture));
        Console.WriteLine(((double)zeroCount/arr.Count).ToString("F6", CultureInfo.InvariantCulture));
    }

}

class plus_minus_Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        plus_minus_Result.plusMinus(arr);
    }
}
