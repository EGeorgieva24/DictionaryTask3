using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Dictionary<string, int> pets = new Dictionary<string, int>();
        pets.Add("dog", 2);
        pets.Add("cat", 4);
        pets.Add("snake", 1);
        pets.Add("rabbit", 4);
        pets.Add("hedgehog", 8); //I love hedgehogs 
        

        var duplicates = Duplicate(pets);

        if (duplicates.Count > 0)
        {
            foreach (var d in duplicates)
            {
                Console.WriteLine($"{d.Key}: {d.Value} times");
            }
        }
        else
        {
            Console.WriteLine("No duplicates in this dicitonary");
        }

        static Dictionary<int, int> Duplicate(Dictionary<string, int> a)
        {
            Dictionary<int, int> duplicates = new Dictionary<int, int>();
            foreach (var v in a) 
            {
                foreach (var i in a)
                {
                    if (v.Key == i.Key)
                    {
                        continue;
                    }
                    if (v.Value==i.Value && duplicates.ContainsKey(v.Value))
                    {
                        duplicates[v.Value] += 1;
                    }
                    else if (v.Value == i.Value && !duplicates.ContainsKey(v.Value))
                    {
                        duplicates[v.Value] = 1;
                    }
                }
            }
            return duplicates;

        }
    }
}