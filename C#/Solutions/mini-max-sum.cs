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

class mini_max_sum_Result
{

    /*
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void miniMaxSum(List<int> arr)
    {
        long sum = 0;

        foreach(int num in arr)
        {
            sum += Convert.ToInt64(num);
        }

        long maxSum = sum - Convert.ToInt64(arr.Min());
        long minSum = sum - Convert.ToInt64(arr.Max());

        Console.WriteLine($"{minSum} {maxSum}");
    }

}

class mini_max_sum_Solution
{
    public static void Main(string[] args)
    {

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        mini_max_sum_Result.miniMaxSum(arr);
    }
}
