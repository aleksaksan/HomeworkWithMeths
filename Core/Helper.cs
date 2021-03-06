using System;

namespace Core
{
    public static class Helper
    {
        public static void MySwap<T>(ref T a, ref T b) //swap
        {
            T temp = a;
            a = b;
            b = temp;
        }
        public static int[] MyBubbleSort(params int[] arr) //sort
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                        MySwap(ref arr[j], ref arr[j + 1]);
                }
            }
            return arr;
        }
        public static int[] InitArr(int from, int to, int size) //инициализация массива и вывод на экран
        {
            Random rnd = new Random();
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = rnd.Next(from, to);
                Console.Write(arr[i] + "\t");
            }
            Console.WriteLine();
            return arr;
        }
        public static int[,] InitDArr()
        {
            Console.WriteLine("Введите размерность двумерного массива MxN");
            int mDimention = DataInput.GetIntNumFromUser("M = ");
            int nDimention = DataInput.GetIntNumFromUser("N = ");

            Random rnd = new Random();
            int[,] arr = new int[mDimention, nDimention];
            for (int i = 0; i < mDimention; i++)
                for (int j = 0; j < nDimention; j++)
                    arr[i, j] = rnd.Next(1, 10);

            for (int i = 0; i < mDimention; i++)
            {
                for (int j = 0; j < nDimention; j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            return arr;
        }
        public static void PrintIntArr(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + "\t");
            }
            Console.WriteLine();
        }
        public static void PrintMatrix<T>(T[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                    Console.Write(arr[i, j] + "\t");
                Console.WriteLine();
            }
        }
    }
}
