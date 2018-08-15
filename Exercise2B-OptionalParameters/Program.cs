using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2B_OptionalParameters
{
    class Program
    {
        void ShirtType(string color = "blue", int size = 32)
        {
            Console.WriteLine("My shirt is a {0}, and it's a great shade of {1}", size, color);
        }
        static void Main(string[] args)
        {
            /* "Syntactic sugar" is a syntax designed to and does help humans read and use programming language
            */
        }
    }
}
