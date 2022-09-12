using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class counterGameResult
{

    /*
     * Complete the 'counterGame' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts LONG_INTEGER n as parameter.
     */

    public static string counterGame(long n)
    {
        var countWinner = 0;

        while (n > 1)
        {
            int y = 1;
            while (Math.Pow(2, y) < n)
            {
                y++;
            }
            y--;

            n = Math.Pow(2, y) == n ? n / 2 : n - Convert.ToInt64(Math.Pow(2, y));

            countWinner++;
        }

        return countWinner % 2 == 0 ? "Richard" : "Louise";
    }

}

class counterGameSolution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            long n = Convert.ToInt64(Console.ReadLine().Trim());

            string result = counterGameResult.counterGame(n);

            Console.WriteLine(result);
        }

        //textWriter.Flush();
        //textWriter.Close();
    }
}
