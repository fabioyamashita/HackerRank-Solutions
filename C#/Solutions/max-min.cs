using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class maxMinResult
{

    /*
     * Complete the 'maxMin' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER k
     *  2. INTEGER_ARRAY arr
     */

    public static int maxMin(int k, List<int> arr)
    {
        arr.Sort();

        // Raw method
        //var unfairness = int.MaxValue;
        //for (int i = 0; i <= arr.Count - k; i++)
        //{
        //    var maxMin = arr[i + k - 1] - arr[i];

        //    if (unfairness > maxMin)
        //        unfairness = maxMin;
        //}

        // Linq Method
        var unfairness = arr.Zip(arr.Skip(k - 1), (min, max) => max - min).Min();

        return unfairness;
    }

}

class maxMinSolution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        int k = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = new List<int>();

        for (int i = 0; i < n; i++)
        {
            int arrItem = Convert.ToInt32(Console.ReadLine().Trim());
            arr.Add(arrItem);
        }

        int result = maxMinResult.maxMin(k, arr);

        Console.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}

