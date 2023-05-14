using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ScriptHelper
{
    static class  Utils
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

        public static string rightOfArrow(string input)
        {
            int startIndex = input.IndexOf('>');
            if (startIndex != -1)
            {
                return input.Substring(startIndex + 1);
            }
            return input;
        }

        public static string JSONFixer(string incorrectJson)
        {
            // remove trailing and leading space

            incorrectJson = incorrectJson.Trim();
            
            // Remove whitespace between double [[ or ]]
            incorrectJson = Regex.Replace(incorrectJson, @"\[\s+\[", "[[");
            incorrectJson = Regex.Replace(incorrectJson, @"\]\s+\]", "]]");

            // Remove white space ", " to ","

            
            incorrectJson = Regex.Replace(incorrectJson, "\",\\s+", "\",");

            //inserts missing " at beginning and end of string


            incorrectJson = InsertQuote(incorrectJson);

            incorrectJson = incorrectJson.Substring(1, incorrectJson.Length - 2);
            incorrectJson = incorrectJson.Replace("[[", "[").Replace("]]", "]");
            incorrectJson = "[" + incorrectJson + "]";
            return incorrectJson;
        }

        public static string InsertQuote(string inputString)
        {
            var sb = new StringBuilder();

            for (int i = 0; i < inputString.Length; i++)
            {
                sb.Append(inputString[i]);

                // Check for the pattern '",x' where x is any character not '"'
                if (i > 1 && inputString[i - 2] == '"' && inputString[i - 1] == ',' && inputString[i] != '"')
                {
                    // Insert '"' before x
                    sb.Insert(sb.Length - 1, '"');
                }
            }

            return sb.ToString();
        }
        public static void nop()
        {
            return;
        }
    }
}
