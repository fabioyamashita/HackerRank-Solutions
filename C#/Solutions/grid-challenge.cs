using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class gridChallengeResult
{

    /*
     * Complete the 'gridChallenge' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING_ARRAY grid as parameter.
     */

    public static string gridChallenge(List<string> grid)
    {
        string alphabet = "abcdefghijklmnopqrstuvwxyz";
        var previousIndexAlphabet = 0;
        var currentIndexAlphabet = 0;

        for (int i = 0; i < grid.Count; i++)
        {
            grid[i] = String.Concat(grid[i].OrderBy(x => x));
        }

        for (int i = 1; i < grid.Count; i++)
        {
            for (int j = 0; j < grid[i].Count(); j++)
            {
                previousIndexAlphabet = alphabet.IndexOf(grid[i - 1][j]);
                currentIndexAlphabet = alphabet.IndexOf(grid[i][j]);

                if (previousIndexAlphabet > currentIndexAlphabet)
                    return "NO";
            }
        }

        return "YES";
    }

}

class gridChallengeSolution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<string> grid = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string gridItem = Console.ReadLine();
                grid.Add(gridItem);
            }

            string result = gridChallengeResult.gridChallenge(grid);

            Console.WriteLine(result);
        }

        //textWriter.Flush();
        //textWriter.Close();
    }
}

