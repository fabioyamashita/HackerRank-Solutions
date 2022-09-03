using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class dynamicArrayResult
{

    /*
     * Complete the 'dynamicArray' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. 2D_INTEGER_ARRAY queries
     */

    public static List<int> dynamicArray(int n, List<List<int>> queries)
    {
        // RUNTIME ERROR AT HACKERANK!

        var arr2D = new List<List<int>>();

        for (int i = 0; i < n; i++)
        {
            arr2D.Add(new List<int>());
        }

        var lastAnswer = 0;
        var lastAnswerArr = new List<int>();
        var idx = 0;

        for (int i = 0; i < queries.Count; i++)
        {
            var x = queries[i][1];
            var y = queries[i][2];

            idx = (x ^ lastAnswer) % n;

            if (queries[i][0] == 1)
            {
                arr2D[idx].Add(y);
            }
            else if (queries[i][0] == 2)
            {
                lastAnswer = arr2D[idx][y % arr2D.Count];
                lastAnswerArr.Add(lastAnswer);
            }
        }

        return lastAnswerArr;
    }

}

class dynamicArraySolution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int q = Convert.ToInt32(firstMultipleInput[1]);

        List<List<int>> queries = new List<List<int>>();

        for (int i = 0; i < q; i++)
        {
            queries.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(queriesTemp => Convert.ToInt32(queriesTemp)).ToList());
        }

        List<int> result = dynamicArrayResult.dynamicArray(n, queries);

        Console.WriteLine(String.Join("\n", result));

        //textWriter.Flush();
        //textWriter.Close();
    }
}
