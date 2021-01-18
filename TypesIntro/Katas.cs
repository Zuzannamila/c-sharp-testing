using System;
using System.Text;

namespace TypesIntro
{
    public class Katas
    {
        // input "hello"
        // output "HeLlO"
        public string ConvertToSassCase(string input)
        {
            if (input.Length == 0)
            {
                return "";
            }
            else if (input.Length > 1)
            {
                char[] delimiters = { '/' };
                string[] splitString = input.Split(delimiters);
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < splitString.Length; i++)
                {
                    char[] charsInLine = splitString[i].ToCharArray();
                    for (int k = 0; k < charsInLine.Length; k++)
                        sb.Append(k % 2 == 0 ? char.ToUpper(charsInLine[k]) : charsInLine[k]);
                }
                // sb.Append('');
                return sb.ToString();
            }

            return input.ToUpper();
        }
    }
}
