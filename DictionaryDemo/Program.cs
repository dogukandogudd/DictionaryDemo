using System;
using System.Collections.Generic;

namespace DictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> country = new MyDictionary<int, string>();
            country.Add(06, "Ankara");
            country.Add(09, "Aydın");
            country.Add(34, "İstanbul");
            country.Add(35, "İzmir");

        }
    }
}
