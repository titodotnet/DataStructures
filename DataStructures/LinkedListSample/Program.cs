using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var linkedList = new LinkedList();

            linkedList.Insert(0, "test first5");
            linkedList.Add("test1");
            linkedList.Add("test2");
            linkedList.Insert(1,"test3");
            linkedList.AddFirst("test4");
            
            linkedList.PrintToConsole();

            Console.WriteLine("After deletion...........");
            linkedList.Remove(0);
            linkedList.Remove(2);

            linkedList.PrintToConsole();

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine($"Index of 'test2' {linkedList.IndexOf("test2")}");
            Console.WriteLine($"Does list contains 'test4' {linkedList.Contains("test4")}");

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Get data section-------------------");
            Console.WriteLine($"GetData(1):{linkedList.GetData(1)}");
            Console.WriteLine($"Indexer[2]:{linkedList[2]}");

            Console.ReadKey();
        }
    }
}
