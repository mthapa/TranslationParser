using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NepaliDictionary
{
    public class DataFactory
    {
        public static Data Create(string romanization, string nepali, string grammar, string meaning )
        {
            return new Data() { Nepali = nepali, Romanization = romanization, Grammar = grammar, Meaning = meaning };
        }
    }
}
