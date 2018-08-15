using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2B_Part2
{
    class Program
    {
        void ShirtType(string color)
        {
            Console.WriteLine("My shirt is a great shade of {0}", color);
        }

        void ShirtType(int size = 32)
        {
            Console.WriteLine("My shirt is a {0}", size);
        }

        static void Main(string[] args)
        {
        }
    }
}
