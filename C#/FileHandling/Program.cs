using System;
using System.IO;

namespace TextFileIO{
    public class FileOP{
        public void IO(){
            string path = "sample.txt";
            File.WriteAllText(path, "Hello C#..!");
            Console.WriteLine("File written successfully");

            File.AppendAllText("sample.txt", "\nAppended line.");

            string content = File.ReadAllText(path);
            Console.WriteLine("Content: " + content);

            using (StreamWriter fp = new StreamWriter(path)){
                for(int i=0; i<4; i++){
                    fp.WriteLine(Console.ReadLine());
                }
            }

            using (StreamReader fo = new StreamReader(path)){
                string line;
                while((line = fo.ReadLine()) != null){
                    Console.WriteLine(line);
                }
            }
        }
    }
}

namespace BinaryFileIO{
    public class FileOP{
        public void Bin(){
            using (FileStream fs = new FileStream("student.bin", FileMode.Create))
            using (BinaryWriter writer = new BinaryWriter(fs)){
                Console.Write("Enter number of students: ");
                int n = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < n; i++){
                    Console.Write("Name: ");
                    writer.Write(Console.ReadLine());   
                    Console.Write("Roll No: ");
                    writer.Write(Console.ReadLine());
                }

                Console.WriteLine("Data written to student.bin");
            }

            using (FileStream fs = new FileStream("student.bin", FileMode.Open))
            using (BinaryReader reader = new BinaryReader(fs)){
                Console.WriteLine("\nReading from binary file:");
                while (fs.Position < fs.Length){
                    string name = reader.ReadString();
                    string roll = reader.ReadString();
                    Console.WriteLine($"Name: {name}, Roll: {roll}");
                }
            }
        }
    }
}

class Program{
    static void Main(){
        Console.WriteLine("1. Text File Operations\n2. Binary File Operations\nEnter choice: ");
        string choice = Console.ReadLine();

        switch (choice){
            case "1": new TextFileIO.FileOP().IO(); break;
            case "2": new BinaryFileIO.FileOP().Bin(); break;
            default: Console.WriteLine("Invalid choice!"); break;
        }
    }
}
