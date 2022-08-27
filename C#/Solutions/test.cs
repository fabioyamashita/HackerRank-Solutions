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


namespace Solutions
{
    internal class test
    {
        static void Main(string[] args)
        {
            char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

            string s = "We promptly judged antique ivory buckles for the next prize".ToUpper().Replace(" ","");

            foreach (char c in s)
            {
                if (!alpha.Contains(c))
                {
                    Console.WriteLine("not pangram");
                    break;
                }

                Console.WriteLine("pangram");
            }
            
        }
    }
}
