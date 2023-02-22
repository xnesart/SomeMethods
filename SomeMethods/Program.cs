using SomeMethods.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 method = new Class1();
            int x = method.EquationReturnX(3, 14, 25);
            string str = method.NotationOfNumber(99);
            bool h = method.FindRange(0);
            int sum = method.ReturnSummOfValuesFromAtoBDivOnSeven(1, 10);
            int f = method.FindFibonachiValue(7);
            int odd = method.FindOddValuesOfNumber(0);
            int reverse = method.ReverseValue(423);
            bool result = method.CompareValues(322, 4265555);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
