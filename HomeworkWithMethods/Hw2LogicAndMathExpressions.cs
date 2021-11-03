using System;
using Core;

namespace MyMethods
{
    public class Hw2LogicAndMathExpressions
    {
        //task1
        public void SolveTask1()
        {
            //const int numA = 735;
            int numA = DataInput.GetIntNumFromUser("введите число: ");
            int[] arr = DivideOnDigits(numA);
            int sum = SumInArr(arr);
            Console.Write($"{numA} = {sum}(");
            WriteReverseArr(arr);
            Console.WriteLine(")");
        }
        int[] DivideOnDigits(int val)
        {
            int size = 1;
            var tempVal = val;
            do
            {
                tempVal /= 10;
                size++;
            }
            while (tempVal / 10 != 0);

            int[] res = new int[size];
            for (int i = 0; i < res.Length; i++)
            {
                res[i] = val % 10;
                val /= 10;
            }
            return res;
        }
        int SumInArr(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
                sum += arr[i];
            return sum;
        }
        void WriteReverseArr(int[] arr)
        {
            for (int i = arr.Length - 1; i > 0; i--)
                Console.Write($"{arr[i]} + ");
            Console.Write(arr[0]);
        }
        //task2
        public void SolveTask2()
        {
            double x1 = DataInput.GetDoubleNumFromUser("введите координату x: ");
            double y1 = DataInput.GetDoubleNumFromUser("введите координату y: ");
            double R = DataInput.GetDoubleNumFromUser("введите радиус окружности R: ");
            if (IsInRound(x1, y1, R))
                Console.WriteLine("Есть пробитие!");
            else
                Console.WriteLine("Промах!");
        }
        bool IsInRound(double x, double y, double r)
        {
            //x^2 + y^2 = R^2
            return x * x + y * y <= r * r ? true : false;
        }
        //task3
        public void SolveTask3()
        {
            int num = DataInput.GetIntNumFromUser("Введите трехзначное число: ");
            Console.WriteLine(IsInHalf(DivideOnDigits(num)));
        }
        bool IsInHalf(int[] arr)
        {
            return arr[0] >= arr[1] && arr[1] > arr[2] ? true : false;
        }
        //task4
        public void SolveTask4()
        {
            int num = DataInput.GetIntNumFromUser("Введите трехзначное число: ");
            Console.WriteLine($"новое число: {GetMirrorNum(num)}");
        }
        int GetMirrorNum(int num)
        {
            int mirNum = 0;
            while (num > 0)
            {
                mirNum *= 10;
                mirNum += num % 10;
                num /= 10;
            }
            return mirNum;
        }
        //task5
        public void SolveTask5()
        {
            double num = DataInput.GetDoubleNumFromUser("введите дробное число: ");
            Console.WriteLine(IsHaveFractPart(num));
        }
        bool IsHaveFractPart(double num)
        {
            return num == (int)num ? true : false;
        }
    }
}
