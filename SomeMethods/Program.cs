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
            Values method = new Values();
            int x = method.EquationReturnX(3, 62, 21);
            string str = method.NotationOfNumber(99);
            bool h = method.FindRange(0);
            int sum = method.ReturnSummOfValuesFromAtoBDivOnSeven(1, 10);
            int f = method.FindFibonachiValue(7);
            int odd = method.FindOddValuesOfNumber(7);
            int reverse = method.ReverseValue(423);
            bool result = method.CompareValues(322, 4265555);
            Console.WriteLine(odd);
            Console.ReadLine();
        }
    }
}