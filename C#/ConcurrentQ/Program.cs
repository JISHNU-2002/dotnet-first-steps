using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;

class Program{
    static void Main(){
        var queue = new ConcurrentQueue<string>();

        // Simulate multiple threads enqueuing
        Parallel.For(1, 6, i => {
            queue.Enqueue($"Task{i}");
            Console.WriteLine($"Enqueued: Task{i}");
        });
        
        if(queue.TryPeek(out string front)){
            Console.WriteLine($"\nCurrent Task : {front}");
        }

        Console.WriteLine("\nDequeuing...");
        // Dequeue all items (single thread)
        while (queue.TryDequeue(out string task)){
            Console.WriteLine($"Processed: {task}");
        }
        Console.WriteLine($"\nRemaining in queue: {queue.Count}");
    }
}