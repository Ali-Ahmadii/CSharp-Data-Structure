using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Runtime.InteropServices;

namespace DS.Dictionaries_and_Sets.Hash_tables
{
    public class HashTables
    {
        public static void Main()
        {
            Hashtable mytable = new Hashtable();
            mytable.Add("03", "Ali");
            //Attention no duplicated key!!
            mytable.Add("22","S");
            mytable.Add("X","Z");
            mytable.Add("M","G");
            Console.WriteLine(mytable["03"]);
            //with try and cathc we can prevent duplicate keys in hashtable
            try
            {
                mytable.Add("03","A");
            }
            catch (Exception e)
            {
                Console.WriteLine("An Element with that key already exists");
                
            }
            //we can change value of key
            mytable["22"] = "Sa";
            Console.WriteLine(mytable["22"]);
            //ContainsKey function can be used to check that key exists or not(boolean)
            Console.WriteLine(mytable.ContainsKey("22"));
            foreach (DictionaryEntry d in mytable)
            {
                Console.WriteLine("Key = {0}, Value = {1}",d.Key,d.Value);
            }
            // To get the values alone, use the Values property.
            //ICollection valueColl = mytable.Values;
        }
    }
}
