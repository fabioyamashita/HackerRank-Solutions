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

class time_conversion_Result
{

    /*
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string timeConversion(string s)
    {
        string timeConverted = s;

        if (s.Substring(8, 2) == "PM" && s.Substring(0,2) != "12")
        {
            int hoursConverted = int.Parse(s.Substring(0, 2)) + 12;
            timeConverted = s.Remove(0, 2).Insert(0, Convert.ToString(hoursConverted));
        }

        if (s.Substring(8, 2) == "AM" && s.Substring(0, 2) == "12")
            timeConverted = s.Remove(0, 2).Insert(0, "00");

        return timeConverted.Remove(8, 2);
    }
}

class time_conversion_Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = time_conversion_Result.timeConversion(s);

        Console.WriteLine(result);
        //textWriter.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}
