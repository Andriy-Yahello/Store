using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Article
{
    class Program
    {
        static void Main()
        {
            Store store = new Store();
            //Article store1 = store;


            //Console.WriteLine(store[0]);

            //string a = Convert.ToString(Console.ReadLine());
            //Console.WriteLine(store[a]);
            Console.WriteLine("Enter an index: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(store[c]);

            Console.WriteLine("Enter an item name: ");
            string b = Convert.ToString(Console.ReadLine());
            Console.WriteLine(store[b]);


            Console.ReadKey();
        }
    }
}
