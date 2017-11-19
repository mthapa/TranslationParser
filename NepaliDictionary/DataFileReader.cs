using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NepaliDictionary
{
    public class DataFileReader
    {

        public static List<Data> ProcessDirectory(string targetDirectory, string pattern)
        {
            List<Data> dictionaryList = new List<Data>();
         
            DirectoryInfo dir = new DirectoryInfo(targetDirectory);

            var fileEntries = dir.GetFiles().OrderBy(p => ExtractNumberFromFileName(p.Name)).ToArray();
            foreach (FileInfo  fileName in fileEntries)
                dictionaryList.AddRange(ProcessFile(fileName.FullName ));
            return dictionaryList;
        }

   
        public static List<Data> ProcessFile(string path)
        {
            return  DataParser.Parse(File.ReadAllText(path));            
        }

        static int  ExtractNumberFromFileName(string FileName)
        {
            return Int16.Parse(FileName.Replace("nep_eng-", "").Replace(".html", ""));
        }
    }
}
