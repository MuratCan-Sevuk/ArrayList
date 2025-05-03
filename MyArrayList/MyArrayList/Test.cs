using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            MyArrayList list = new MyArrayList();
            list.Add("Merhaba");
            list.Add(123);
            list.Insert(1, "Dünya");
            list.RemoveAt(0);
            Console.WriteLine(list.Get(1));
            
            Console.WriteLine("Eleman Sayısı: " + list.Count);
            Console.WriteLine("Liste: " + list.ToString());
        }
    }
}
