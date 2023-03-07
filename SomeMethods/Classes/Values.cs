using System;

namespace SomeMethods.Classes
{
    public class Values
    {
        //Метод получает на вход 3 числа (A, B и С).
        //Верните решение (значение X) линейного уравнения стандартного вида, где A*X+B=C.
        public int EquationReturnX(int a, int b, int c)
        {
            if (a == 0)
            {
                throw new ArgumentException("А = 0, это деление на 0, ошибка");
            }
            int x = (c - b) / a;

            return x;
        }
        
        //2) Метод получает на вход 2 числа (A и B).
        //Если A больше B, подсчитать A+B, если A равно B, подсчитать A*B, если A меньше B, подсчитать A-B.
        public int CompareNumbersAndCalculate(int a, int b)
        {
            int result = 0;
            if (a > b)
            {
                Console.WriteLine(a + b);
                result = a + b;
            }
            else if (a == b)
            {
                Console.WriteLine(a * b);
                result = a * b;

            }
            else if (a < b)
            {
                Console.WriteLine(a - b);
                result = a - b;

            }

            return result;
        }
        
        //Метод получает на вход двузначное число.
        //Верните прописную запись этого числа. Например при вводе “25” в консоль будет выведено “двадцать пять”.
        public string NotationOfNumber(int value)
        {
            if (value < 10 || value > 99 || value == 0)
            {
                throw new ArgumentException("Ожидалось двузначное число, ошибка");
            }
            int a = (value / 10) * 10;
            int b = value % 10;
            string result = "";

            if (value > 9 && value < 20)
            {

                switch (value)
                {

                    case 10:
                        result += "десять";
                        break;
                    case 11:
                        result += "одиннадцать";
                        break;
                    case 12:
                        result += "двенадцать";
                        break;
                    case 13:
                        result += "тринадцать";
                        break;
                    case 14:
                        result += "четырнадцать";
                        break;
                    case 15:
                        result += "пятнадцать";
                        break;
                    case 16:
                        result += "шестнадцать";
                        break;
                    case 17:
                        result += "семнадцать";
                        break;
                    case 18:
                        result += "восемнадцать";
                        break;
                    case 19:
                        result += "девятнатцать";
                        break;
                }
            }
            else
            {
                switch (a)
                {
                    case 20:
                        result += "двадцать ";
                        break;
                    case 30:
                        result += "тридцать ";
                        break;
                    case 40:
                        result += "сорок ";
                        break;
                    case 50:
                        result += "пятьдесят ";
                        break;
                    case 60:
                        result += "шестьдесят ";
                        break;
                    case 70:
                        result += "семьдесят ";
                        break;
                    case 80:
                        result += "восемьдесят ";
                        break;
                    case 90:
                        result += "девяносто ";
                        break;


                }
                switch (b)
                {
                    case 1:
                        result += "один";
                        break;
                    case 2:
                        result += "два";
                        break;
                    case 3:
                        result += "три";
                        break;
                    case 4:
                        result += "четыре";
                        break;
                    case 5:
                        result += "пять";
                        break;
                    case 6:
                        result += "шесть";
                        break;
                    case 7:
                        result += "семь";
                        break;
                    case 8:
                        result += "восемь";
                        break;
                    case 9:
                        result += "девять";
                        break;
                    case 10:
                        result += "десять";
                        break;

                }
            }
            return result;
        }
        
        //Метод получает на вход число. Проверить попадает ли оно в один из диапазонов:
        //от 0 до 10, от 20 до 30 или от 40 до 50.
        //*Здесь хорошим вариантом будет вернуть true или false.
        public bool FindRange(int value)
        {
            if (value >= 0 && value <= 10 || value >= 20 && value <= 30 || value >= 40 && value <= 50)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        //Метод получает на вход 2 числа (A и B). Верните сумму всех чисел из
        //диапазона от A до B, которые делятся на 7.
        public int ReturnSummOfValuesFromAtoBDivOnSeven(int a, int b)
        {
            if (a > b)
            {
                throw new ArgumentException("первое число больше второго, ошибка");
            }
            int sum = 0;
            for (int i = a; i <= b; i++)
            {
                if (i % 7 == 0)
                {
                    sum++;
                }
            }

            return sum;
        }
        
        //Метод получает на вход положительное число (N). Верните N-ое число ряда Фибоначчи.
        public int FindFibonachiValue(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("аргумент не может быть меньше 0");
            }
            int fb1 = 1;
            int fb2 = 1;
            int fibonachi = 1;
            if (value == 1)
            {
                return fibonachi;
            }
            else
            {
                for (int i = 2; i < value; i++)
                {
                    fibonachi = fb1 + fb2;
                    fb1 = fb2;
                    fb2 = fibonachi;
                }

                return fibonachi;
            }
        }
        
        //Метод получает на вход число. Найти количество нечетных цифр этого числа.
        public int FindOddValuesOfNumber(int value)
        {
            if (value < 0)
            {
                value *= -1;
            }
            int temp = 0;
            int odd = 0;
            while (value > 0)
            {
                temp = value % 10;
                value = value / 10;
                if (temp % 2 != 0)
                {
                    odd++;
                }
            }

            return odd;
        }
        
        //Метод получает на вход число. Найти число, которое является зеркальным
        public int ReverseValue(int value)
        {
            int negativeControl = 0;
            if (value < 0)
            {
                value *= -1;
                negativeControl++;
            }
            string newValueString = "";
            int newValue = 0;
            if (value % 10 == 0)
            {
                throw new ArgumentException("число не должно заканчиваться на 0, ошибка");
            }
            while (value > 0)
            {
                newValueString += value % 10;
                value /= 10;
            }
            newValue = int.Parse(newValueString);
            if (negativeControl == 1)
            {
                newValue *= -1;
            }

            return newValue;
        }
        //Метод получает на вход 2 числа. Сообщите, есть ли в написании двух чисел одинаковые цифры.
        //Например, для пары 123 и 345, ответом будет являться true, а, для пары 500 и 999 - false.
        public bool CompareValues(int a, int b)
        {
            if (a < 0 && b > 0)
            {
                a *= -1;
            } else if (b < 0 && a > 0)
            {
                b *= -1;
            }
            int temp1 = 0;
            int temp2 = 0;
            bool result = false;
            if (a == b)
            {
                result = true;
            }
            while (a > 0)
            {
                temp1 = a % 10;
                a = a / 10;
                while (b > 0)
                {
                    temp2 = b % 10;
                    b = b / 10;
                    if (temp1 == temp2)
                    {
                        result = true;
                    }
                }
            }

            return result;
        }
    }

}
