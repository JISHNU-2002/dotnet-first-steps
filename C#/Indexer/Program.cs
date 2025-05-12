namespace IndexerWClass{
    class Sample{
        private string[] names = new string[5];

        public string this[int index]{
            get{
                if(index >= 0 && index < names.Length){
                    return names[index];
                }else{
                    return "Index Out of Range";
                }
            }
            set{
                if(index >= 0 && index < names.Length){
                    names[index] = value;
                }else{
                    Console.WriteLine("Index Out of Range");
                }
            }
        }
    }
}

namespace MultiParam{
    class Matrix{
         private int[,] data = new int[3, 3];

        public int this[int row, int col]{
            get { return data[row, col]; }
            set{ data[row, col] = value; }
        }
    }
}

namespace Dict{
    class WordDict{
        private Dictionary<string, string> d = new();

        public string this[string word]{
            get => d.ContainsKey(word) ? d[word] : "Not Found";
            set => d[word] = value;
        }
    }
}

class Program{
    static void Main(){
        IndexerWClass.Sample obj = new IndexerWClass.Sample();
        obj[0] = "John";
        obj[1] = "Jane";
        Console.WriteLine(obj[0]);  
        Console.WriteLine(obj[1]);  
        Console.WriteLine(obj[10]);

        MultiParam.Matrix m = new MultiParam.Matrix();
        m[0, 1] = 5;
        Console.WriteLine(m[0, 1]);

        Dict.WordDict d = new Dict.WordDict();
        d["cat"] = "Animal";
        Console.WriteLine(d["cat"]);  
        Console.WriteLine(d["dog"]);  
    }
}