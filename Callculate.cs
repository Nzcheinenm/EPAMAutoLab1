using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class Callculate
    {
        public void Count(int val1, int val2, int func)
        {
            switch (func)
            {
                case 1:
                    Console.WriteLine("Сумма = " + FuncSum(val1, val2));
                    break;
                case 2:
                    Console.WriteLine("Вычитание = " + FuncDed(val1, val2));
                    break;
                case 3:
                    Console.WriteLine("Деление = " + FuncDiv(val1, val2));
                    break;
                case 4:
                    Console.WriteLine("Умножение = " + FuncMult(val1, val2));
                    break;
                default:
                    Console.WriteLine("Вы ввели неверное число.");
                    break;
            }
        }

        public int FuncSum(int val1, int val2)
        {
            return val1 + val2;
        }

        public int FuncDed(int val1, int val2)
        {
            return val1 - val2;
        }

        public int FuncDiv(int val1, int val2)
        {
            return val1 / val2;
        }

        public int FuncMult(int val1, int val2)
        {
            return val1 * val2;
        }
    }
}
