using System;
using System.Collections.Generic;

namespace Dictionarycalisma
{
    class MyDictionary
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> AdNo = new Dictionary<string, int>();
            AdNo.Add("Fatma", 123);
            AdNo.Add("Sevgi", 456);
            AdNo.Add("İlknur", 789);
            AdNo.Add("Sonnur", 354);

            foreach (var listele in AdNo)
            {
                Console.WriteLine(listele);
            }
            

        }

        
    }
}
