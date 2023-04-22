using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ScriptHelper
{
    class Utils
    {

        public static string TextBetweenBrackets(string input)
        {
            int startIndex = input.IndexOf('[');
            int endIndex = input.IndexOf(']');

            if (startIndex != -1 && endIndex != -1 && endIndex > startIndex)
            {
                return input.Substring(startIndex + 1, endIndex - startIndex - 1);
            }

            return string.Empty;
        }
        public static string makePendingMessage(string model)
        {
            return "awaiting reponse from " + model + "\n";


        }
        public static string stripNonASCII(string input)
        {
            return Regex.Replace(input, @"[^\u0000-\u007F]+", "");
        }
    }
}
