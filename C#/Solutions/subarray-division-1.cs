using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class subarray_division_1_Result
{

    /*
     * Complete the 'birthday' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY s
     *  2. INTEGER d
     *  3. INTEGER m
     */

    public static int birthday(List<int> s, int d, int m)
    {
        int countSegments = 0;

        for (int i = 0; i < s.Count - m + 1; i++)
        {
            int sum = 0;

            for (int j = 0; j < m; j++)
            {
                sum += s[j + i];
            }

            if (sum == d)
                countSegments++;
        }

        return countSegments;
    }

}

class subarray_division_1_Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> s = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int d = Convert.ToInt32(firstMultipleInput[0]);

        int m = Convert.ToInt32(firstMultipleInput[1]);

        int result = subarray_division_1_Result.birthday(s, d, m);

        Console.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}


