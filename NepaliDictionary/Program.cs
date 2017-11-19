using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NepaliDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            DictionaryContext context = new DictionaryContext();
            List<Data> data = DataFileReader.ProcessDirectory(@"C:\Users\xneox\Downloads\nep_eng", "*.html");
            context.Data.AddRange(data);
            context.SaveChanges();
            context.Dispose();
        }
    }
}
