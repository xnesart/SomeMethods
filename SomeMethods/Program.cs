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
            string str = method.NotationOfNumber(20);
            bool h = method.FindRange(0);
            int sum = method.ReturnSummOfValuesFromAtoBDivOnSeven(-10, 20);
            int f = method.FindFibonachiValue(2);
            int odd = method.FindOddValuesOfNumber(000);
            int reverse = method.ReverseValue(-2);
            bool result = method.CompareValues(322, -322);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}