using System;
using System.Collections.Generic;
using System.Linq;

namespace AutoPractice8.DictionaryEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> simpleRedBook = CreateSimpleDictionary();
            var simpleCount = simpleRedBook.Count;
            List<string> keyList = simpleRedBook.Keys.ToList();
            List<string> values = simpleRedBook.Values.ToList();

            Dictionary<string, Definition> bigBook = CreateComplexDictionary();
            Definition defAdore = bigBook["adore"];

            var def2 = new Definition { Word = "adore", PartOfSpeech = "verb", Meaning = "love and respect deeply." };
            bigBook.Remove("adore");

            if (!bigBook.ContainsKey("adore"))
            {
                bigBook.Add("adore", def2);
            }

            bigBook.Remove("adore", out Definition def3);

            if (!bigBook.ContainsValue(def2))
            {
                Console.WriteLine("The value not exist in the dictionary");
            }

            var action = simpleRedBook["action"];
            if (simpleRedBook.TryGetValue("action", out string value))
            {
                Console.WriteLine("For key action found value {0}", value);
            }
        }

        public static Dictionary<string, string> CreateSimpleDictionary()
        {
            Dictionary<string, string> book = new Dictionary<string, string>();
            book.Add("acorn", "the fruit of the oak, a smooth oval nut in a rough cuplike base.");
            book.Add("adore", "love and respect deeply.");
            book.Add("available", "able to be used or obtained");

            return book;
        }

        public static Dictionary<string, Definition> CreateComplexDictionary()
        {
            Dictionary<string, Definition> book = new Dictionary<string, Definition>();
            var def1 = new Definition { Word = "acorn", PartOfSpeech = "noun", Meaning = "the fruit of the oak, a smooth oval nut in a rough cuplike base." };
            var def2 = new Definition { Word = "adore", PartOfSpeech = "verb", Meaning = "love and respect deeply." };
            var def3 = new Definition { Word = "available", PartOfSpeech = "adjective", Meaning = "able to be used or obtained" };
            book.Add("acorn", def1);
            book.Add("adore", def2);
            book.Add("available", def3);

            return book;
        }
    }
}