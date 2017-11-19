using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NepaliDictionary
{
    public class DataParser
    {
        public static List<Data> Parse(string input)
        {
            List<Data> dictionaryList = new List<Data>();
           
            int count = 0;
            string[] parsedData = new String[4];
            foreach (Match m in Regex.Matches(input, @">([^<]*)<\/p>"))
            {
                parsedData[count] = ExtractWord(m.Value);
                if (count == 3)
                {                   
                    dictionaryList.Add(DataFactory.Create(parsedData[0], parsedData[1], parsedData[2], parsedData[3]));
                    count = 0;
                }
                else
                {
                    count++;
                }                
            }
            return dictionaryList;
        }

        public static string  ExtractWord(string input)
        {
            return input.Replace("</p>", "").Substring(1);
        }
    }
}
