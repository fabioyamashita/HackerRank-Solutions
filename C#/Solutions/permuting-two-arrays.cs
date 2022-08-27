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

class permuting_two_arrays_Result
{

    /*
     * Complete the 'twoArrays' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts following parameters:
     *  1. INTEGER k
     *  2. INTEGER_ARRAY A
     *  3. INTEGER_ARRAY B
     */

    public static string twoArrays(int k, List<int> A, List<int> B)
    {
        var maxValueA = A.Max();
        var minValueA = A.Min();

        var maxValueB = B.Max();
        var minValueB = B.Min();

        var maxValueACount = A.Count(a => a == A.Max());
        var minValueACount = A.Count(a => a == A.Min());
        
        var maxValueBCount = B.Count(b => b == B.Max());
        var minValueBCount = B.Count(b => b == B.Min());

        var condition1 = minValueA + maxValueB >= k && minValueACount <= maxValueBCount;
        var condition2 = minValueB + maxValueA >= k && minValueBCount <= maxValueACount;

        if (condition1 || condition2)
        {
            return "YES";
        }

        return "NO";
    }
}

class permuting_two_arrays_Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine().Trim());

        for (int qItr = 0; qItr < q; qItr++)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int k = Convert.ToInt32(firstMultipleInput[1]);

            List<int> A = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(ATemp => Convert.ToInt32(ATemp)).ToList();

            List<int> B = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(BTemp => Convert.ToInt32(BTemp)).ToList();

            string result = permuting_two_arrays_Result.twoArrays(k, A, B);

            Console.WriteLine(result);
        }

        //textWriter.Flush();
        //textWriter.Close();
    }
}
