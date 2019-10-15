using System;
using CSharp_Delegates_master;

namespace CSharp_Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            MathService service = new MathService();
            service.OutboundDelegate += OnOutboundDelegate;
            var result = service.MathDelegate(5,8);
        }

        static void OnOutboundDelegate(double result)
        {
            Console.WriteLine("Result: " + result);

        }
    }
}
