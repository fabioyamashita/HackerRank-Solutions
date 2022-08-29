using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class drawing_book_Result
{

    /*
     * Complete the 'pageCount' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER p
     */

    public static int pageCount(int n, int p)
    {
        var pagesFlipFromFirstPage = 0.0;
        var pagesFlipFromLastPage = 0.0;

        if (p % 2 == 0)
        {
            pagesFlipFromFirstPage = Math.Ceiling((p - 1) / 2.0);
            pagesFlipFromLastPage = Math.Floor((n - p) / 2.0);
        }
        else
        {
            pagesFlipFromFirstPage = Math.Floor((p - 1) / 2.0);
            pagesFlipFromLastPage = Math.Ceiling((n - p) / 2.0);
        }

        return Math.Min((int)pagesFlipFromFirstPage, (int)pagesFlipFromLastPage);
    }

}

class drawing_book_Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        int p = Convert.ToInt32(Console.ReadLine().Trim());

        int result = drawing_book_Result.pageCount(n, p);

        Console.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}
