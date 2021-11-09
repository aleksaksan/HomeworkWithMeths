using System;
using Core;

namespace MyMethods
{
    public class Hw6
    {
        // task1
        public void SolveTask1()
        {
            Console.WriteLine("Поменять знак на противоположный у всех элементов, расположенных по краям двумерного массива NxM");

            int[,] myArr = Helper.InitDArr();
            Console.WriteLine();
            ChangeSign(myArr);
            Helper.PrintMatrix(myArr);
        }
        public void ChangeSign(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (i == 0 || j == 0 || i == arr.GetLength(0) - 1 || j == arr.GetLength(1) - 1)
                        arr[i, j] *= -1;
                }
        }
        // task2
        public void SolveTask2()
        {
            Console.WriteLine("Таблица умножений");
            Helper.PrintMatrix(GetMultiMatrix());
        }
        public int[,] GetMultiMatrix()
        {
            int[,] arr = new int[9, 9];
            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(0); j++)
                    arr[i, j] = (i + 1) * (j + 1);
            return arr;
        }
        //task3
        public void SolveTask3()
        {
            Console.WriteLine("Шахматная доска\n");
            int n = DataInput.GetIntNumFromUser("введите размер поля: ");

            Helper.PrintMatrix(GetChessDesc(n));
        }
        public byte[,] GetChessDesc(int n)
        {
            if (n < 0)
                return new byte[,] { };
            byte[,] arr = new byte[n, n];
            bool state = true;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                if (n % 2 == 0)
                    SwitchState(ref state);
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    SwitchState(ref state);
                    if (state)
                        arr[i, j] = 1;
                    else
                        arr[i, j] = 0;
                }
            }
            return arr;
        }
        public void SwitchState(ref bool x)
        {
            x = !x;
        }
        //task4
        public void SolveTask4()
        {
            Console.WriteLine("Зрительный зал и ковид\n");
            byte[,] hall = InitHallArr();

            if (CheckCovid(hall))
                Console.WriteLine("санитарные меры соблюдаются!");
            else
                Console.WriteLine("всем хана: штраф + смерть от Covid'a!");
        }
        public static byte[,] InitHallArr() //метод для генерации зала
        {
            Console.WriteLine("Введите количество мест в зале MxN");
            int mDimention = DataInput.GetIntNumFromUser("M = ");
            int nDimention = DataInput.GetIntNumFromUser("N = ");

            Random rnd = new Random();
            byte[,] arr = new byte[mDimention, nDimention];
            Console.WriteLine();
            for (int i = 0; i < mDimention; i++)
            {
                for (int j = 0; j < nDimention; j++)
                {
                    if (rnd.Next(1, 10) > 7)
                        arr[i, j] = 1;
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            return arr;
        }
        public bool CheckCovid(byte[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(1) - 1; j++)
                {
                    if (arr[i, j] == 1 && arr[i, j + 1] == 1)
                        return false;
                }
            return true;
        }
        //task 5

        public void SolveTask5()
        {
            Console.WriteLine("Магазин\n");
            double[,] shops = InitIncomesArr(10);
            GetIncomeEveryShop(shops);
            GetAveregeForShop(shops);
            GetMinMaxForShop(shops);

        }
        public static double[,] InitIncomesArr(int amountShops) //метод для генерации таблицы с доходами
        {
            Random rnd = new Random();
            double[,] arr = new double[amountShops, 6];
            Console.WriteLine();
            for (int i = 0; i < amountShops; i++)
            {
                Console.Write($"магазин {i}:\t");
                for (int j = 0; j < 6; j++)
                {
                    arr[i, j] = Math.Round(rnd.NextDouble() * 100000, 2);
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("_________________________________________");
            return arr;
        }
        // a)
        public double[] GetIncomeEveryShop(double[,] arr)
        {
            double[] income = new double[arr.GetLength(0)];
            income.Initialize();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                    income[i] += arr[i, j];
                Console.WriteLine($"прибыль магазина {i + 1}:\t{Math.Round(income[i], 2)}");
            }
            Console.WriteLine("_________________________________________");
            return income; // для теста
        }
        // b)
        public double[] GetAveregeForShop(double[,] arr)
        {
            double[] income = new double[arr.GetLength(0)];
            double temp;
            income.Initialize();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                temp = 0;
                for (int j = 0; j < arr.GetLength(1); j++)
                    temp += arr[i, j];
                income[i] = temp / 6;
                Console.WriteLine($"средний доход магазина {i + 1}:\t{Math.Round(income[i], 2)}");
            }
            Console.WriteLine("_________________________________________");
            return income; // для теста
        }
        // c)
        public double[,] GetMinMaxForShop(double[,] arr)
        {
            if (arr.GetLength(1) == 0)
                return new double[,] { };
            double[,] income = new double[arr.GetLength(0), 2];
            income.Initialize();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                double tempMax = arr[i, 0];
                double tempMin = arr[i, 0];
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (tempMin > arr[i, j])
                        tempMin = arr[i, j];
                    if (tempMax < arr[i, j])
                        tempMax = arr[i, j];
                }
                income[i, 0] = tempMin;
                income[i, 1] = tempMax;
                Console.WriteLine($"минимальный и максимальный доход магазина {i + 1}:\t{Math.Round(income[i, 0], 2)}" +
                    $"\t{Math.Round(income[i, 1], 2)}");
            }
            Console.WriteLine("_________________________________________");
            return income; // для теста
        }
        //task 6
        public void SolveTask6()
        {
            Console.WriteLine("Найти количество элементов массива, которые больше всех своих соседей одновременно");

            int[,] myArr = Helper.InitDArr();


            Console.WriteLine($"количество элементов массива, " +
                $"которые больше всех своих соседей одновременно: {CountOfBiggers(myArr)}");
        }
        public int CountOfBiggers(int[,] arr)
        {
            int resCounter = 0;
            //середина
            for (int i = 1; i < arr.GetLength(0)-1; i++)
            {
                for (int j = 1; j < arr.GetLength(1)-1; j++)
                {
                    if (arr[i, j] > arr[i + 1, j] && arr[i, j] > arr[i, j + 1] && 
                        arr[i, j] > arr[i - 1, j] && arr[i, j] > arr[i, j - 1])
                        resCounter++;
                }
            }
            //края
            for (int i = 1; i < arr.GetLength(0) - 1; i++)
            {
                if (arr[i, 0] > arr[i + 1, 0] && arr[i, 0] > arr[i - 1, 0] && arr[i, 0] > arr[i, 1])
                    resCounter++;
            }
            for (int i = 1; i < arr.GetLength(0) - 1; i++)
            {
                if (arr[i, arr.GetLength(1) - 1] > arr[i + 1, arr.GetLength(1) - 1] &&
                    arr[i, arr.GetLength(1) - 1] > arr[i - 1, arr.GetLength(1) - 1] &&
                    arr[i, arr.GetLength(1) - 1] > arr[i, arr.GetLength(1) - 1 - 1])
                    resCounter++;
            }for (int j = 1; j < arr.GetLength(1) - 1; j++)
            {
                if (arr[0, j] > arr[0, j+1] && arr[0, j] > arr[0, j - 1] && arr[0, j] > arr[1, j])
                    resCounter++;
            }
            for (int j = 1; j < arr.GetLength(1) - 1; j++)
            {
                if (arr[arr.GetLength(0) - 1, j] > arr[arr.GetLength(0) - 1, j+1] && 
                    arr[arr.GetLength(0) - 1, j] > arr[arr.GetLength(0) - 1, j-1] &&
                    arr[arr.GetLength(0) - 1, j] > arr[arr.GetLength(0) - 1 - 1, j]
                    )
                    resCounter++;
            }
            //углы
            if (arr[0, 0] > arr[0, 1] && arr[0, 0] > arr[1, 0])
                resCounter++;
            if (arr[arr.GetLength(0) - 1, 0] > arr[arr.GetLength(0) - 1, 1] && 
                arr[arr.GetLength(0) - 1, 0] > arr[arr.GetLength(0) - 1 - 1, 0])
                resCounter++;
            if (arr[0, arr.GetLength(1) - 1] > arr[1, arr.GetLength(1) - 1] && 
                arr[0, arr.GetLength(1) - 1] > arr[1, arr.GetLength(1) - 1 - 1])
                resCounter++;
            if (arr[arr.GetLength(0) - 1, arr.GetLength(1) - 1] > arr[arr.GetLength(0) - 1 - 1, arr.GetLength(1) - 1] && 
                arr[arr.GetLength(0) - 1, arr.GetLength(1) - 1] > arr[arr.GetLength(0) - 1, arr.GetLength(1) - 1 - 1])
                resCounter++;

                    return resCounter;
        }

        //task 7
        public void SolveTask7()
        {
            Console.WriteLine("Заполнить массив из символов (char) указанным образом");

            byte[,] myArr = MakeABytePicture(7);
            Helper.PrintMatrix(myArr);
            //myArrChars = ConvertBytePicToChars(myArr);
            //Helper.PrintMatrix(myArrChars);
        }
        public byte[,] MakeABytePicture(int N)
        {
            byte[,] arr = new byte[N, N];
            arr.Initialize();
            for (int i = 0; i < arr.GetLength(0) / 2 + arr.GetLength(0) % 2; i++)
            {
                for (int j = i; j < arr.GetLength(0) - i; j++)
                {
                    arr[i, j] = 1;
                    arr[arr.GetLength(0) - i - 1, j] = 1;
                }
            }
            return arr;
        }
        public char[,] ConvertBytePicToChars(byte[,] arr)
        {
            char[,] arrc = new char[arr.GetLength(0), arr.GetLength(1)];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                    if (arr[i, j] == 1)
                        arrc[i, j] = '1';
                    else
                        arrc[i, j] = '0';
            }
            return arrc;
        }
        //task 8

        public void SolveTask8()
        {
            Console.WriteLine("Перемножение матриц");

            int[,] arr1 = Helper.InitDArr();
            int[,] arr2 = Helper.InitDArr();
            Console.WriteLine("________________________________________________\n\nResultMatrix:");
            Helper.PrintMatrix(MultiplexMatrix(arr1, arr2));
        }
        public int[,] MultiplexMatrix(int[,] arr1, int[,] arr2)
        {
            if (arr1.GetLength(1) != arr2.GetLength(0))
                throw new ArgumentException("невозможно перемножить входные матрицы!\n");
            int[,] resArr = new int[arr1.GetLength(0), arr2.GetLength(1)];
            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    resArr[i, j] = 0;
                    
                    for (int k = 0; k < arr1.GetLength(1); k++)
                    {
                        resArr[i, j] += arr1[i, k] * arr2[k, j];
                    }
                }
            }
            return resArr;
        }
    }
}
