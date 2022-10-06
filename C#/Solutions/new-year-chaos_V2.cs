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

class minimumBribes_Result2
{

    /*
     * Complete the 'minimumBribes' function below.
     *
     * The function accepts INTEGER_ARRAY q as parameter.
     */

    /*
     * Not 100% Solution
     * Time limit exceeded problem!!!
     */

    public static void minimumBribes(List<int> q)
    {
        // Bubble Sort Algorithm
        int n = q.Count;
        int countBribes = 0;

        for (int i = 0; i < n; i++)
        {
            int max = q.Count;

            // Difference between current position X original position
            int difference = max - q.IndexOf(max) - 1;

            if (difference > 2)
            {
                Console.WriteLine("Too chaotic");
                return;
            }

            countBribes += difference;
            q.Remove(max);
        }

        Console.WriteLine(countBribes);
    }

}

class minimumBribes_Solution2
{
    public static void Main(string[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> q = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(qTemp => Convert.ToInt32(qTemp)).ToList();

            minimumBribes_Result.minimumBribes(q);
        }
    }
}