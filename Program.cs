using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DictionaryCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable myHashTable = new Hashtable();
            myHashTable.Add('1', "one");
            myHashTable.Add('2', "two");
            myHashTable.Add('3', "three");
            myHashTable.Add('4', "four");
            myHashTable.Add('5', "five");
            myHashTable.Add('6', "six");
            myHashTable.Add('7', "seven");
            myHashTable.Add('8', "eight");
            myHashTable.Add('9', "nine");
            string numbers = "982137465";
            foreach (char number in numbers)
            {
                if (Char.IsDigit(number))
                {
                    Console.WriteLine(myHashTable[number]);
                }
            }
            Console.Read();

        }
    }
}
