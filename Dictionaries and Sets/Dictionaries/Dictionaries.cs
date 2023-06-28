using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Dictionaries_and_Sets.Dictionaries
{
    public class Dictionaries
    {
        //in hash table we couldn't specift type of our variables
        //in dictionary we can specify that too
        public static void Main()
        {
            Dictionary<string,string> myDictionary = new Dictionary<string,string>
            {
                {"03","Ali"},
                {"2","A"},
                {"3","B"},
            };
            foreach (KeyValuePair<string,string> pair in myDictionary)
            {
                Console.WriteLine($"{pair.Key}-{pair.Value}");
            }
            //same as hashtable we can't have duplicate key
        }
    }
}
