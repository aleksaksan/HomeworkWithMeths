using System;
using Core;

namespace MyMethods
{
    class Hw5
    {
        // task 1
        public void SolveTask1()
        {
            Console.WriteLine("Посчитать количества нечетных и четных элементов массива.");
            int size = DataInput.GetIntNumFromUser("введите количество элементов массива: ");
            Console.WriteLine();

            int[] myArr = Helper.InitArr(-10, 10, size);
            Console.WriteLine($"Amount Odds: {GetAmountOdds(myArr)}\nAmount Evens: {GetAmountEvens(myArr)}");
        }
        public int GetAmountOdds(int[] arr)
        {
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                    counter++;
            }
            return counter;
        }
        public int GetAmountEvens(int[] arr)
        {
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                    counter++;
            }
            return counter;
        }
        //task2
        public void SolveTask2()
        {
            Console.WriteLine("Каждый третий элемент массива заменить суммой двух предыдущих элементов.");
            int size = DataInput.GetIntNumFromUser("введите количество элементов массива: ");
            Console.WriteLine();

            int[] myArr = Helper.InitArr(-10, 10, size);
            GetArrWithSumOfTwoNeighbElems(myArr);
            Helper.PrintIntArr(myArr);

        }
        //надеюсь, что правильно понял из задания: если заменить, а не вставить...
        public void GetArrWithSumOfTwoNeighbElems(int[] arr)
        {
            for (int i = 0; i < arr.Length; i += 2)
            {
                arr[i + 2] = arr[i] + arr[i + 1];
            }
        }
        //task3
        public void SolveTask3()
        {
            Console.WriteLine("Слить два целочисленных массива в один (должен получиться третий массив).");
            int size = DataInput.GetIntNumFromUser("введите количество элементов 1 массива: ");
            int[] myArr1 = Helper.InitArr(-10, 10, size);
            size = DataInput.GetIntNumFromUser("введите количество элементов 2 массива: ");
            int[] myArr2 = Helper.InitArr(-10, 10, size);
            Console.WriteLine();
            int[] arr = MergeTwoArrays(myArr1, myArr2);
            Helper.PrintIntArr(arr);

        }
        public int[] MergeTwoArrays(int[] arr1, int[] arr2)
        {
            int[] resArr = new int[arr1.Length + arr2.Length];
            for (int i = 0; i < arr1.Length; i++)
                resArr[i] = arr1[i];
            for (int i = 0; i < arr2.Length; i++)
                resArr[i + arr1.Length - 1] = arr2[i];
            return resArr;
        }

        //task4
        public void SolveTask4()
        {
            Console.WriteLine("Поменять местами первую и вторую половину массива, например,\n" +
                "для массива 1 2 3 4, результат 3 4 1 2,  или для  1 2 3 4 5 - 4 5 1 2 3.");
            int size = DataInput.GetIntNumFromUser("введите количество элементов массива: ");
            Console.WriteLine();

            int[] myArr = Helper.InitArr(-10, 10, size);
            ChangeHalves(myArr);
            Helper.PrintIntArr(myArr);
        }
        public int[] ChangeHalves(int[] arr) 
        {
            for (int i = 0; i < arr.Length / 2; i++)
            {
                Helper.MySwap(ref arr[i], ref arr[i + arr.Length / 2]); // 1 2 3 4 5 - 4 5 1 2 3
                //Helper.MySwap(ref arr[i], ref arr[i + arr.Length / 2 + arr.Length % 2]); //12345 - 45312
            }
            return arr;
        }
        //task5
        public void SolveTask5()
        {
            Console.WriteLine("Циклически двинуть массив вправо на N элементов");
            int size = DataInput.GetIntNumFromUser("введите количество элементов массива: ");
            int[] myArr = Helper.InitArr(-10, 10, size);
            Console.WriteLine();
            size = DataInput.GetIntNumFromUser("введите N: ");

            SheeftLoopArr(myArr, 1);
            Helper.PrintIntArr(myArr);
            SheeftLoopArr(myArr, size);
            Helper.PrintIntArr(myArr);
        }
        public void SheeftLoopArr(int[] arr, int n)
        {
            for (int j = 0; j < n; j++) 
            {
                int tempLast = arr[arr.Length-1];
                for (int i = arr.Length - 1; i > 1; i--)
                {
                    arr[i] = arr[i - 1];
                }
                arr[0] = tempLast;    
            }
        }
        //task6
        
        public void SolveTask6()
        {
            Console.WriteLine("Преобразовать массив так, чтобы на четных позициях стояли элементы с нечетных позиций.\nO(N/2)");
            int size = DataInput.GetIntNumFromUser("введите количество элементов массива: ");
            int[] myArr = Helper.InitArr(-10, 10, size);

            SwapNeighbInArr(myArr);
            Helper.PrintIntArr(myArr);
        }
        public void SwapNeighbInArr(int[] arr)
        {
            for (int i = 0; i < arr.Length / 2; i+=2)  
            {
                Helper.MySwap(ref arr[i], ref arr[i + 1]);
            }
        }
        //task7
        public void SolveTask7()
        {
            Console.WriteLine("a) минимальный по модулю элемент массива; " +
                "б) сумму элементов, расположенных после первого нулевого элемента");
            int size = DataInput.GetIntNumFromUser("введите количество элементов массива: ");
            int[] myArr = Helper.InitArr(-10, 10, size);

            Console.WriteLine($"минимальный по модулю элемент массива: {FindABSMin(myArr)}");
            Console.WriteLine($"суммa элементов, расположенных после первого нулевого элемента {GetSumAfterZero(myArr)}");

        }
        public int FindABSMin(int[] arr)
        {
            int min = arr[0];
            if (min < 0)
                min *= -1;
            for (int i = 1; i < arr.Length; i += 2)
            {
                int temp = arr[i];
                if (temp < 0)
                    temp *= -1;
                if (temp < min)
                    min = temp;
            }
            return min;
        }
        public int GetSumAfterZero(int[] arr)
        {
            bool zeroFlag = false;
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                    zeroFlag = true;
                if (zeroFlag)
                    sum += arr[i];
            }
            return sum;
        }
        //task 8
        public void SolveTask8()
        {
            Console.WriteLine("алгоритмом вставок (insert)");
            int size = DataInput.GetIntNumFromUser("введите количество элементов массива: ");
            int[] myArr = Helper.InitArr(-10, 10, size);
            InsertSort(myArr);
            Helper.PrintIntArr(myArr);

        }
        public void InsertSort(int[] arr) 
        {
            int temp;
            int j;

            for (int i = 1; i < arr.Length; i++)
            {
                temp = arr[i];
                j = i - 1;
                for (j = i - 1; j >= 0 && arr[j] > temp; j--)
                {
                    arr[j + 1] = arr[j];
                }
                arr[j + 1] = temp;
            }
        }
        //task 9
        public void SolveTask9()
        {
            Console.WriteLine("алгоритмом выборки (select)");
            int size = DataInput.GetIntNumFromUser("введите количество элементов массива: ");
            int[] myArr = Helper.InitArr(-10, 10, size);
            SelectSort(myArr);
            Helper.PrintIntArr(myArr);

        }
        public void SelectSort(int[] arr)
        {
            int minIdx;
            for (int i = 0; i < arr.Length - 2; i++)
            {
                minIdx = i;
                for (int j = i + 1; j < arr.Length - 1; j++)
                    if (arr[j] < arr[minIdx])
                        minIdx = j;
                if (minIdx != i)
                    Helper.MySwap(ref arr[i], ref arr[minIdx]);
            }
        }
    }
}
