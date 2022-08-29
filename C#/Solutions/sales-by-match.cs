using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class sales_by_match_Result
{

    /*
     * Complete the 'sockMerchant' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER_ARRAY ar
     */

    public static int sockMerchant(int n, List<int> ar)
    {
        var pairs = ar
            .GroupBy(p => p)
            .Select(p => p.Count() / 2)
            .Sum();

        return pairs;
    }

}

class sales_by_match_Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

        int result = sales_by_match_Result.sockMerchant(n, ar);

        Console.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}
