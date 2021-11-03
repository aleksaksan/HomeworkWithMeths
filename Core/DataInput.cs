using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public static class DataInput
    {
        public static double GetDoubleNumFromUser(string msg)
        {
            Console.Write(msg);
            return double.Parse(Console.ReadLine());
        }
        public static int GetIntNumFromUser(string msg)
        {
            Console.Write(msg);
            return int.Parse(Console.ReadLine());
        }
        public static string GetStringFromUser(string msg)
        {
            Console.Write(msg);
            return Console.ReadLine();
        }
        /// <summary>
        /// Запрос на ввод нескольких параметров типа int
        /// </summary>
        /// <param name="numOfRequests">количество запросов на ввод</param>
        /// <param name="symbol">символ, с которого начинается перечисление</param>
        /// <returns></returns>
        public static int[] GetIntArrFromUser(int numOfRequests, char symbol)
        {
            int[] arr = new int[numOfRequests];
            for (int i = 0; i < numOfRequests; i++)
            {
                arr[i] = GetIntNumFromUser($"Введите {(char)(symbol + i)}: ");
            }
            return arr;
        }
    }
}
