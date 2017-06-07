using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
Write a program which receives a number type (as a string) and prints the maximum and the minimum value of that type.
You can receive one of the following types: “int”, “uint”, “long”, “byte” and “sbyte”. 
*/

namespace TypeBoundaries
{
    class TypeBoundaries
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            
            switch (type)
            {
                case "int":
                    Console.WriteLine(int.MaxValue);
                    Console.WriteLine(int.MinValue);
                    break;
                case "uint":
                    Console.WriteLine(uint.MaxValue);
                    Console.WriteLine(uint.MinValue);
                    break;
                case "long":
                    Console.WriteLine(long.MaxValue);
                    Console.WriteLine(long.MinValue);
                    break;
                case "byte":
                    Console.WriteLine(byte.MaxValue);
                    Console.WriteLine(byte.MinValue);
                    break;
                case "sbyte":
                    Console.WriteLine(sbyte.MaxValue);
                    Console.WriteLine(sbyte.MinValue);
                    break;
            }
        }
    }
}
