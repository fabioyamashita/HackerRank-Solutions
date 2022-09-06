using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class superDigitResult
{

    /*
     * Complete the 'superDigit' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. STRING n
     *  2. INTEGER k
     */

    public static int superDigit(string n, int k)
    {
        long sum = 0;

        if (n.Length == 1)
        {
            return int.Parse(n);
        }

        while (n.Length > 1)
        {
            sum = 0;

            for (int i = 0; i < n.Length; i++)
            {
                sum += (n[i] - '0');
            }
            
            if (k > 1)
            {
                sum *= k;
                k = 0;
            }

            n = sum.ToString();
        }

        return (int)sum;
    }

    class superDigitSolution
    {
        public static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            string n = firstMultipleInput[0];

            int k = Convert.ToInt32(firstMultipleInput[1]);

            int result = superDigitResult.superDigit(n, k);

            Console.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
