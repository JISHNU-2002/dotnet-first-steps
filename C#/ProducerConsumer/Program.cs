using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;

/*
1. Use a ConcurrentQueue<int> for thread-safe communication
2. One Producer thread will enqueue numbers
3. One or more Consumer threads will dequeue and process numbers
4. Use a CancellationToken to stop after some time
*/

class ProducerConsumer{
    static void Main(){
        var q = new ConcurrentQueue<int>();
        var cancellationToken = new CancellationTokenSource();

        Task Producer = Task.Run(()=>{
            int counter = 1;
            while(!cancellationToken.Token.IsCancellationRequested){
                q.Enqueue(counter);
                Console.WriteLine($"Produced: {counter}");
                counter++;
                Thread.Sleep(500);
            }
        });

        Task Consumer = Task.Run(()=>{
            while(!cancellationToken.Token.IsCancellationRequested || !q.IsEmpty){
                if(q.TryDequeue(out int item)){
                    Console.WriteLine($"Consumed: {item}");
                    Thread.Sleep(500);
                }
            }
        });

        Thread.Sleep(2000);
        cancellationToken.Cancel();
        Task.WaitAll(Producer, Consumer);
        Console.WriteLine("Process Completed");
    }
}