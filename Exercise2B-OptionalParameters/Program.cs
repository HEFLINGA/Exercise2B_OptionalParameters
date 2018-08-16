using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2B_OptionalParameters
{
    class Program
    {

        /*"Syntactic sugar" is a syntax designed to help and does help humans read and use programming language*/

        void ShirtType(string color = "blue", int size = 32)
        {
            Console.WriteLine($"Shirt is {color}, and size {size}");
        }

        void ShirtType(int size)
        {
            ShirtType("red", size);
        }

        void ShirtType()
        {
            ShirtType("Blue");
        }

        static void Main(string[] args)
        {
        }
    }
}
