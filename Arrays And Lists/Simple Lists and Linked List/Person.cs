using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Arrays_And_Lists.Simple_Lists
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public CountryEnum Country { get; set; }

        public enum CountryEnum
        {
            China,
            Russia,
            USA
        }

    }
}
