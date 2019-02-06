using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Shoe s = new Shoe();

            Console.WriteLine(s.ToString());
            Console.WriteLine(new System.Random().ToString());
            Console.WriteLine(5.GetType());
            Console.WriteLine(5.ToString());
            Console.WriteLine("A" + 5);

            Console.ReadLine();
        }
    }
}
