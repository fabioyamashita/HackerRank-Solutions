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

class bomberMan_Result
{

    /*
     * Complete the 'bomberMan' function below.
     *
     * The function is expected to return a STRING_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. STRING_ARRAY grid
     */
    public static List<List<char>> Explode(List<List<char>> grid, List<string> originalGrid)
    {
        int r = originalGrid.Count;
        int c = originalGrid[0].Length;

        var gridExploded = originalGrid.Select(row => new List<char>(row.Replace('.', 'O').ToList())).ToList();

        for (int row = 0; row < r; row++)
        {
            for (int column = 0; column < c; column++)
            {
                if (grid[row][column] == 'O')
                {
                    gridExploded[row][column] = '.';
                    if (row - 1 >= 0)
                    {
                        gridExploded[row - 1][column] = '.';
                    }
                    if (column - 1 >= 0)
                    {
                        gridExploded[row][column - 1] = '.';
                    }
                    if (row + 1 <= r - 1)
                    {
                        gridExploded[row + 1][column] = '.';
                    }
                    if (column + 1 <= c - 1)
                    {
                        gridExploded[row][column + 1] = '.';
                    }
                }
            }
        }

        return gridExploded;
    }

    public static List<string> bomberMan(int n, List<string> grid)
    {
        // strings are immutable, so i needed to transform List<string> into a List<List<char>>
        var fullBombsGridChar = grid.Select(row => new List<char>(row.Replace('.', 'O').ToList())).ToList();
        var originalRoundGridChar = grid.Select(row => new List<char>(row.ToList())).ToList();

        // Even - fullBombsGridChar: 2,4,6...

        // after n = 3, the pattern repeats after 4 steps
        // pattern 1: 3,7,11,15...
        // pattern 2: 5,9,13,17....
        var resultGridPattern1 = Explode(originalRoundGridChar, grid);
        var resultGridPattern2 = Explode(resultGridPattern1, grid);

        var resultGridChar = new List<List<char>>();

        if (n == 1)
            resultGridChar = originalRoundGridChar;
        else if (n == 3 || n % 4 == 3)
            resultGridChar = resultGridPattern1;
        else if (n % 4 == 1)
            resultGridChar = resultGridPattern2;
        else
            resultGridChar = fullBombsGridChar;

        List<string> resultGrid = new List<string>();
        foreach (var row in resultGridChar)
        {
            resultGrid.Add(new string(row.ToArray()));
        }

        return resultGrid;
    }
}

class bomberMan_Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int r = Convert.ToInt32(firstMultipleInput[0]);

        int c = Convert.ToInt32(firstMultipleInput[1]);

        int n = Convert.ToInt32(firstMultipleInput[2]);

        List<string> grid = new List<string>();

        for (int i = 0; i < r; i++)
        {
            string gridItem = Console.ReadLine();
            grid.Add(gridItem);
        }

        List<string> result = bomberMan_Result.bomberMan(n, grid);

        Console.WriteLine(String.Join("\n", result));

        //textWriter.Flush();
        //textWriter.Close();
    }
}
