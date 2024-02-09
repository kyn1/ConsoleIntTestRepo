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
        private const string dllPath = @"C:\Users\hfumato\source\repos\CppDll2\x64\Debug\CppDll2.dll";
        [DllImport(dllPath)]
        public static extern int Multiply(int a, int b);

        [DllImport(dllPath)]
        public static extern double Divide(double a, double b);

        static void Main(string[] args)
        {
            int num1 = 43;
            int num2 = 4;

            double num3 = 54.0;
            double num4 = 2.0;

            int result = Multiply(num1, num2);
            double resultdivde = Divide(num3, num4);
            Console.WriteLine($"Result from multiplication from cpp:{result} and result for division cpp: {resultdivde}" );
        }
    }
}
