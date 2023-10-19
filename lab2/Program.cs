using lab2.Constuctions;
using System;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            var construktion = new Construction(23,45,4,6,"Brik");
            Console.WriteLine(construktion.BuiltMaterial);
        }
    }
}