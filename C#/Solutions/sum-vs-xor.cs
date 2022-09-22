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

class sumXor_Result
{

    /*
     * Complete the 'sumXor' function below.
     *
     * The function is expected to return a LONG_INTEGER.
     * The function accepts LONG_INTEGER n as parameter.
     */

    public static long sumXor(long n)
    {
        // n = 0 | count = 1

        #region Test cases n = 1
        // n = 1 (1) | count = 1
        // decimal 1 + 0 = 1 (01) | bitwise 1 ^ 0 = 1 -> ok
        // decimal 1 + 1 = 2 (11) | bitwise 1 ^ 1 = 0
        #endregion

        #region Test cases n = 2
        // n = 2 (10) | count = 2
        // decimal 2 + 0 = 2 (010) | bitwise 10 ^ 00 = 10 -> ok
        // decimal 2 + 1 = 3 (011) | bitwise 10 ^ 01 = 11 -> ok
        // decimal 2 + 2 = 4 (100) | bitwise 10 ^ 10 = 00 
        #endregion

        #region Test cases n = 3
        // n = 3 (11) | count = 0
        // decimal 3 + 0 = 3 (011) | bitwise 11 ^ 00 = 000
        // decimal 3 + 1 = 4 (100) | bitwise 11 ^ 01 = 010
        // decimal 3 + 2 = 5 (101) | bitwise 11 ^ 10 = 001 
        // decimal 3 + 3 = 6 (110) | bitwise 11 ^ 11 = 000
        #endregion

        #region Test cases n = 4
        // n = 4 (100) | count = 4
        // decimal 4 + 0 = 4 (0100) | bitwise 0100 ^ 0000 = 0100 -> ok
        // decimal 4 + 1 = 5 (0101) | bitwise 0100 ^ 0001 = 0101 -> ok
        // decimal 4 + 2 = 6 (0110) | bitwise 0100 ^ 0010 = 0110 -> ok 
        // decimal 4 + 3 = 7 (0111) | bitwise 0100 ^ 0011 = 0111 -> ok
        // decimal 4 + 4 = 8 (1000) | bitwise 0100 ^ 0100 = 0000
        #endregion

        #region Test cases n = 5
        // n = 5 (101) | count = 2
        // decimal 5 + 0 = 5 (0101)  | bitwise 0101 ^ 0000 = 0101 -> ok
        // decimal 5 + 1 = 6 (0110)  | bitwise 0101 ^ 0001 = 0100
        // decimal 5 + 2 = 7 (0111)  | bitwise 0101 ^ 0010 = 0111 -> ok
        // decimal 5 + 3 = 8 (1000)  | bitwise 0101 ^ 0011 = 0110
        // decimal 5 + 4 = 9 (1001)  | bitwise 0101 ^ 0100 = 0011
        // decimal 5 + 5 = 10 (1010) | bitwise 0101 ^ 0101 = 0000
        #endregion

        // CONCLUSION
        // number of cases that satisfies n + x = n ^ x:
        // Math.Pow(2, number of zeros bitwise)

        if (n == 0) return 1;

        var zeros = Convert.ToString(n, 2).Count(b => b == '0');
        var cases = (long)Math.Pow(2, zeros);

        return cases;
    }

}

class sumXor_Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        long n = Convert.ToInt64(Console.ReadLine().Trim());

        long result = sumXor_Result.sumXor(n);

        Console.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}
