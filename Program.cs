using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1.
            Console.WriteLine("Задание 1.");
            SumArray lab1 = new SumArray();
            int[] arr = lab1.RandArray();
            String s = "";
            for (int i = 0; i < arr.Length; i++)
            {
                s = s + " " + arr[i];
            }
            Console.WriteLine("Массив рандомный - " + s);
            Console.WriteLine("Сумма четных чисел - " + lab1.SumValue(arr));

            //Задание 2.
            Console.WriteLine("/n" + "Задание 2.");
            Console.WriteLine("Строка четных чисел - " + lab1.MultupliValue(arr));

            //Задание 3.
            Console.WriteLine("Задание 3.");
            Callculate calc = new Callculate();

            Console.WriteLine("Введите первое число :");
            int value1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число :");
            int value2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число - номер операции ( 1 - Сумма, 2 - Вычитание, 3 - Деление, 4 - Умножение");
            int func = Convert.ToInt32(Console.ReadLine());
            calc.Count(value1, value2, func);
        }
    }
}
