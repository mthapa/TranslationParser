using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NepaliDictionary
{
    class DictionaryContext : DbContext
    {
        public DbSet<Data> Data { get; set; }
      
        public DictionaryContext()
			: base("name=DefaultConnection")
		{

        }
    }
}
