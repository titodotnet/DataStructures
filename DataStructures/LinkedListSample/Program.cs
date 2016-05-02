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

            linkedList.Add("test1");
            linkedList.Add("test2");
            linkedList.Insert(1,"test3");
            linkedList.AddFirst("test4");
        }
    }
}
