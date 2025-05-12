using System.Collections.Concurrent;
using System.Threading.Tasks;

class Log{
    static void Main(){
        var logUser = new ConcurrentDictionary<int, string>();

        Parallel.For(1, 6, id => {
            string uname = $"User{id}";
            bool add = logUser.TryAdd(id, uname);
            Console.WriteLine(add ? $"{uname} login" : $"{uname} login failed");
        });

        Parallel.For(1, 4, id => {
            if(logUser.TryRemove(id, out string removedUser)){
                Console.WriteLine($"{removedUser} logout");
            }
        });

        Console.WriteLine("\nLogin Users");
        foreach(var l in logUser){
            Console.WriteLine($"{l.Key} : {l.Value}");
        }
    }
}