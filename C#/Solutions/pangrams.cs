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

class pangrams_Result
{

    /*
     * Complete the 'pangrams' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string pangrams(string s)
    {
        char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        int[] comparison = new int[alpha.Length];

        foreach (char c in s.ToUpper().Replace(" ", ""))
        {
            var index = Array.IndexOf(alpha, c);
            comparison[index]++;
        }

        //if (Array.Find(comparison, ele => ele == 0) == 0)
        if (comparison.Any(num => num == 0))
            return "not pangram";

        return "pangram";
    }

}

class pangrams_Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = pangrams_Result.pangrams(s);

        //textWriter.WriteLine(result);
        Console.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}
