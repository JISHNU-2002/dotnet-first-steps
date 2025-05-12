using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;

class ThreadSafe{
    static void Main(){
        string[] words = new string[]{
            "apple", "banana", "apple", "cherry", "banana",
            "apple", "date", "cherry", "date", "banana"
        };

        var wordCount = new ConcurrentDictionary<string, int>();

        Parallel.ForEach(words, word => {
            wordCount.AddOrUpdate(word, 1, (key, orgValue) => orgValue + 1);
        });

        foreach(var pair in wordCount){
            Console.WriteLine($"{pair.Key} : {pair.Value}");
        }
    }
}