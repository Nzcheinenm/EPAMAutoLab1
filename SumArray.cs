using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class SumArray
    {
        public int[] RandArray()
        {
            int[] array = new int[20];
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
                array[i] = rand.Next(1,10);
            return array;
        }

        public int SumValue(int[] arr)
        {
            int sum = 0;
            for (int i=0;i<arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    sum += arr[i];
                }
            }
            return sum;
        }

        public String MultupliValue(int[] arr)
        {
            String mult = "";
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    mult +=" " + arr[i];
                }
            }
            return mult;
        }
    }
}
