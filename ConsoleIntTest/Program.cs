using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleIntTest
{
    class Program
    {
        private const string dllPath = @"C:\Users\hfumato\source\repos\DllRepo\x64\Debug\DllRepo.dll";
        [DllImport(dllPath)]

        private static extern int Multiply(int a, int b);

        static void Main(string[] args)
        {
            int num1 = 43;
            int num2 = 4;

            int result = Multiply(num1, num2);
            Console.WriteLine($"Result from multiplication from cpp: {result}");
        }
    }
}
