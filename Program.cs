using System;
using CSharp_Delegates_master;

namespace CSharp_Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            MathService m = new MathService();

            var result = m.MathDelegate(5,8);

            Console.WriteLine("Result: " + result);

        }
    }
}
