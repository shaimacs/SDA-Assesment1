using System;
using System.IO;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            

            StreamWriter file = new StreamWriter(@"D:\NET\Phase 1\Assesment1\SDA-Assesment1\filename.txt");
            Console.WriteLine("Enter ID");
            int id = int.Parse(Console.ReadLine());
            file.WriteLine(id);
            Console.WriteLine("Enter Name");
            string name = Console.ReadLine();
            file.WriteLine(name);
            Console.WriteLine("Class Name");
            string _class = Console.ReadLine();
            file.WriteLine(_class);
            Console.WriteLine("Enter Section Name");
            string section = Console.ReadLine();
            file.WriteLine(section);
            file.Close();

            StreamReader reader = new StreamReader(@"D:\NET\Phase 1\Assesment1\SDA-Assesment1\filename.txt");
            string readedData = reader.ReadToEnd();
            reader.Close();

            StreamWriter writer = new StreamWriter(@"D:\NET\Phase 1\Assesment1\SDA-Assesment1\filename.txt", false);
            writer.Write(readedData);
            writer.Close();
        }
        }
}
