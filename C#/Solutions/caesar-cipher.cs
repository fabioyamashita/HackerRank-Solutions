using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class caesar_Cipher_Result
{
    /*
     * Complete the 'caesarCipher' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts following parameters:
     *  1. STRING s
     *  2. INTEGER k
     */

    public static string caesarCipher(string s, int k)
    {
        string originalAlphabet = "abcdefghijklmnopqrstuvwxyz";
        int countAlphabetLength = originalAlphabet.Count();
        var rotationFactor = k % countAlphabetLength;

        var newString = "";
        var newIndex = 0;

        for (int i = 0; i < s.Count(); i++)
        {
            var alphabet = originalAlphabet;
            if (char.IsUpper(s[i]))
            {
                alphabet = originalAlphabet.ToUpper();
            }

            var oldIndex = alphabet.IndexOf(s[i]);

            if (alphabet.Contains(s[i]))
            {
                if (rotationFactor + oldIndex > countAlphabetLength - 1)
                {
                    newIndex = rotationFactor - (countAlphabetLength - 1 - oldIndex) - 1;
                }
                else
                {
                    newIndex = rotationFactor + oldIndex;
                }
            }
            else
            {
                if (char.IsLower(s[i]))
                    newString += s[i];

                else
                    newString += s[i].ToString().ToUpper();
                continue;
            }

            if (char.IsLower(s[i]))
            {
                newString += alphabet[newIndex];
            }
            else
            {
                newString += alphabet[newIndex].ToString().ToUpper();
            }
        }

        return newString;
    }

}

class caesar_Cipher_Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        string s = Console.ReadLine();

        int k = Convert.ToInt32(Console.ReadLine().Trim());

        string result = caesar_Cipher_Result.caesarCipher(s, k);

        Console.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}
